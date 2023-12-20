using System.Xml;
using System;
using System.IO;
using System.Collections.Generic;
using TEngine;
using UnityEngine;

namespace editor
{
    namespace cfg
    {
        public sealed class CfgMgr
        {
            public static string BinDir { get; set; } = "config";

            public static string XmlDir { get; set; } = "csv";

            public static volatile CfgMgr Ins;

            private Perfect.Marshal.Octets CreateOctets(string file)
            {
                byte[] bytes = GameModule.Resource.GetPreLoadRawAsset(file);
                if (bytes == null)
                {
                    bytes = GameModule.Resource.LoadRawAsset(file);
                }
                return new Perfect.Marshal.Octets(bytes);
            }


            private static List<string> GetDirFileNames(string[] dirs)
            {
                List<string> dirNames = new List<string>();
                foreach (string dir in dirs)
                {
                    string[] fileNames = Directory.GetFiles(XmlDir + "/" + dir);
                    dirNames.AddRange(fileNames);
                }

                return dirNames;
            }

            private static XmlElement CreateXmlElement(string file)
            {
                var doc = new XmlDocument();
                doc.Load(file);
                return doc.DocumentElement;
            }

            private System.Collections.Generic.Dictionary<string, cfg.global.GlobalCfg> globalcfgMap;
            public cfg.global.GlobalCfg GetGlobalCfg(string key) { return globalcfgMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<string, cfg.global.GlobalCfg> GetGlobalCfgMap() { return globalcfgMap; }
            private System.Collections.Generic.List<cfg.global.GlobalCfg> globalcfgList;
            public System.Collections.Generic.List<cfg.global.GlobalCfg> GetGlobalCfgList() { return globalcfgList; }


            private CfgMgr()
            {
                globalcfgList = cfg.Extensions.unmarshal_list_cfg_global_GlobalCfg(CreateOctets("globalcfg"));
                globalcfgMap = new System.Collections.Generic.Dictionary<string, cfg.global.GlobalCfg>();
                foreach (var v in globalcfgList) { globalcfgMap.Add(v.Id, v); }



            }

            public static void Load()
            {
                Ins = new CfgMgr();
            }


        }
    }
}
