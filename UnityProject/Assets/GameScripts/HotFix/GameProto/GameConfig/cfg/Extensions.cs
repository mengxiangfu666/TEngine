namespace cfg
{

public static class Extensions
{
        public static cfg.global.GlobalCfg unmarshal_cfg_global_GlobalCfg(Perfect.Marshal.Octets os) {
               return new cfg.global.GlobalCfg(os);
           }     public static cfg.global.ListIntValue unmarshal_cfg_global_ListIntValue(Perfect.Marshal.Octets os) {
               return new cfg.global.ListIntValue(os);
           }     public static System.Collections.Generic.List<string> unmarshal_list_string(Perfect.Marshal.Octets os) {
               var n = System.Math.Min(os.ReadSize(), os.Size + 1);
               var x = new System.Collections.Generic.List<string>(n);
               for(int i = 0 ; i < n ; i++) {
               x.Add(os.ReadString());
               }return x;
           }     public static cfg.global.FloatValue unmarshal_cfg_global_FloatValue(Perfect.Marshal.Octets os) {
               return new cfg.global.FloatValue(os);
           }     public static cfg.global.ListStringValue unmarshal_cfg_global_ListStringValue(Perfect.Marshal.Octets os) {
               return new cfg.global.ListStringValue(os);
           }     public static System.Collections.Generic.List<int> unmarshal_list_int(Perfect.Marshal.Octets os) {
               var n = System.Math.Min(os.ReadSize(), os.Size + 1);
               var x = new System.Collections.Generic.List<int>(n);
               for(int i = 0 ; i < n ; i++) {
               x.Add(os.ReadInt());
               }return x;
           }     public static cfg.Vector2 unmarshal_cfg_Vector2(Perfect.Marshal.Octets os) {
               return new cfg.Vector2(os);
           }     public static cfg.global.IntValue unmarshal_cfg_global_IntValue(Perfect.Marshal.Octets os) {
               return new cfg.global.IntValue(os);
           }     public static System.Collections.Generic.List<cfg.global.GlobalCfg> unmarshal_list_cfg_global_GlobalCfg(Perfect.Marshal.Octets os) {
               var n = System.Math.Min(os.ReadSize(), os.Size + 1);
               var x = new System.Collections.Generic.List<cfg.global.GlobalCfg>(n);
               for(int i = 0 ; i < n ; i++) {
               x.Add(cfg.Extensions.unmarshal_cfg_global_GlobalCfg(os));
               }return x;
           }     public static cfg.global.StringValue unmarshal_cfg_global_StringValue(Perfect.Marshal.Octets os) {
               return new cfg.global.StringValue(os);
           }     public static cfg.global.GlobalValue unmarshal_cfg_global_GlobalValue(Perfect.Marshal.Octets os) {
               var id = os.ReadInt();
               cfg.global.GlobalValue x;
               switch(id) {
               case 0: return null;
               case 21674 : x = new cfg.global.StringValue(os); break;case 37627 : x = new cfg.global.FloatValue(os); break;case 28904 : x = new cfg.global.IntValue(os); break;case 45814 : x = new cfg.global.ListIntValue(os); break;case 17479 : x = new cfg.global.ListStringValue(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
               return x;
           } 
     public static void resolve_cfg_global_GlobalCfg(cfg.CfgMgr cfgMgr, cfg.global.GlobalCfg v) {
                    v.Resolve(cfgMgr);

           }  public static void resolve_cfg_global_ListIntValue(cfg.CfgMgr cfgMgr, cfg.global.ListIntValue v) {
                    v.Resolve(cfgMgr);

           }   public static void resolve_cfg_global_FloatValue(cfg.CfgMgr cfgMgr, cfg.global.FloatValue v) {
                    v.Resolve(cfgMgr);

           }  public static void resolve_cfg_global_ListStringValue(cfg.CfgMgr cfgMgr, cfg.global.ListStringValue v) {
                    v.Resolve(cfgMgr);

           }   public static void resolve_cfg_Vector2(cfg.CfgMgr cfgMgr, cfg.Vector2 v) {
                    v.Resolve(cfgMgr);

           }  public static void resolve_cfg_global_IntValue(cfg.CfgMgr cfgMgr, cfg.global.IntValue v) {
                    v.Resolve(cfgMgr);

           }  public static void resolve_list_cfg_global_GlobalCfg(cfg.CfgMgr cfgMgr, System.Collections.Generic.List<cfg.global.GlobalCfg> v) {
                    foreach(var _v in v){
                    _v.Resolve(cfgMgr);
                    }
           }  public static void resolve_cfg_global_StringValue(cfg.CfgMgr cfgMgr, cfg.global.StringValue v) {
                    v.Resolve(cfgMgr);

           }  public static void resolve_cfg_global_GlobalValue(cfg.CfgMgr cfgMgr, cfg.global.GlobalValue v) {
                    v.Resolve(cfgMgr);

           } 
}
}
