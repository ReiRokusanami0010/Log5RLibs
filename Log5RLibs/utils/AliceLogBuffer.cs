using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Log5RLibs.utils {
    public class AliceLogBuffer {
        protected static List<string> LOG_BUFFER = new List<string>();
        protected static string EXCEPTION_BUFFER;
        public static void AlBufferLogStore(string storeTarget) { LOG_BUFFER.Add(storeTarget); }
        public static void AlBufferExcpStore(Exception storeTarget) { EXCEPTION_BUFFER = storeTarget.StackTrace; }
        
        public static void ExportToXml() {
            XmlSerializer serializer = new XmlSerializer(typeof(AlLogScheme));
            using (StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + $"{DateTime.Now:MM_dd_yyyy_hh_mm_ss}.xml")) {
                
            }
        }
    }

    public class AlLogScheme {
        [XmlArrayItem(typeof(LogScheme))] 
        public ArrayList SCHEME;
    }
    
    public class LogScheme {
        public string Information;
        public List<string> LogArray;
        public string Exception;

        public LogScheme(string information, List<string> logArray, string exception) {
            this.Information = information;
            this.LogArray = logArray;
            this.Exception = exception;
        }
    }
}