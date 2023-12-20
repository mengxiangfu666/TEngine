using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.global
{
[System.Serializable]
public  class FloatValue : GlobalValue
 {

    public float Value ;
     



    public const int TYPE_ID = 37627;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public FloatValue(Perfect.Marshal.Octets os) : base(os)  {

        Value = os.ReadFloat(); 
         
    }

    public FloatValue()
    {
    }

    public FloatValue(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "Value":  Value = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "FloatValue");
        ele.WriteStartElement("Value"); ele.WriteFloat(Value); ele.WriteEndElement();
         
    }


}
}
}
