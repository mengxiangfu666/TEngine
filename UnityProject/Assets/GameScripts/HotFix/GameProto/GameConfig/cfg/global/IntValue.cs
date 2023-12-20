using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.global
{
[System.Serializable]
public  class IntValue : GlobalValue
 {

    public int Value ;
     



    public const int TYPE_ID = 28904;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public IntValue(Perfect.Marshal.Octets os) : base(os)  {

        Value = os.ReadInt(); 
         
    }

    public IntValue()
    {
    }

    public IntValue(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "Value":  Value = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "IntValue");
        ele.WriteStartElement("Value"); ele.WriteInt(Value); ele.WriteEndElement();
         
    }


}
}
}
