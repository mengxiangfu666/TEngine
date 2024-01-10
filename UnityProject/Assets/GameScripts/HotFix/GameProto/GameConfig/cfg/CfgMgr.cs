namespace cfg
{

public sealed class CfgMgr
{
    public static string Dir { get; set; } = "config";

    public static volatile CfgMgr Ins;

        private Perfect.Marshal.Octets CreateOctets(string file)
        {
            byte[] bytes = TEngine.GameModule.Resource.GetPreLoadRawAsset(file);
            if (bytes == null)
            {
                bytes = TEngine.GameModule.Resource.LoadRawAsset(file);
            }
            return new Perfect.Marshal.Octets(bytes);
        }

    private System.Collections.Generic.Dictionary<string,cfg.global.GlobalCfg> globalcfgMap;
    public cfg.global.GlobalCfg GetGlobalCfg(string key) { return globalcfgMap.TryGetValue(key, out var v) ? v : null; }
    public System.Collections.Generic.Dictionary<string,cfg.global.GlobalCfg> GetGlobalCfgMap() { return globalcfgMap; }
    private System.Collections.Generic.List<cfg.global.GlobalCfg> globalcfgList;
    public System.Collections.Generic.List<cfg.global.GlobalCfg> GetGlobalCfgList() { return globalcfgList; }
     

    private CfgMgr() {
        globalcfgList = cfg.Extensions.unmarshal_list_cfg_global_GlobalCfg(CreateOctets("globalcfg.data"));
        globalcfgMap = new System.Collections.Generic.Dictionary<string,cfg.global.GlobalCfg>();foreach(var v in globalcfgList) { globalcfgMap.Add(v.Id, v); } 

        Resolve();
    }

    public static void Load() {
        Ins = new CfgMgr();
    }

    private void Resolve() {
        cfg.Extensions.resolve_list_cfg_global_GlobalCfg(this,globalcfgList); 

    }
}
}
