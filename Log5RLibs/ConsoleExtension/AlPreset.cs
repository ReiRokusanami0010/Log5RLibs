using System;

namespace Log5RLibs.ConsoleExtension {
    public class AlPreset {
        public DateTime     StdOutTime  { get; }
        public string       StatusName  { get; }
        public ConsoleColor StatusColor { get; }
        public string       ThreadName  { get; }
        public ConsoleColor ThreadColor { get; }

        public AlPreset(AlPresetBuilder builder) {
            this.StdOutTime  = builder.StdOutTime;
            this.StatusName  = builder.StatusName;
            this.StatusColor = builder.StatusColor;
            this.ThreadName  = builder.ThreadName;
            this.ThreadColor = builder.ThreadColor;
        }

        private static readonly object lockObject = new object();
        public void ToWrite() {
            lock (lockObject) {
                Console.Write($"[ {this.StdOutTime:G} ] [ ");
                Console.ForegroundColor = this.StatusColor;
                Console.Write(this.StatusName);
                Console.ResetColor();
                Console.Write(" ] ");
                if (!(this.ThreadName.Equals("") || this.Equals(null))) {
                    Console.Write("[ ");
                    Console.ForegroundColor = this.ThreadColor;
                    Console.Write(this.ThreadName);
                    Console.ResetColor();
                    Console.Write(" ] ");
                }
            }
        }

        public override string ToString() {
            return $"[{this.StdOutTime:G}] [ {this.StatusName.Substring(0,4)} ]" 
                   + (!(this.ThreadName.Equals("") || this.ThreadName.Equals(null)) ? $" [ {this.ThreadName} ]" : " ");
        }
    }
}