using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.global
{
[System.Serializable]
public abstract class GlobalValue :   cfg.EditorWriter 
 {




    public const int TYPE_ID = 0;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public GlobalValue(Perfect.Marshal.Octets os) {

    }

    public GlobalValue()
    {
    }

}
}
}
