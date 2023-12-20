using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.global
{
[System.Serializable]
public  class ListStringValue : GlobalValue
 {

    public System.Collections.Generic.List<string> Value  = new System.Collections.Generic.List<string>();
     



    public const int TYPE_ID = 17479;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public ListStringValue(Perfect.Marshal.Octets os) : base(os)  {

        Value = cfg.Extensions.unmarshal_list_string(os); 
         
    }

    public ListStringValue()
    {
    }

    public ListStringValue(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "Value":  Value = cfg.Extensions.xml_unmarshal_list_string(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "ListStringValue");
        ele.WriteStartElement("Value"); cfg.Extensions.xml_marshal_list_string(Value,ele); ele.WriteEndElement();
         
    }


}
}
}
