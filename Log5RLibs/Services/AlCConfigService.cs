using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Log5RLibs.utils;

namespace Log5RLibs.Services {
    public class AlCConfigService {
        private static readonly string Path = AppDomain.CurrentDomain.BaseDirectory + "Log5RLibs_Config";
        private static readonly string DiName = $"{"DirectoryInfo",-15}";
        private static readonly string TdName = $"{"ConfigService",-15}";
        
        public static void Flush(string presetName, AlCConfigSchemeClass presetScheme, bool isOverride) {
            AlConsole.WriteLine(AlStatusEnum.Information, 
                null, TdName, $"Log5RLibs-Flush ConfigScheme Name:{presetName}");
            XmlSerializer serializer = new XmlSerializer(typeof(AlCConfigSchemeClass));
            DirectoryInfo info = new DirectoryInfo(Path);
            if (!(info.Exists)) {
                AlConsole.WriteLine(AlStatusEnum.Caution,
                    DiName, TdName, "Config folder does not exist. Generate automatically.");
                info.Create();
            } else {
                AlConsole.WriteLine(AlStatusEnum.Information, 
                DiName, TdName, "Already Exists. (Config File)");
            }
            using (StreamWriter writer = new StreamWriter(Path + "\\" + presetName + ".xml", false)) {
                if (!File.Exists(Path + "\\" + presetName + ".xml")) { serializer.Serialize(writer, presetScheme); }
                else { AlConsole.WriteLine(AlStatusEnum.Warning, null, TdName, 
                    "A preset file with this name already exists!"); }
                if (isOverride) {
                    serializer.Serialize(writer, presetScheme);
                    AlConsole.WriteLine(AlStatusEnum.Warning, null, TdName, 
                        "preset file has been overridden.");
                }
            }
            AlConsole.WriteLine(AlStatusEnum.Information, 
                null, TdName, "Log5RLibs-Flushed ConfigScheme!");
        }
    }

    public class AlCConfigSchemeClass {
        [XmlArrayItem(typeof(AlCConfigScheme))]
        public ArrayList Config;
    }
    
    public class AlCConfigScheme {
        public int StatusNum;
        #nullable enable
        public string? StatusName;
        #nullable disable
        public string ThreadName;

        public AlCConfigScheme() {
            StatusNum = 0;
            StatusName = null;
            ThreadName = "SCHEME";
        }

        public AlCConfigScheme(int statusNum, [Optional] string statusName, string threadName) {
            StatusNum = statusNum;
            StatusName = statusName;
            ThreadName = threadName;
        }
    }
}