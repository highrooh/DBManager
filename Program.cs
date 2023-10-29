using DBManager.ClassConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager
{
    internal static class Program
    {
      
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ClassConfig.ConfigForm config = new ClassConfig.ConfigForm();
            if(config.Install == false)
            {
             Application.Run(new Config());
            }
            else
            {
                Application.Run(new Config());
            }
        }
    }
}
