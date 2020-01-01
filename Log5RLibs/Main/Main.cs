using System;
using Log5RLibs.Services;
using Log5RLibs.utils;

namespace Log5RLibs.Main {
    public class Main {
        public static void runMessage() {
            AlConsole.WriteLine(AliceConsoleStatusEnum.Information, null, "Log5RLibs", "******************************************************");
            AlConsole.WriteLine(AliceConsoleStatusEnum.Information, null, "Log5RLibs", " ++= Thank you");
        }
    }
}