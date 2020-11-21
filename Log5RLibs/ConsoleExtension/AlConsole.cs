using System;

namespace Log5RLibs.ConsoleExtension {
    public class AlConsole {
        public static void WriteLine(AlPreset preset, string message) {
            preset.ToWrite(); Console.WriteLine(message);
        }

        public static void Write(AlPreset preset, string message) {
            preset.ToWrite(); Console.Write(message);
        }
    }
}