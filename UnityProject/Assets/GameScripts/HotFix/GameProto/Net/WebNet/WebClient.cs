using System;
using System.Collections.Generic;
using System.Text;
using TEngine;
using UnityEngine;
using UnityWebSocket;

public class WebClient : BehaviourSingleton<WebClient>
{
    public bool IsConnected;
    private WebSocket mSocket;
    private readonly string[] mSPass = { "sdfsd", "oiuoi", "3215s", "8494s", "sdf00", "ss2sd", "sdf45", "321sd", "s6fsd" };
    private readonly int[] mIPass = { 80, 19, 97, 11, 23, 78, 99, 22, 75 };

    public void Start(string ip, int port, string ac)
    {
        //mSocket = new WebSocket(string.Format("ws://{0}:{1}/game/socket.io/?EIO=4&transport=websocket", ip, port));
        long s0 = System.DateTime.UtcNow.ToFileTimeUtc();
        Debug.Log(s0);
        Debug.Log(System.DateTime.UtcNow);
        int b = (int)(s0 % 9);
        StringBuilder sb = new StringBuilder();
        string account = "";//PlayerData.Instance.Account;
        if (ac == "")
        {
            account = SystemInfo.deviceName + SystemInfo.deviceUniqueIdentifier;
        }
        else
        {
            account = ac;
        }
        //PlayerData.Instance.Account = account;
        sb.Append(mSPass[b]).Append("$").Append(account).Append("$").Append(s0 + mIPass[b]);
        char[] chars = sb.ToString().ToCharArray();
        Array.Reverse(chars);
        string s1 = Convert.ToBase64String(Encoding.UTF8.GetBytes(chars));
        string s = string.Format("ws://{0}:{1}/sc/" + account + "/" + s0 + "/" + s1, ip, port);
        Debug.Log(s);
        mSocket = new WebSocket(s);
        mSocket.OnOpen += Socket_OnOpen;
        mSocket.OnClose += Socket_OnClose;
        mSocket.OnError += Socket_OnError;
        mSocket.OnMessage += OnGetMessage;
        mSocket.ConnectAsync();
        CoroutineTool.Instance.CallMethodAfterSeconds((obj) =>
        {
            CoroutineTool.Instance.StartCoroutine("WebClientCheck", RunSocketThread);
        }, null, 0.1f);
    }

    private void RunSocketThread()
    {
        if (IsConnected)
        {
            return;
        }
        else
        {
            //MessageBox.Instance.ShowMessageWithConfirm(UIComponents.GetDialogStr("10637"), () =>
            //{
            //    EventCenter.Instance.RemoveAllListener();
            //    StateMachine.Instance.ChangeState(StateEnum.Login);
            //});
            CoroutineTool.Instance.StopCoroutine("WebClientCheck");
        }
    }

    public class RecievePair
    {
        public byte[] result;
        public int length;
    }

    private Queue<RecievePair> mRecieveMsgBuffer = new Queue<RecievePair>();

    public RecievePair GetMsg()
    {
        if (mRecieveMsgBuffer.Count == 0)
        {
            return null;
        }
        return mRecieveMsgBuffer.Dequeue();
    }

    public void OnGetMessage(object sender, MessageEventArgs e)
    {
        RecievePair pair = new RecievePair();
        //pair.result = new byte[e.RawData.Length];
        //Array.Copy(e.RawData, pair.result, e.RawData.Length);
        pair.result = e.RawData;
        pair.length = e.RawData.Length;
        mRecieveMsgBuffer.Enqueue(pair);
    }

    private void Socket_OnOpen(object sender, OpenEventArgs e)
    {
        IsConnected = true;
        Debug.Log("connected");
        //PlayerService.Instance.SendLogin();
    }

    private void Socket_OnClose(object sender, CloseEventArgs e)
    {
        Debug.LogError(e.Code + ":" + e.Reason);
        //if (IsConnected)
        //{
        //    Game.GameHotfixEntry.Restart();
        //}
        IsConnected = false;

    }

    private void Socket_OnError(object sender, ErrorEventArgs e)
    {
        Debug.LogError(e.Exception.Message);
    }

    public void Send(byte[] msg)
    {
        if (IsConnected == false)
        {
            Debug.LogError("not connected yet");
            return;
        }
        try
        {
            //Int32 totalSize = msg.Length + 4;
            //byte[] data = new byte[totalSize];
            //Array.Copy(BitConverter.GetBytes(totalSize), 0, data, 0, 4);
            //Array.Copy(msg, 0, data, 4, msg.Length);
            mSocket.SendAsync(msg);
        }
        catch (System.Exception e)
        {
            Debug.LogError(e.Message);
        }
    }

    public void Close()
    {
        if (mSocket == null)
        {
            return;
        }
        mSocket.CloseAsync();
    }

    public override void Destroy()
    {
        base.Destroy();
        Close();
    }
}
