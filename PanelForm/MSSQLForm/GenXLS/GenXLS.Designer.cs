namespace DBManager.PanelForm.MSSQLForm.GenXLS
{
    partial class GenXLS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenXLS));
            this.gXLSX = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.cbTables = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gXLSX
            // 
            this.gXLSX.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gXLSX.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.gXLSX.Depth = 0;
            this.gXLSX.HighEmphasis = true;
            this.gXLSX.Icon = null;
            this.gXLSX.Location = new System.Drawing.Point(386, 323);
            this.gXLSX.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gXLSX.MouseState = MaterialSkin.MouseState.HOVER;
            this.gXLSX.Name = "gXLSX";
            this.gXLSX.NoAccentTextColor = System.Drawing.Color.Empty;
            this.gXLSX.Size = new System.Drawing.Size(89, 36);
            this.gXLSX.TabIndex = 0;
            this.gXLSX.Text = "GERAR XLSX";
            this.gXLSX.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.gXLSX.UseAccentColor = false;
            this.gXLSX.UseVisualStyleBackColor = true;
            this.gXLSX.Click += new System.EventHandler(this.materialButton1_Click);
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
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Tables:";
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
            this.materialCard1.TabIndex = 2;
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
            // GenXLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 672);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.gXLSX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenXLS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenXLS";
            this.Load += new System.EventHandler(this.GenXLS_Load);
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton gXLSX;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCheckedListBox cbTables;
    }
}