using System;

namespace Log5RLibs.ConsoleExtension {
    public interface INeedStatusName { AlPresetBuilder SetStatusName(string statusName); }
    public sealed class AlPresetBuilder : INeedStatusName {
        internal DateTime     StdOutTime  { get; private set; } = DateTime.Now;
        internal string       StatusName  { get; private set; }
        internal ConsoleColor StatusColor { get; private set; } = ConsoleColor.Cyan;
        internal string       ThreadName  { get; private set; } = null;
        internal ConsoleColor ThreadColor { get; private set; } = ConsoleColor.Green;

        private AlPresetBuilder() { }

        public static INeedStatusName Define { get { return new AlPresetBuilder();} }

        public AlPresetBuilder SetStatusName(string statusName) {
            this.StatusName = statusName;
            return this;
        }

        public AlPresetBuilder SetStatusColor(ConsoleColor color) {
            this.StatusColor = color;
            return this;
        }

        public AlPresetBuilder SetThreadName(string threadName) {
            this.ThreadName = threadName;
            return this;
        }

        public AlPresetBuilder SetThreadColor(ConsoleColor color) {
            this.ThreadColor = color;
            return this;
        }
        
        public AlPresetBuilder SetStdOutTime(DateTime dateTime) {
            this.StdOutTime = dateTime;
            return this;
        }

        public AlPreset Build() {
            return new AlPreset(this);
        }
    }
}