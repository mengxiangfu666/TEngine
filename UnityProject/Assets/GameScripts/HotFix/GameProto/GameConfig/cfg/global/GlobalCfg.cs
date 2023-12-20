using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.global
{
[System.Serializable]
public  class GlobalCfg :   cfg.EditorWriter 
 {

    public string Id  = "";
     public string Comment  = "";
     public cfg.global.GlobalValue Value ;
     



    public const int TYPE_ID = 19597;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public GlobalCfg(Perfect.Marshal.Octets os) {

        Id = os.ReadString(); 
         Comment = os.ReadString(); 
         Value = cfg.Extensions.unmarshal_cfg_global_GlobalValue(os); 
         
    }

    public GlobalCfg()
    {
    }

    public GlobalCfg(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "Id":  Id = ele.ReadString2(); break; 
             case "Comment":  Comment = ele.ReadString2(); break; 
             case "Value":  Value = cfg.Extensions.xml_unmarshal_cfg_global_GlobalValue(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "GlobalCfg");
        ele.WriteStartElement("Id"); ele.WriteString2(Id); ele.WriteEndElement();
         ele.WriteStartElement("Comment"); ele.WriteString2(Comment); ele.WriteEndElement();
         ele.WriteStartElement("Value"); cfg.Extensions.xml_marshal_cfg_global_GlobalValue(Value,ele); ele.WriteEndElement();
         
    }


}
}
}
