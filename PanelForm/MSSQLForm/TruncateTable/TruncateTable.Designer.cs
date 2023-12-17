namespace DBManager.PanelForm.MSSQLForm.TruncateTable
{
    partial class TruncateTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TruncateTable));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.cbTables = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.bTruncateOneTable = new MaterialSkin.Controls.MaterialButton();
            this.bTruncateAll = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(392, 3);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(53, 19);
            this.materialLabel1.TabIndex = 5;
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
            this.materialCard1.TabIndex = 4;
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
            // bTruncateOneTable
            // 
            this.bTruncateOneTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bTruncateOneTable.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bTruncateOneTable.Depth = 0;
            this.bTruncateOneTable.HighEmphasis = true;
            this.bTruncateOneTable.Icon = null;
            this.bTruncateOneTable.Location = new System.Drawing.Point(246, 323);
            this.bTruncateOneTable.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bTruncateOneTable.MouseState = MaterialSkin.MouseState.HOVER;
            this.bTruncateOneTable.Name = "bTruncateOneTable";
            this.bTruncateOneTable.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bTruncateOneTable.Size = new System.Drawing.Size(216, 36);
            this.bTruncateOneTable.TabIndex = 6;
            this.bTruncateOneTable.Text = "DELETAR DADOS DA TABELA";
            this.bTruncateOneTable.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bTruncateOneTable.UseAccentColor = false;
            this.bTruncateOneTable.UseVisualStyleBackColor = true;
            this.bTruncateOneTable.Click += new System.EventHandler(this.bTruncateOneTable_Click);
            // 
            // bTruncateAll
            // 
            this.bTruncateAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bTruncateAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bTruncateAll.Depth = 0;
            this.bTruncateAll.HighEmphasis = true;
            this.bTruncateAll.Icon = null;
            this.bTruncateAll.Location = new System.Drawing.Point(470, 323);
            this.bTruncateAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bTruncateAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.bTruncateAll.Name = "bTruncateAll";
            this.bTruncateAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bTruncateAll.Size = new System.Drawing.Size(297, 36);
            this.bTruncateAll.TabIndex = 7;
            this.bTruncateAll.Text = "DELETAR DADOS DE TODAS AS TABELAS";
            this.bTruncateAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bTruncateAll.UseAccentColor = false;
            this.bTruncateAll.UseVisualStyleBackColor = true;
            this.bTruncateAll.Click += new System.EventHandler(this.bTruncateAll_Click);
            // 
            // TruncateTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 672);
            this.Controls.Add(this.bTruncateAll);
            this.Controls.Add(this.bTruncateOneTable);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TruncateTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TruncateTable";
            this.Load += new System.EventHandler(this.TruncateTable_Load);
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCheckedListBox cbTables;
        private MaterialSkin.Controls.MaterialButton bTruncateOneTable;
        private MaterialSkin.Controls.MaterialButton bTruncateAll;
    }
}