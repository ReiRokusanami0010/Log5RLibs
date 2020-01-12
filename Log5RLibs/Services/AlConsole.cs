using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using Log5RLibs.utils;
using static Log5RLibs.Scheme.DefaultScheme;

namespace Log5RLibs.Services {
    public class AlConsole {
        private const ConsoleColor INFORMATION = ConsoleColor.Cyan;
        private const ConsoleColor CAUTION = ConsoleColor.Yellow;
        private const ConsoleColor WARNING = ConsoleColor.Magenta;
        private const ConsoleColor ERROR = ConsoleColor.Red;

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


        public static void WriteLine([NotNull] AlCConfigScheme preset, string message) {
            Write((AlStatusEnum)preset.StatusNum, preset.StatusName, preset.ThreadName, message + "\n");
        }

        public static void WriteLine(Enum status, [Optional] string statusName, string threadName, string message) {
            Write(status, statusName, threadName, message + "\n");
        }
        
        public static void RunTestMessage() {
            AlConsole.WriteLine(INFO_DEFAULT, "<====================================================================================>");
            AlConsole.WriteLine(INFO_DEFAULT, " ++= Thank you for using Log5RLibs this time.");
            AlConsole.WriteLine(INFO_DEFAULT, " ++= Please write here if you have any problems:");
            AlConsole.WriteLine(INFO_DEFAULT, "     (https://github.com/ReiRokusanami0010/Log5RLibs/issues)");
            AlConsole.WriteLine(INFO_DEFAULT, " ++= This library conforms to R2MAliceUtilsLicense.");
            AlConsole.WriteLine(INFO_DEFAULT, " ++= About R2MAliceUtilsLicense:");
            AlConsole.WriteLine(INFO_DEFAULT, "     https://github.com/ReiRokusanami0010/Log5RLibs/blob/master/Log5RLibs/Lincese.txt");
            AlConsole.WriteLine(INFO_DEFAULT, " ++= Created By ReiRokusanami (Twitter: @Reirokusanami1)");
            AlConsole.WriteLine(INFO_DEFAULT, "<====================================================================================>");
        }
    }
}