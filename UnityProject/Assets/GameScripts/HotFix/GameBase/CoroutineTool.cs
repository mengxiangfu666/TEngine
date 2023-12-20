using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTool
{
    private static CoroutineTool mInstance;
    public static CoroutineTool Instance
    {
        get
        {
            if (mInstance == null)
            {
                mInstance = new CoroutineTool();
            }
            return mInstance;
        }
    }

    private class CoroutineGameObject : MonoBehaviour
    {
        private List<DelayPair> mNeedDeleteList = new List<DelayPair>();
        private List<string> mNeedDeleteTicks = new List<string>();
        public List<string> mNeedDeleteMonoUpdate = new List<string>();

        private void FixedUpdate()
        {

        }

        void Update()
        {
            CoroutineTool.Instance.stopCoroutine();
            CoroutineTool.Instance.startCoroutines();
            foreach (var item in CoroutineTool.Instance.mCoroutines)
            {
                item.Value();
            }


            Dictionary<string, TickUpdatePair> ticks = CoroutineTool.Instance.mTicks;

            foreach (var item in ticks)
            {
                if (item.Value.StopCheckCall(item.Value.Param) == true)
                {
                    item.Value.CallBackWhenStop(item.Value.Param);
                    mNeedDeleteTicks.Add(item.Value.Key);
                }
            }
            for (int i = 0; i < mNeedDeleteTicks.Count; ++i)
            {
                ticks.Remove(mNeedDeleteTicks[i]);
            }
            mNeedDeleteTicks.Clear();

            Dictionary<string, CoroutineTool.MonoUpdatePair> monoUpdates = CoroutineTool.Instance.mMonoUpdates;
            foreach (var item in monoUpdates)
            {
                item.Value.Update(item.Value.Param1, item.Value.Param2, Time.deltaTime);
            }

            for (int i = 0; i < mNeedDeleteMonoUpdate.Count; ++i)
            {
                monoUpdates.Remove(mNeedDeleteMonoUpdate[i]);
            }
            mNeedDeleteMonoUpdate.Clear();

            List<DelayPair> delayList = CoroutineTool.Instance.mDelayPairs;
            for (int i = 0; i < delayList.Count; ++i)
            {
                if (Time.realtimeSinceStartup - delayList[i].StartTime >= delayList[i].DelayTime)
                {
                    delayList[i].CallBack(delayList[i].Param);
                    mNeedDeleteList.Add(delayList[i]);
                }
            }
            for (int i = 0; i < mNeedDeleteList.Count; ++i)
            {
                delayList.Remove(mNeedDeleteList[i]);
            }
            mNeedDeleteList.Clear();
        }
    }

    private Dictionary<string, System.Action> mCoroutines;
    private GameObject mCoroutineObj;
    private CoroutineGameObject mCoroutineComponent;
    private List<string> mStopList;
    private Dictionary<string, System.Action> mStartList = new Dictionary<string, System.Action>();

    public class DelayPair
    {
        public System.Action<object> CallBack;
        public object Param;
        public float DelayTime;
        public float StartTime;
    }
    private List<DelayPair> mDelayPairs;

    public class MonoUpdatePair
    {
        public delegate void MonoUpdateCall(object param1, object param2, float deltaTime);
        public MonoUpdateCall Update;
        public object Param1;
        public object Param2;
    }
    private Dictionary<string, MonoUpdatePair> mMonoUpdates;

    public bool cheakUpdateKey(string key)
    {
        if (mMonoUpdates.ContainsKey(key) == true)
        {
            return true;
        }
        return false;
    }

    public delegate bool StopWhenReturnTrueTick(object param);
    public class TickUpdatePair
    {
        public string Key;
        public StopWhenReturnTrueTick StopCheckCall;
        public System.Action<object> CallBackWhenStop;
        public object Param;
    }
    private Dictionary<string, TickUpdatePair> mTicks;

    public CoroutineTool()
    {
        mCoroutines = new Dictionary<string, System.Action>();
        mStopList = new List<string>();
        mTicks = new Dictionary<string, TickUpdatePair>();
        mDelayPairs = new List<DelayPair>();
        mMonoUpdates = new Dictionary<string, MonoUpdatePair>();

        mCoroutineObj = new GameObject();
        //mCoroutineObj = GameObject.Instantiate<GameObject>(go);
        UnityEngine.Object.DontDestroyOnLoad(mCoroutineObj);
        mCoroutineComponent = mCoroutineObj.AddComponent<CoroutineGameObject>();
        mCoroutineObj.name = "CoroutineTool";
        //GameObject.Destroy(go);
    }

    public void StartCoroutine(string key, System.Action callBack)
    {
        if (mStartList.ContainsKey(key) == true)
        {
            mStartList[key] = callBack;
        }
        else
        {
            mStartList.Add(key, callBack);
        }
    }

    private void startCoroutines()
    {
        if (mStartList.Count == 0)
        {
            return;
        }
        foreach (var item in mStartList)
        {
            if (mCoroutines.ContainsKey(item.Key) == false)
            {
                mCoroutines.Add(item.Key, item.Value);
            }
            else
            {
                Debug.LogError(item.Key);
            }
        }
        mStartList.Clear();
    }

    public void StopCoroutine(string key)
    {
        mStopList.Add(key);
    }

    public void StopAllCoroutine()
    {
        mCoroutines.Clear();
        mDelayPairs.Clear();
    }
    private void stopCoroutine()
    {
        for (int i = 0; i < mStopList.Count; ++i)
        {
            mCoroutines.Remove(mStopList[i]);
        }
        mStopList.Clear();
    }

    public void CallMethodAfterSeconds(System.Action<object> callBack, object param, float delayTime)
    {
        DelayPair dp = new DelayPair();
        dp.CallBack = callBack;
        dp.Param = param;
        dp.DelayTime = delayTime;
        dp.StartTime = Time.realtimeSinceStartup;
        mDelayPairs.Add(dp);
    }

    public void StartUpdate(string key, StopWhenReturnTrueTick stopWhenReturnTrueCallBack, System.Action<object> callBackWhenStop, object param)
    {
        TickUpdatePair tup = new TickUpdatePair();
        tup.Key = key;
        tup.StopCheckCall = stopWhenReturnTrueCallBack;
        tup.CallBackWhenStop = callBackWhenStop;
        tup.Param = param;
        mTicks.Add(key, tup);
    }

    public Coroutine StartUnityEgineCoroutine(IEnumerator coroutine)
    {
        return mCoroutineComponent.StartCoroutine(coroutine);
    }

    public void CallMethod()
    {

    }

    public void StartMonoUpdate(string key, MonoUpdatePair.MonoUpdateCall update, object param1, object param2)
    {
        MonoUpdatePair mup = new MonoUpdatePair();
        mup.Update = update;
        mup.Param1 = param1;
        mup.Param2 = param2;
        mMonoUpdates.Add(key, mup);
    }

    public void StopMonoUpdate(string key)
    {
        mCoroutineComponent.mNeedDeleteMonoUpdate.Add(key);
    }
}
