using System;
using System.Runtime.InteropServices;
using Log5RLibs.utils;

namespace Log5RLibs.Services {
    public class AlConsole {
        private static readonly ConsoleColor INFORMATION = ConsoleColor.Cyan;
        private static readonly ConsoleColor CAUTION = ConsoleColor.Yellow;
        private static readonly ConsoleColor WARNING = ConsoleColor.Magenta;
        private static readonly ConsoleColor ERROR = ConsoleColor.Red;

        public static void Write(Enum status, [Optional] string statusName, string threadName, string message) {
            Console.Write($"[ {DateTime.Now:G} ] ");
            switch (status) {
                case AlStatusEnum.Information:
                    AliceInputUtil.AlConsoleInputUtil(statusName, "Information", INFORMATION);
                    break;
                case AlStatusEnum.Caution:
                    AliceInputUtil.AlConsoleInputUtil(statusName, "Caution", CAUTION);
                    break;
                case AlStatusEnum.Warning:
                    AliceInputUtil.AlConsoleInputUtil(statusName, "Warning", WARNING);
                    break;
                case AlStatusEnum.Error:
                    AliceInputUtil.AlConsoleInputUtil(statusName, "Error", ERROR);
                    break;
                default:
                    AliceInputUtil.AlConsoleInputUtil(statusName, "NoSetStatus", ConsoleColor.Gray);
                    break;
            }
            
            Console.Write($"[ {threadName} ] ");
            Console.Write(message);
        }

        public static void WriteLine(Enum status, [Optional] string statusName, string threadName, string message) {
            Write(status, statusName, threadName, message + "\n");
        }
        
        public static void RunTestMessage() {
            AlConsole.WriteLine(AlStatusEnum.Information, null, "Log5RLibs", "<====================================================================================>");
            AlConsole.WriteLine(AlStatusEnum.Information, null, "Log5RLibs", " ++= Thank you for using Log5RLibs this time.");
            AlConsole.WriteLine(AlStatusEnum.Information, null, "Log5RLibs", " ++= Please write here if you have any problems:");
            AlConsole.WriteLine(AlStatusEnum.Information, null, "Log5RLibs", "     (https://github.com/ReiRokusanami0010/Log5RLibs/issues)");
            AlConsole.WriteLine(AlStatusEnum.Information, null, "Log5RLibs", " ++= This library conforms to R2MAliceUtilsLicense.");
            AlConsole.WriteLine(AlStatusEnum.Information, null, "Log5RLibs", " ++= About R2mAliceUtilsLicense:");
            AlConsole.WriteLine(AlStatusEnum.Information, null, "Log5RLibs", "     https://github.com/ReiRokusanami0010/Log5RLibs/blob/master/Log5RLibs/Lincese.txt");
            AlConsole.WriteLine(AlStatusEnum.Information, null, "Log5RLibs", " ++= Created By ReiRokusanami (Twitter: @Reirokusanami1)");
            AlConsole.WriteLine(AlStatusEnum.Information, null, "Log5RLibs", "<====================================================================================>");
        }
    }
}