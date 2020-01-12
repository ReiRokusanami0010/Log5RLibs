using Log5RLibs.Services;

namespace Log5RLibs.Scheme {
    public class DefaultScheme {
        private static readonly string DEFAULT_SET = $"{"Log5RLibs",-15}";
        public static readonly AlCConfigScheme INFO_DEFAULT = new AlCConfigScheme(0, null, DEFAULT_SET);
        public static readonly AlCConfigScheme CAUT_DEFAULT = new AlCConfigScheme(1, null, DEFAULT_SET);
        public static readonly AlCConfigScheme WARN_DEFAULT = new AlCConfigScheme(2, null, DEFAULT_SET);
        public static readonly AlCConfigScheme ERROR_DEFAULT= new AlCConfigScheme(3, null, DEFAULT_SET);
    }
}