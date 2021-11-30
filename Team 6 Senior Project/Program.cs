using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_6_Senior_Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static bool runViewAll = false;
        public static string filenameViewAll = "None";
        public static bool closeProgram = false;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (!closeProgram)
            {
                Application.Run(new MainMenu());

                if (runViewAll)
                {
                    Application.Run(new TableMenu(null));
                    Console.WriteLine(filenameViewAll);
                }
            }
            
            
        }
    }
}
