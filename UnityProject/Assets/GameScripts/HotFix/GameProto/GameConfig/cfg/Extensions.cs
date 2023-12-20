using System.Xml;
namespace editor
{
namespace cfg
{

public static class Extensions
{

    public static cfg.global.GlobalCfg unmarshal_cfg_global_GlobalCfg(Perfect.Marshal.Octets os) {
            return new cfg.global.GlobalCfg(os);
         }
    public static cfg.global.ListIntValue unmarshal_cfg_global_ListIntValue(Perfect.Marshal.Octets os) {
            return new cfg.global.ListIntValue(os);
         }
    public static System.Collections.Generic.List<string> unmarshal_list_string(Perfect.Marshal.Octets os) {
            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
            var x = new System.Collections.Generic.List<string>(n);
            for(int i = 0 ; i < n ; i++) {
            x.Add(os.ReadString());
            }return x;
         }
    public static cfg.global.FloatValue unmarshal_cfg_global_FloatValue(Perfect.Marshal.Octets os) {
            return new cfg.global.FloatValue(os);
         }
    public static cfg.global.ListStringValue unmarshal_cfg_global_ListStringValue(Perfect.Marshal.Octets os) {
            return new cfg.global.ListStringValue(os);
         }
    public static System.Collections.Generic.List<int> unmarshal_list_int(Perfect.Marshal.Octets os) {
            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
            var x = new System.Collections.Generic.List<int>(n);
            for(int i = 0 ; i < n ; i++) {
            x.Add(os.ReadInt());
            }return x;
         }
    public static cfg.Vector2 unmarshal_cfg_Vector2(Perfect.Marshal.Octets os) {
            return new cfg.Vector2(os);
         }
    public static cfg.global.IntValue unmarshal_cfg_global_IntValue(Perfect.Marshal.Octets os) {
            return new cfg.global.IntValue(os);
         }
    public static System.Collections.Generic.List<cfg.global.GlobalCfg> unmarshal_list_cfg_global_GlobalCfg(Perfect.Marshal.Octets os) {
            var n = System.Math.Min(os.ReadSize(), os.Size + 1);
            var x = new System.Collections.Generic.List<cfg.global.GlobalCfg>(n);
            for(int i = 0 ; i < n ; i++) {
            x.Add(cfg.Extensions.unmarshal_cfg_global_GlobalCfg(os));
            }return x;
         }
    public static cfg.global.StringValue unmarshal_cfg_global_StringValue(Perfect.Marshal.Octets os) {
            return new cfg.global.StringValue(os);
         }
    public static cfg.global.GlobalValue unmarshal_cfg_global_GlobalValue(Perfect.Marshal.Octets os) {
            var id = os.ReadInt();
            cfg.global.GlobalValue x;
            switch(id) {
            case 0: return null;
            case 21674 : x = new cfg.global.StringValue(os); break;case 37627 : x = new cfg.global.FloatValue(os); break;case 28904 : x = new cfg.global.IntValue(os); break;case 45814 : x = new cfg.global.ListIntValue(os); break;case 17479 : x = new cfg.global.ListStringValue(os); break;default: throw new Perfect.Marshal.MarshalException("unknown bean id:" + id);}
            return x;
         }


