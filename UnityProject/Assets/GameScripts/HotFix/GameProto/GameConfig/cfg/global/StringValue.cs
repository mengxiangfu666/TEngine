namespace cfg.global
{

public sealed class StringValue : GlobalValue
 {

    public const int TYPE_ID = 21674;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public readonly string Value;
       
     

    public StringValue(Perfect.Marshal.Octets os) : base(os) {
        Value = os.ReadString();
           
    }

    public override void Resolve(cfg.CfgMgr cfgMgr) {
        base.Resolve(cfgMgr);
         
         
    }
}
}
