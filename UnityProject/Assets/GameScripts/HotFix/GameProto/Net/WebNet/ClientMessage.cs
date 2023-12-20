using System;
using System.Collections.Generic;
using TEngine;
using UnityEngine;

public class ClientMessage : BehaviourSingleton<ClientMessage>
{
    private string IP = "127.0.0.1";
    //private string IP = "124.126.5.164";
    private int Port = 9005;
    private ReqId m_ReqId;
    private string m_Account = null;
    private float mPingDeltaTime = 0;
    private float mPingInterval = 10f;
    private byte[] mPingBytes;

    public void SetLoginData(string ip, string ac)
    {
        IP = ip;
        m_Account = ac;
    }

    public void Active()
    {
        mPingBytes = new byte[4];
        Int32 msgId = (int)(ReqId.PingReqId);
        Array.Copy(BitConverter.GetBytes(msgId), 0, mPingBytes, 0, 4);

        WebClient.Instance.Start(IP, Port, m_Account);
        CoroutineTool.Instance.StartCoroutine("ClientMessage", msgListen);
    }
    private void msgListen()
    {
        while (true)
        {
            WebClient.RecievePair pair = WebClient.Instance.GetMsg();
            if (pair == null)
            {
                break;
            }
            onReceiveMsg(pair.result, pair.length);
        }
    }

    private void onReceiveMsg(byte[] data, int totalLen)
    {
        if (data.Length == 0)
        {
            Debug.LogError("no recieve data");
            return;
        }
        //Debug.Log(BitConverter.IsLittleEndian);
        int id = BitConverter.ToInt32(data, 0);
        RespId mid = (RespId)id;
        if ((int)mid == (int)RespId.ErrorRespId)
        {
            Log.Info("RespId:" + mid);
        }
        else //if (ReqId2RespId((int)m_ReqId) == mid)
        {
            if (mid != RespId.PingRespId)
            {
                Log.Info("RespId:" + mid);
            }
            if (mCallBacks.ContainsKey(mid))
            {
                for (int i = 0; i < mCallBacks[mid].Count; ++i)
                {
                    mCallBacks[mid][i]?.Invoke(data);
                }
            }
        }

        if (mCallBacks.ContainsKey(mid))
        {
            mCallBacks[mid].Clear();
        }
        if (mErrorCallBacks.ContainsKey(mid))
        {
            mErrorCallBacks[mid].Clear();
        }
    }

    List<CallBack> mSharedCallBackList = new List<CallBack>();

    public delegate void CallBack(byte[] data);
    public delegate void SyncCallBack(params object[] data);

    private Dictionary<RespId, List<CallBack>> mCallBacks = new Dictionary<RespId, List<CallBack>>();
    private Dictionary<RespId, List<CallBack>> mErrorCallBacks = new Dictionary<RespId, List<CallBack>>();
    public void Register(RespId resultMid, CallBack callBack, CallBack errorCallBack = null)
    {
        if (mCallBacks.ContainsKey(resultMid) == false)
        {
            mCallBacks[resultMid] = new List<CallBack>();
        }
        mCallBacks[resultMid].Add(callBack);

        if (errorCallBack != null)
        {
            if (mErrorCallBacks.ContainsKey(resultMid) == false)
            {
                mErrorCallBacks[resultMid] = new List<CallBack>();
            }
            mErrorCallBacks[resultMid].Add(callBack);
        }
    }

    public void Send(ReqId messageId, bool needLock, byte[] data)
    {
        if (messageId != ReqId.PingReqId)
        {
            Log.Info("ReqId:" + messageId);
        }
        WebClient.Instance.Send(data);
    }

    private RespId ReqId2RespId(int repId)
    {
        return (RespId)(repId + 1000);
    }

    public override void Update()
    {
        if (WebClient.Instance.IsConnected)
        {
            mPingDeltaTime += Time.deltaTime;
            if (mPingDeltaTime > mPingInterval)
            {
                mPingDeltaTime = 0;
                ClientMessage.Instance.Send(ReqId.PingReqId, false, mPingBytes);
                ClientMessage.Instance.Register(RespId.PingRespId, OnPingResp, OnPingErrorResp);
            }
        }
    }

    void OnPingResp(byte[] data)
    {
    }

    void OnPingErrorResp(byte[] data)
    {
    }

    public override void Destroy()
    {
        base.Destroy();
        CoroutineTool.Instance.StopCoroutine("ClientMessage");
    }
}



