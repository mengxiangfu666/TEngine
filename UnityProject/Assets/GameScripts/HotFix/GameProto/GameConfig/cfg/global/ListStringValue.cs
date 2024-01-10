namespace cfg.global
{

public sealed class ListStringValue : GlobalValue
 {

    public const int TYPE_ID = 17479;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public readonly System.Collections.Generic.List<string> Value;
       
     

    public ListStringValue(Perfect.Marshal.Octets os) : base(os) {
        Value = cfg.Extensions.unmarshal_list_string(os);
           
    }

    public override void Resolve(cfg.CfgMgr cfgMgr) {
        base.Resolve(cfgMgr);
         
         
    }
}
}
