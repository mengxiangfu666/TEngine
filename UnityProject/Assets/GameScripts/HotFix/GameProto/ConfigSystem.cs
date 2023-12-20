using GameBase;
using editor.cfg;
using TEngine;
using UnityEngine;
using editor.cfg.global;

/// <summary>
/// 配置加载器。
/// </summary>
public class ConfigSystem : Singleton<ConfigSystem>
{
    private bool _init = false;

    /// <summary>
    /// 加载配置。
    /// </summary>
    public void Load()
    {
        CfgMgr.Load();
        _init = true;
    }

    public CfgMgr GetData()
    {
        return CfgMgr.Ins;
    }

    public T GetGlobalValue<T>(string _id) where T : GlobalValue
    {
        GlobalValue globalValue = GetData().GetGlobalCfg(_id).Value;
        return globalValue as T;
    }
}