using System.Reflection;

/**
 * Author: HypherionSA
 * Constant values used throughout the launcher
 **/
namespace WolfLauncher.core
{
    public class LauncherConstants
    {
        // Branding
        public static readonly string LauncherName = "Wolf Launcher";
        public static readonly string LauncherBuild = "Alpha";
        public static readonly string Version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
    }
}