      public static void xml_marshal_cfg_global_GlobalCfg(cfg.global.GlobalCfg x, XmlWriter ele) {
                x.MarshalXml(ele);
             }
      public static void xml_marshal_cfg_global_ListIntValue(cfg.global.ListIntValue x, XmlWriter ele) {
                x.MarshalXml(ele);
             }
      public static void xml_marshal_list_string(System.Collections.Generic.List<string> x, XmlWriter ele) {
                foreach(var _e in x) {
                ele.WriteStartElement("item");
                ele.WriteString2(_e);
                ele.WriteEndElement();
                }
             }
      public static void xml_marshal_cfg_global_FloatValue(cfg.global.FloatValue x, XmlWriter ele) {
                x.MarshalXml(ele);
             }
      public static void xml_marshal_cfg_global_ListStringValue(cfg.global.ListStringValue x, XmlWriter ele) {
                x.MarshalXml(ele);
             }
      public static void xml_marshal_list_int(System.Collections.Generic.List<int> x, XmlWriter ele) {
                foreach(var _e in x) {
                ele.WriteStartElement("item");
                ele.WriteInt(_e);
                ele.WriteEndElement();
                }
             }
      public static void xml_marshal_cfg_Vector2(cfg.Vector2 x, XmlWriter ele) {
                x.MarshalXml(ele);
             }
      public static void xml_marshal_cfg_global_IntValue(cfg.global.IntValue x, XmlWriter ele) {
                x.MarshalXml(ele);
             }
      public static void xml_marshal_list_cfg_global_GlobalCfg(System.Collections.Generic.List<cfg.global.GlobalCfg> x, XmlWriter ele) {
                foreach(var _e in x) {
                ele.WriteStartElement("item");
                cfg.Extensions.xml_marshal_cfg_global_GlobalCfg(_e,ele);
                ele.WriteEndElement();
                }
             }
      public static void xml_marshal_cfg_global_StringValue(cfg.global.StringValue x, XmlWriter ele) {
                x.MarshalXml(ele);
             }
      public static void xml_marshal_cfg_global_GlobalValue(cfg.global.GlobalValue x, XmlWriter ele) {
                if(x == null) { ele.WriteAttributeString("type", "null"); return; }x.MarshalXml(ele);
             }

      public static cfg.global.GlobalCfg xml_unmarshal_cfg_global_GlobalCfg(XmlElement ele) {
                var x = new cfg.global.GlobalCfg(ele);
                return x;
             }
      public static cfg.global.ListIntValue xml_unmarshal_cfg_global_ListIntValue(XmlElement ele) {
                var x = new cfg.global.ListIntValue(ele);
                return x;
             }
      public static System.Collections.Generic.List<string> xml_unmarshal_list_string(XmlElement ele) {
                var x = new System.Collections.Generic.List<string>();
                foreach(var c in ele.GetChildren()) {
                x.Add(c.ReadString2());
                }return x;
             }
      public static cfg.global.FloatValue xml_unmarshal_cfg_global_FloatValue(XmlElement ele) {
                var x = new cfg.global.FloatValue(ele);
                return x;
             }
      public static cfg.global.ListStringValue xml_unmarshal_cfg_global_ListStringValue(XmlElement ele) {
                var x = new cfg.global.ListStringValue(ele);
                return x;
             }
      public static System.Collections.Generic.List<int> xml_unmarshal_list_int(XmlElement ele) {
                var x = new System.Collections.Generic.List<int>();
                foreach(var c in ele.GetChildren()) {
                x.Add(c.ReadInt());
                }return x;
             }
      public static cfg.Vector2 xml_unmarshal_cfg_Vector2(XmlElement ele) {
                var x = new cfg.Vector2(ele);
                return x;
             }
      public static cfg.global.IntValue xml_unmarshal_cfg_global_IntValue(XmlElement ele) {
                var x = new cfg.global.IntValue(ele);
                return x;
             }
      public static System.Collections.Generic.List<cfg.global.GlobalCfg> xml_unmarshal_list_cfg_global_GlobalCfg(XmlElement ele) {
                var x = new System.Collections.Generic.List<cfg.global.GlobalCfg>();
                foreach(var c in ele.GetChildren()) {
                x.Add(cfg.Extensions.xml_unmarshal_cfg_global_GlobalCfg(c));
                }return x;
             }
      public static cfg.global.StringValue xml_unmarshal_cfg_global_StringValue(XmlElement ele) {
                var x = new cfg.global.StringValue(ele);
                return x;
             }
      public static cfg.global.GlobalValue xml_unmarshal_cfg_global_GlobalValue(XmlElement ele) {
                var type = ele.GetAttribute("type");
                cfg.global.GlobalValue x;
                switch(type) {
                case "null": return null;
                case "StringValue" : x = new cfg.global.StringValue(ele); break;
                case "FloatValue" : x = new cfg.global.FloatValue(ele); break;
                case "IntValue" : x = new cfg.global.IntValue(ele); break;
                case "ListIntValue" : x = new cfg.global.ListIntValue(ele); break;
                case "ListStringValue" : x = new cfg.global.ListStringValue(ele); break;
                default: throw new Perfect.Marshal.MarshalException("unknown bean type:" + type);}
                return x;
             }

}
}
}
