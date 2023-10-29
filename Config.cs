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
using MySql.Data.MySqlClient;

namespace DBManager
{

    public partial class Config : Form
    {
        bool mouseClicked;
        Point clickedAt;
        ClassConfig.SQLConfig configSQL = new ClassConfig.SQLConfig();


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

        private void bNext_Click(object sender, EventArgs e)
        {

        }
    }
}
