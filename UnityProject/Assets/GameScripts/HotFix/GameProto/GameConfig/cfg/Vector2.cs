namespace cfg
{

public sealed class Vector2 :   cfg.CfgObject 
 {

    public const int TYPE_ID = 59242;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public readonly float x;
       
     public readonly float y;
       
     

    public Vector2(Perfect.Marshal.Octets os)  {
        x = os.ReadFloat();
           y = os.ReadFloat();
           
    }

    public  void Resolve(cfg.CfgMgr cfgMgr) {
         
          
         
    }
}
}
