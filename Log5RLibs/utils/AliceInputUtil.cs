using System;
using System.Runtime.InteropServices;

namespace Log5RLibs.utils {
    public class AliceInputUtil {
        public static string Buf;
        public static void AlConsoleInputUtil([Optional]string statusName, string defaultName, ConsoleColor color) {
            Console.Write("[ ");
            Console.ForegroundColor = color;
            if (statusName != null) {
                Console.Write(statusName);
            } else {
                Console.Write($"{defaultName, -15}");
            }
            Console.ResetColor();
            Console.Write(" ] ");
        }

        public static string ToString(Enum stat, [Optional]string statusName) {
            if (statusName != null) { Buf = statusName; }
            else {
                Buf = stat switch {
                    AlStatusEnum.Information => "Information",
                    AlStatusEnum.Caution => "Caution",
                    AlStatusEnum.Warning => "Warning",
                    AlStatusEnum.Error => "Error",
                    _ => Buf
                };
            }
            return "[ " + $"{Buf, -15}" + " ]";
        }
    }
}