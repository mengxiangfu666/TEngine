namespace cfg.global
{

public sealed class ListIntValue : GlobalValue
 {

    public const int TYPE_ID = 45814;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public readonly System.Collections.Generic.List<int> Value;
       
     

    public ListIntValue(Perfect.Marshal.Octets os) : base(os) {
        Value = cfg.Extensions.unmarshal_list_int(os);
           
    }

    public override void Resolve(cfg.CfgMgr cfgMgr) {
        base.Resolve(cfgMgr);
         
         
    }
}
}
