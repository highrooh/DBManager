namespace DBManager.PanelForm
{
    partial class PanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelForm));
            this.lMinimize = new System.Windows.Forms.Label();
            this.lClose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lMenuMSSQL = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateXLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lMinimize
            // 
            this.lMinimize.AutoSize = true;
            this.lMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lMinimize.Font = new System.Drawing.Font("Caviar Dreams", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMinimize.Location = new System.Drawing.Point(1159, 4);
            this.lMinimize.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lMinimize.Name = "lMinimize";
            this.lMinimize.Size = new System.Drawing.Size(18, 22);
            this.lMinimize.TabIndex = 5;
            this.lMinimize.Text = "-";
            this.lMinimize.Click += new System.EventHandler(this.lMinimize_Click);
            // 
            // lClose
            // 
            this.lClose.AutoSize = true;
            this.lClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lClose.Font = new System.Drawing.Font("Caviar Dreams", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClose.Location = new System.Drawing.Point(1193, 4);
            this.lClose.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lClose.Name = "lClose";
            this.lClose.Size = new System.Drawing.Size(21, 22);
            this.lClose.TabIndex = 4;
            this.lClose.Text = "X";
            this.lClose.Click += new System.EventHandler(this.lClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lClose);
            this.panel1.Controls.Add(this.lMinimize);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 662);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelForm_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelForm_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelForm_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 35);
            this.panel2.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Caviar Dreams", 11.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lMenuMSSQL});
            this.menuStrip1.Location = new System.Drawing.Point(1, 4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(78, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lMenuMSSQL
            // 
            this.lMenuMSSQL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupDatabaseToolStripMenuItem,
            this.getToolStripMenuItem,
            this.generateXLSToolStripMenuItem});
            this.lMenuMSSQL.Name = "lMenuMSSQL";
            this.lMenuMSSQL.Size = new System.Drawing.Size(70, 22);
            this.lMenuMSSQL.Text = "MSSQL";
            // 
            // backupDatabaseToolStripMenuItem
            // 
            this.backupDatabaseToolStripMenuItem.Name = "backupDatabaseToolStripMenuItem";
            this.backupDatabaseToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.backupDatabaseToolStripMenuItem.Text = "Backup Database";
            // 
            // getToolStripMenuItem
            // 
            this.getToolStripMenuItem.Name = "getToolStripMenuItem";
            this.getToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.getToolStripMenuItem.Text = "Truncate Database";
            // 
            // generateXLSToolStripMenuItem
            // 
            this.generateXLSToolStripMenuItem.Name = "generateXLSToolStripMenuItem";
            this.generateXLSToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.generateXLSToolStripMenuItem.Text = "Generate XLS";
            // 
            // PanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1228, 672);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Caviar Dreams", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PanelForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelForm_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lMinimize;
        private System.Windows.Forms.Label lClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lMenuMSSQL;
        private System.Windows.Forms.ToolStripMenuItem backupDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateXLSToolStripMenuItem;
    }
}