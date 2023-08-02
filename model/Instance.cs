
/**
 * Author: HypherionSA
 * Instance Manifest Model
 **/
namespace WolfLauncher.model
{
    public class Instance
    {

        // General Instance info like Game Version, Name, etc.
        public string name { get; set; }
        public string gameVersion { get; set; }
        public string loader { get; set; }
        public bool localInstall { get; set; }
        public Settings settings { get; set; }

        public class Settings
        {
            // Java and Screen Settings
            public int maxRam { get; set; }
            public int minRam { get; set; }
            public string screenWidth { get; set; }
            public string screenHeight { get; set; }

            public string javaPath { get; set; }
            public string javaArgs { get; set; }
        }
    }
}
