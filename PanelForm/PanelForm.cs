using LiveCharts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace DBManager.PanelForm
{
    public partial class PanelForm : Form
    {
        bool mouseClicked;
        Point clickedAt;
        public PanelForm()
        {
            InitializeComponent();
            if(ClassConfig.ConfigForm.DbType == "0")
            {
                mYSQLToolStripMenuItem.Visible = false;
            }
            else if(ClassConfig.ConfigForm.DbType== "1")
            {
                lMenuMSSQL.Visible = false;
            }

            Design();

          



        }

        private void lClose_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void lMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void PanelForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void PanelForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }


        public void Design()
        {

            CountTables.ToColor = System.Windows.Media.Color.FromRgb(142, 68, 173);
            CountTables.FromColor = System.Windows.Media.Color.FromRgb(142, 68, 173);
            CountTables.Base.Foreground = System.Windows.Media.Brushes.White;
            CountTables.InnerRadius = 0;
            CountTables.HighFontSize = 30;
            CountTables.Value = MSSQLCommands.PanelFormView.CountTables();
            CountTables.GaugeBackground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(71, 128, 181));



            dbUseDisk.ToColor = System.Windows.Media.Color.FromRgb(142, 68, 173);
            dbUseDisk.FromColor = System.Windows.Media.Color.FromRgb(142, 68, 173);
            dbUseDisk.Base.Foreground = System.Windows.Media.Brushes.White;
            dbUseDisk.InnerRadius = 0;
            dbUseDisk.HighFontSize = 30;
            dbUseDisk.Value = MSSQLCommands.PanelFormView.DiskUsage();
            dbUseDisk.GaugeBackground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(71, 128, 181));
        }

        private void backupDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.materialCard3.Controls.RemoveAt(0);
            MSSQLForm.BackupDatabase.BackupDatabase bkp = new MSSQLForm.BackupDatabase.BackupDatabase();
            bkp.TopLevel = false;
            bkp.Dock = DockStyle.Fill;
            this.materialCard3.Controls.Add(bkp);
            this.materialCard3.Tag = bkp;
            bkp.BringToFront();
            bkp.Show();
        }

        private void generateXLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.materialCard3.Controls.RemoveAt(0);
            MSSQLForm.GenXLS.GenXLS gls = new MSSQLForm.GenXLS.GenXLS();
            gls.TopLevel = false;
            gls.Dock = DockStyle.Fill;
            this.materialCard3.Controls.Add(gls);
            this.materialCard3.Tag = gls;
            gls.BringToFront();
            gls.Show();
        }

        private void getToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.materialCard3.Controls.RemoveAt(0);
            MSSQLForm.TruncateTable.TruncateTable tbt = new MSSQLForm.TruncateTable.TruncateTable();
            tbt.TopLevel = false;
            tbt.Dock = DockStyle.Fill;
            this.materialCard3.Controls.Add(tbt);
            this.materialCard3.Tag = tbt;
            tbt.BringToFront();
            tbt.Show();
        }
    }
}
