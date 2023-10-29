using DBManager.ClassConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager
{
    internal static class Program
    {

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        /// 
        public static string str = ".\\Config\\Config.Valkyrie";
        public static void LoadConfigs()
        {
            foreach (string linex in System.IO.File.ReadLines(str))
            {
                if (linex.Contains("ServerSQL = "))
                {
                    ClassConfig.SQLConfig.ServerSQL = linex.Substring(12);
                }

                if (linex.Contains("DatabaseSQL = "))
                {
                    ClassConfig.SQLConfig.DatabaseSQL = linex.Substring(14);
                }

                if (linex.Contains("LoginSQL = "))
                {
                    ClassConfig.SQLConfig.LoginSQL = linex.Substring(11);
                }

                if (linex.Contains("PassSQL = "))
                {
                    ClassConfig.SQLConfig.PassSQL = linex.Substring(10);
                }

                if (linex.Contains("PortSQL = "))
                {
                    ClassConfig.SQLConfig.PortSQL = linex.Substring(10);
                }

                if (linex.Contains("DbType = "))
                {
                    ClassConfig.ConfigForm.DbType = linex.Substring(9);
                }

                if (linex.Contains("Install = "))
                {
                   ClassConfig.ConfigForm.Install = linex.Substring(10);
                }

            }
        }
        [STAThread]
        static void Main()
        {

           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadConfigs();
            if(ClassConfig.ConfigForm.Install == "false")
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
