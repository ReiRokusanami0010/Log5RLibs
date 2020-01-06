using System;
using System.Runtime.InteropServices;

namespace Log5RLibs.utils {
    public class AliceInputUtil {
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
    }
}