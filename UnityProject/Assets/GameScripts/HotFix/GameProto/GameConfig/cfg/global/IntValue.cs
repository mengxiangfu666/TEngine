namespace cfg.global
{

public sealed class IntValue : GlobalValue
 {

    public const int TYPE_ID = 28904;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public readonly int Value;
       
     

    public IntValue(Perfect.Marshal.Octets os) : base(os) {
        Value = os.ReadInt();
           
    }

    public override void Resolve(cfg.CfgMgr cfgMgr) {
        base.Resolve(cfgMgr);
         
         
    }
}
}
