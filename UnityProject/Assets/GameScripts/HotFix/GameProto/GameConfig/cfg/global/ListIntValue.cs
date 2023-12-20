using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.global
{
[System.Serializable]
public  class ListIntValue : GlobalValue
 {

    public System.Collections.Generic.List<int> Value  = new System.Collections.Generic.List<int>();
     



    public const int TYPE_ID = 45814;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public ListIntValue(Perfect.Marshal.Octets os) : base(os)  {

        Value = cfg.Extensions.unmarshal_list_int(os); 
         
    }

    public ListIntValue()
    {
    }

    public ListIntValue(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "Value":  Value = cfg.Extensions.xml_unmarshal_list_int(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "ListIntValue");
        ele.WriteStartElement("Value"); cfg.Extensions.xml_marshal_list_int(Value,ele); ele.WriteEndElement();
         
    }


}
}
}
