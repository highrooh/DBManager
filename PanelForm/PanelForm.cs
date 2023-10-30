using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.PanelForm
{
    public partial class PanelForm : Form
    {
        bool mouseClicked;
        Point clickedAt;
        public PanelForm()
        {
            InitializeComponent();
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
    }
}
