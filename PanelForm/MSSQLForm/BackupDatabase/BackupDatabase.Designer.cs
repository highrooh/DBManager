namespace DBManager.PanelForm.MSSQLForm.BackupDatabase
{
    partial class BackupDatabase
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.cbTables = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.bGet = new MaterialSkin.Controls.MaterialButton();
            this.getDatabase = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.cbTables);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(36, 23);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(819, 280);
            this.materialCard1.TabIndex = 0;
            // 
            // cbTables
            // 
            this.cbTables.AutoScroll = true;
            this.cbTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTables.Depth = 0;
            this.cbTables.Location = new System.Drawing.Point(-2, 0);
            this.cbTables.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(815, 280);
            this.cbTables.Striped = false;
            this.cbTables.StripeDarkColor = System.Drawing.Color.Empty;
            this.cbTables.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(397, 1);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(53, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Tables:";
            // 
            // bGet
            // 
            this.bGet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bGet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bGet.Depth = 0;
            this.bGet.HighEmphasis = true;
            this.bGet.Icon = null;
            this.bGet.Location = new System.Drawing.Point(386, 323);
            this.bGet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bGet.MouseState = MaterialSkin.MouseState.HOVER;
            this.bGet.Name = "bGet";
            this.bGet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bGet.Size = new System.Drawing.Size(105, 36);
            this.bGet.TabIndex = 2;
            this.bGet.Text = "LER TABELA";
            this.bGet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bGet.UseAccentColor = false;
            this.bGet.UseVisualStyleBackColor = true;
            this.bGet.Click += new System.EventHandler(this.bGet_Click);
            // 
            // getDatabase
            // 
            this.getDatabase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getDatabase.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.getDatabase.Depth = 0;
            this.getDatabase.HighEmphasis = true;
            this.getDatabase.Icon = null;
            this.getDatabase.Location = new System.Drawing.Point(499, 323);
            this.getDatabase.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.getDatabase.MouseState = MaterialSkin.MouseState.HOVER;
            this.getDatabase.Name = "getDatabase";
            this.getDatabase.NoAccentTextColor = System.Drawing.Color.Empty;
            this.getDatabase.Size = new System.Drawing.Size(156, 36);
            this.getDatabase.TabIndex = 3;
            this.getDatabase.Text = "LER TODAS AS TABELAS";
            this.getDatabase.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.getDatabase.UseAccentColor = false;
            this.getDatabase.UseVisualStyleBackColor = true;
            this.getDatabase.Click += new System.EventHandler(this.getDatabase_Click);
            // 
            // BackupDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 672);
            this.Controls.Add(this.getDatabase);
            this.Controls.Add(this.bGet);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BackupDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackupDatabase";
            this.Load += new System.EventHandler(this.BackupDatabase_Load);
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCheckedListBox cbTables;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton bGet;
        private MaterialSkin.Controls.MaterialButton getDatabase;
    }
}