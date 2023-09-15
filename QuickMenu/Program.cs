using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsMediaController;

namespace QuickMenu
{
    internal static class Program
    {
        public static Media_Manager mediaManager;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            mediaManager = new Media_Manager();
            mediaManager.Init();
            Config.InitConfig();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QuickPanel());
        }
    }
}
