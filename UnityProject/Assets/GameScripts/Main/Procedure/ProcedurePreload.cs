﻿using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using TEngine;
using UnityEngine;
using YooAsset;
using ProcedureOwner = TEngine.IFsm<TEngine.IProcedureManager>;

namespace GameMain
{
    /// <summary>
    /// 预加载流程
    /// </summary>
    public class ProcedurePreload : ProcedureBase
    {
        private float _progress = 0f;

        private readonly Dictionary<string, bool> _loadedFlag = new Dictionary<string, bool>();

        public override bool UseNativeDialog => true;

        private readonly bool _needProLoadConfig = true;

        private bool _hadInitConfigXml = false;

        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);

            _loadedFlag.Clear();

            if (GameModule.Resource.PlayMode == EPlayMode.EditorSimulateMode)
            {
                _hadInitConfigXml = true;
            }

            UILoadMgr.Show(UIDefine.UILoadUpdate, Utility.Text.Format(LoadText.Instance.Label_Load_Load_Progress, 0));

            GameEvent.Send("UILoadUpdate.RefreshVersion");

            PreloadResources().Forget();
        }

        protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);

            var totalCount = _loadedFlag.Count <= 0 ? 1 : _loadedFlag.Count;

            var loadCount = _loadedFlag.Count <= 0 ? 1 : 0;

            foreach (KeyValuePair<string, bool> loadedFlag in _loadedFlag)
            {
                if (!loadedFlag.Value)
                {
                    break;
                }
                else
                {
                    loadCount++;
                }
            }

            if (_loadedFlag.Count != 0)
            {
                UILoadMgr.Show(UIDefine.UILoadUpdate, Utility.Text.Format(LoadText.Instance.Label_Load_Load_Progress, (float)loadCount / totalCount * 100));
            }
            else
            {
                LoadUpdateLogic.Instance.DownProgressAction?.Invoke(_progress);

                string progressStr = $"{_progress * 100:f1}";

                if (Math.Abs(_progress - 1f) < 0.001f)
                {
                    UILoadMgr.Show(UIDefine.UILoadUpdate, LoadText.Instance.Label_Load_Load_Complete);
                }
                else
                {
                    UILoadMgr.Show(UIDefine.UILoadUpdate, Utility.Text.Format(LoadText.Instance.Label_Load_Load_Progress, progressStr));
                }
            }

            if (loadCount < totalCount)
            {
                return;
            }

            if (_hadInitConfigXml == false)
            {
                return;
            }

            ChangeState<ProcedureLoadAssembly>(procedureOwner);
        }


        public IEnumerator SmoothValue(float value, float duration, Action callback = null)
        {
            float time = 0f;
            while (time < duration)
            {
                time += GameTime.deltaTime;
                var result = Mathf.Lerp(0, value, time / duration);
                _progress = result;
                yield return new WaitForEndOfFrame();
            }
            _progress = value;
            callback?.Invoke();
        }

        private async UniTaskVoid PreloadResources()
        {
            await SmoothValue(1f, 1.2f).ToUniTask(GameModule.Procedure);

            await UniTask.Delay(TimeSpan.FromSeconds(2.5f));

            if (_needProLoadConfig)
            {
                LoadAllConfig();
            }
            else
            {
                _hadInitConfigXml = true;
            }
        }

        private void LoadAllConfig()
        {
            if (GameModule.Resource.PlayMode == EPlayMode.EditorSimulateMode)
            {
                _hadInitConfigXml = true;
                return;
            }
            AssetInfo[] assetInfos = GameModule.Resource.GetAssetInfos("PRELOAD");
            foreach (var assetInfo in assetInfos)
            {
                LoadConfig(assetInfo.Address);
            }
            AssetInfo[] rawAssetInfos = GameModule.Resource.GetAssetInfos("PRELOAD_RAWFILE");
            foreach (var assetInfo in rawAssetInfos)
            {
                LoadRawConfig(assetInfo.Address);
            }
#if UNITY_WEBGL
            AssetInfo[] webAssetInfos = GameModule.Resource.GetAssetInfos("WEBGL_PRELOAD");
            foreach (var assetInfo in webAssetInfos)
            {
                LoadConfig(assetInfo.Address);
            }
#endif
            _hadInitConfigXml = true;
        }

        private void LoadConfig(string configName)
        {
            _loadedFlag.Add(configName, false);
            GameModule.Resource.LoadAssetAsync<TextAsset>(configName, OnLoadSuccess);
        }

        private void LoadRawConfig(string configName)
        {
            _loadedFlag.Add(configName, false);
            GameModule.Resource.LoadRawAssetAsync(configName, OnRawConfigLoadSuccess);
        }

        private void OnLoadSuccess(AssetOperationHandle assetOperationHandle)
        {
            if (assetOperationHandle == null)
            {
                return;
            }
            var location = assetOperationHandle.GetAssetInfo().Address;
            _loadedFlag[location] = true;
            GameModule.Resource.PushPreLoadAsset(location, assetOperationHandle.AssetObject);
            Log.Info("Load config '{0}' OK.", location);
            assetOperationHandle.Dispose();
        }

        private void OnRawConfigLoadSuccess(RawFileOperationHandle assetOperationHandle)
        {
            if (assetOperationHandle == null)
            {
                return;
            }
            var location = assetOperationHandle.GetAssetInfo().Address;
            _loadedFlag[location] = true;
            GameModule.Resource.PushPreLoadRawAsset(location, assetOperationHandle.GetRawFileData());
            Log.Info("Load config '{0}' OK.", location);
            assetOperationHandle.Dispose();
        }
    }
}