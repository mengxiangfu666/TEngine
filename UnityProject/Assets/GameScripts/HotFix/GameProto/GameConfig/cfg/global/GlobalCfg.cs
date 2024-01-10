namespace cfg.global
{

public sealed class GlobalCfg :   cfg.CfgObject 
 {

    public const int TYPE_ID = 19597;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public readonly string Id;
       
     public readonly string Comment;
       
     public readonly cfg.global.GlobalValue Value;
       
     

    public GlobalCfg(Perfect.Marshal.Octets os)  {
        Id = os.ReadString();
           Comment = os.ReadString();
           Value = cfg.Extensions.unmarshal_cfg_global_GlobalValue(os);
           
    }

    public  void Resolve(cfg.CfgMgr cfgMgr) {
         
          
         if(Value != null)  Value.Resolve(cfgMgr);  
         
    }
}
}
