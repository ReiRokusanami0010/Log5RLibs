using System;
using Log5RLibs.Services;
using Log5RLibs.utils;

namespace Log5RLibs.Main {
    public class Main {
        private static bool isCalled = false;
        public static void runMessage() {
            if (isCalled == false) {
                AlConsole.WriteLine(AlStatusEnum.Information, null, "Log5RLibs", "**************************************************************************************");
                AlConsole.WriteLine(AlStatusEnum.Information, null, "Log5RLibs", " ++= Thank you for using Log5RLibs this time.");
                AlConsole.WriteLine(AlStatusEnum.Information, null, "Log5RLibs", " ++= Please write here if you have any problems:");
                AlConsole.WriteLine(AlStatusEnum.Information, null, "Log5RLibs", "     (https://github.com/ReiRokusanami0010/Log5RLibs/issues)");
                AlConsole.WriteLine(AlStatusEnum.Information, null, "Log5RLibs", " ++= This library conforms to R2MAliceUtilsLicense.");
                AlConsole.WriteLine(AlStatusEnum.Information, null, "Log5RLibs", " ++= About R2mAliceUtilsLicense:");
                AlConsole.WriteLine(AlStatusEnum.Information, null, "Log5RLibs", "     https://github.com/ReiRokusanami0010/Log5RLibs/blob/master/Log5RLibs/License.txt");
                AlConsole.WriteLine(AlStatusEnum.Information, null, "Log5RLibs", " ++= Created By ReiRokusanami (Twitter: @Reirokusanami1)");
                AlConsole.WriteLine(AlStatusEnum.Information, null, "Log5RLibs", "**************************************************************************************");
            }
            isCalled = true;
        }
    }
}