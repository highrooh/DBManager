using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBManager;
using DBManager.ClassConfig;
using DBManager.MSSQLCommands;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBManager
{

    public partial class Config : Form
    {
        bool mouseClicked;
        Point clickedAt;

        
        public static string str = ".\\Config\\Config.Valkyrie";


        public Config()
        {
            InitializeComponent();
        }

        private void Config_Load(object sender, EventArgs e)
        {
           
        
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Config_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void Config_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void Config_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }


     

        public void SaveConfig()
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

                if(linex.Contains("DbType = "))
                {
                    ConfigForm.DbType = linex.Substring(9);
                }

                if (linex.Contains("Install = "))
                {
                    ConfigForm.Install = linex.Substring(10);
                }

            }


            if (System.IO.File.ReadAllLines(str)[1] == "Install = " + ConfigForm.Install)
            {
                MiscClass.Common.lineChanger("Install = " + "true", str, 2);

            }

            if (System.IO.File.ReadAllLines(str)[2] == "DbType = " + ConfigForm.DbType)
            {
                MiscClass.Common.lineChanger("DbType = " + cbDbType.SelectedIndex, str, 3);

            }

            if (System.IO.File.ReadAllLines(str)[5] == "ServerSQL = " + ClassConfig.SQLConfig.ServerSQL)
            {
                MiscClass.Common.lineChanger("ServerSQL = " + textSQLServer.Text, str, 6);

            }

            if (System.IO.File.ReadAllLines(str)[6] == "DatabaseSQL = " + ClassConfig.SQLConfig.DatabaseSQL)
            {
                MiscClass.Common.lineChanger("DatabaseSQL = " + textDatabaseSQL.Text, str, 7);

            }

            if (System.IO.File.ReadAllLines(str)[7] == "LoginSQL = " + ClassConfig.SQLConfig.LoginSQL)
            {
                MiscClass.Common.lineChanger("LoginSQL = " + textLoginSQL.Text, str, 8);

            }

            if (System.IO.File.ReadAllLines(str)[8] == "PassSQL = " + ClassConfig.SQLConfig.PassSQL)
            {
                MiscClass.Common.lineChanger("PassSQL = " + textSQLPASS.Text, str, 9);

            }

            if (System.IO.File.ReadAllLines(str)[9] == "PortSQL = " +  ClassConfig.SQLConfig.PortSQL)
            {
                MiscClass.Common.lineChanger("PortSQL = " + textPortSQL.Text, str, 10);

            }

            Program.LoadConfigs();
        }
       
        private void bNext_Click_1(object sender, EventArgs e)
        {
            SaveConfig();

            if (ConfigForm.DbType == "0")
            {
                MSSQLCommands.Connect connect = new MSSQLCommands.Connect();

                bool result = connect.TestConnection();
                if (result)
                {
                    MessageBox.Show("Connection established!");
                    this.Hide();
                    PanelForm.PanelForm panelForm = new PanelForm.PanelForm();
                    panelForm.Show();
                }
                else
                {
                    MessageBox.Show("Connection not established!");
                }
            }
        }
    }
}
