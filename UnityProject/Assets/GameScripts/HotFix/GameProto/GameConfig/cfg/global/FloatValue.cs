namespace cfg.global
{

public sealed class FloatValue : GlobalValue
 {

    public const int TYPE_ID = 37627;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public readonly float Value;
       
     

    public FloatValue(Perfect.Marshal.Octets os) : base(os) {
        Value = os.ReadFloat();
           
    }

    public override void Resolve(cfg.CfgMgr cfgMgr) {
        base.Resolve(cfgMgr);
         
         
    }
}
}
