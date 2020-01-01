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
            Main.Main.runMessage();
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
    }
}