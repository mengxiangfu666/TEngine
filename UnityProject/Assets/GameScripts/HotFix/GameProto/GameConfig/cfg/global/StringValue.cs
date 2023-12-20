using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.global
{
[System.Serializable]
public  class StringValue : GlobalValue
 {

    public string Value  = "";
     



    public const int TYPE_ID = 21674;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public StringValue(Perfect.Marshal.Octets os) : base(os)  {

        Value = os.ReadString(); 
         
    }

    public StringValue()
    {
    }

    public StringValue(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "Value":  Value = ele.ReadString2(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "StringValue");
        ele.WriteStartElement("Value"); ele.WriteString2(Value); ele.WriteEndElement();
         
    }


}
}
}
