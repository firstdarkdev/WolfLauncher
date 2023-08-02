using System;
using System.Windows.Forms;

/**
 * Author: HypherionSA
 * Launcher Splash Screen
 **/
namespace WolfLauncher
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void closeTimer_Tick(object sender, EventArgs e)
        {
            // Close splash after 5 seconds
            closeTimer.Enabled = false;
            this.Close();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            // Load player profile and instances
            MainLauncherForm.INSTANCE.loadProfile();
            MainLauncherForm.INSTANCE.loadInstances();
        }
    }
}
