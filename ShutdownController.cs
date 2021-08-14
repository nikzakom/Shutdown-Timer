using System.Diagnostics;

namespace Shutdown_Timer
{
    public static class ShutdownController
    {
        public static void ShutdownPC()
        {
            Process.Start("shutdown", "/s /f");

            //MessageBox.Show("Debug");
            //Process.Start("shutdown", "/r /f");
        }
    }
}
