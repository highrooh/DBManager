namespace DBManager
{
    partial class Config
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbDbType = new MaterialSkin.Controls.MaterialComboBox();
            this.textPortSQL = new MaterialSkin.Controls.MaterialTextBox();
            this.textDatabaseSQL = new MaterialSkin.Controls.MaterialTextBox();
            this.textSQLPASS = new MaterialSkin.Controls.MaterialTextBox();
            this.textLoginSQL = new MaterialSkin.Controls.MaterialTextBox();
            this.textSQLServer = new MaterialSkin.Controls.MaterialTextBox();
            this.bNext = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.cbDbType);
            this.panel1.Controls.Add(this.textPortSQL);
            this.panel1.Controls.Add(this.textDatabaseSQL);
            this.panel1.Controls.Add(this.textSQLPASS);
            this.panel1.Controls.Add(this.textLoginSQL);
            this.panel1.Controls.Add(this.textSQLServer);
            this.panel1.Controls.Add(this.bNext);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 548);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Config_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Config_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Config_MouseUp);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel1.Location = new System.Drawing.Point(23, 532);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(393, 14);
            this.materialLabel1.TabIndex = 23;
            this.materialLabel1.Text = "COPYRIGHTⓒ ValkyrieDevs Inc. TODOS OS DIREITOS RESERVADOS.            ";
            // 
            // cbDbType
            // 
            this.cbDbType.AutoResize = false;
            this.cbDbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbDbType.Depth = 0;
            this.cbDbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbDbType.DropDownHeight = 174;
            this.cbDbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDbType.DropDownWidth = 121;
            this.cbDbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbDbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbDbType.FormattingEnabled = true;
            this.cbDbType.Hint = "Db Type";
            this.cbDbType.IntegralHeight = false;
            this.cbDbType.ItemHeight = 43;
            this.cbDbType.Items.AddRange(new object[] {
            "MSSQL"});
            this.cbDbType.Location = new System.Drawing.Point(98, 405);
            this.cbDbType.MaxDropDownItems = 4;
            this.cbDbType.MouseState = MaterialSkin.MouseState.OUT;
            this.cbDbType.Name = "cbDbType";
            this.cbDbType.Size = new System.Drawing.Size(231, 49);
            this.cbDbType.StartIndex = 0;
            this.cbDbType.TabIndex = 22;
            // 
            // textPortSQL
            // 
            this.textPortSQL.AnimateReadOnly = true;
            this.textPortSQL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPortSQL.Depth = 0;
            this.textPortSQL.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textPortSQL.Hint = "Port SQL";
            this.textPortSQL.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textPortSQL.LeadingIcon = null;
            this.textPortSQL.Location = new System.Drawing.Point(98, 349);
            this.textPortSQL.MaxLength = 50;
            this.textPortSQL.MouseState = MaterialSkin.MouseState.OUT;
            this.textPortSQL.Multiline = false;
            this.textPortSQL.Name = "textPortSQL";
            this.textPortSQL.Size = new System.Drawing.Size(231, 50);
            this.textPortSQL.TabIndex = 21;
            this.textPortSQL.Text = "";
            this.textPortSQL.TrailingIcon = null;
            // 
            // textDatabaseSQL
            // 
            this.textDatabaseSQL.AnimateReadOnly = true;
            this.textDatabaseSQL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDatabaseSQL.Depth = 0;
            this.textDatabaseSQL.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textDatabaseSQL.Hint = "Db SQL";
            this.textDatabaseSQL.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textDatabaseSQL.LeadingIcon = null;
            this.textDatabaseSQL.Location = new System.Drawing.Point(98, 293);
            this.textDatabaseSQL.MaxLength = 50;
            this.textDatabaseSQL.MouseState = MaterialSkin.MouseState.OUT;
            this.textDatabaseSQL.Multiline = false;
            this.textDatabaseSQL.Name = "textDatabaseSQL";
            this.textDatabaseSQL.Size = new System.Drawing.Size(231, 50);
            this.textDatabaseSQL.TabIndex = 20;
            this.textDatabaseSQL.Text = "";
            this.textDatabaseSQL.TrailingIcon = null;
            // 
            // textSQLPASS
            // 
            this.textSQLPASS.AnimateReadOnly = true;
            this.textSQLPASS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSQLPASS.Depth = 0;
            this.textSQLPASS.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textSQLPASS.Hint = "Pass SQL";
            this.textSQLPASS.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textSQLPASS.LeadingIcon = null;
            this.textSQLPASS.Location = new System.Drawing.Point(98, 237);
            this.textSQLPASS.MaxLength = 50;
            this.textSQLPASS.MouseState = MaterialSkin.MouseState.OUT;
            this.textSQLPASS.Multiline = false;
            this.textSQLPASS.Name = "textSQLPASS";
            this.textSQLPASS.Size = new System.Drawing.Size(231, 50);
            this.textSQLPASS.TabIndex = 19;
            this.textSQLPASS.Text = "";
            this.textSQLPASS.TrailingIcon = null;
            // 
            // textLoginSQL
            // 
            this.textLoginSQL.AnimateReadOnly = true;
            this.textLoginSQL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLoginSQL.Depth = 0;
            this.textLoginSQL.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textLoginSQL.Hint = "Login SQL";
            this.textLoginSQL.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textLoginSQL.LeadingIcon = null;
            this.textLoginSQL.Location = new System.Drawing.Point(98, 181);
            this.textLoginSQL.MaxLength = 50;
            this.textLoginSQL.MouseState = MaterialSkin.MouseState.OUT;
            this.textLoginSQL.Multiline = false;
            this.textLoginSQL.Name = "textLoginSQL";
            this.textLoginSQL.Size = new System.Drawing.Size(231, 50);
            this.textLoginSQL.TabIndex = 18;
            this.textLoginSQL.Text = "";
            this.textLoginSQL.TrailingIcon = null;
            // 
            // textSQLServer
            // 
            this.textSQLServer.AnimateReadOnly = true;
            this.textSQLServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSQLServer.Depth = 0;
            this.textSQLServer.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textSQLServer.Hint = "Server SQL";
            this.textSQLServer.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textSQLServer.LeadingIcon = null;
            this.textSQLServer.Location = new System.Drawing.Point(98, 125);
            this.textSQLServer.MaxLength = 50;
            this.textSQLServer.MouseState = MaterialSkin.MouseState.OUT;
            this.textSQLServer.Multiline = false;
            this.textSQLServer.Name = "textSQLServer";
            this.textSQLServer.Size = new System.Drawing.Size(231, 50);
            this.textSQLServer.TabIndex = 17;
            this.textSQLServer.Text = "";
            this.textSQLServer.TrailingIcon = null;
            // 
            // bNext
            // 
            this.bNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bNext.Depth = 0;
            this.bNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNext.HighEmphasis = true;
            this.bNext.Icon = null;
            this.bNext.Location = new System.Drawing.Point(181, 463);
            this.bNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.bNext.Name = "bNext";
            this.bNext.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bNext.Size = new System.Drawing.Size(64, 36);
            this.bNext.TabIndex = 16;
            this.bNext.Text = "SALVAR";
            this.bNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bNext.UseAccentColor = false;
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Caviar Dreams", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "-";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Caviar Dreams", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(427, 554);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Caviar Dreams", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBManager";
            this.Load += new System.EventHandler(this.Config_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Config_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Config_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Config_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton bNext;
        private MaterialSkin.Controls.MaterialTextBox textSQLServer;
        private MaterialSkin.Controls.MaterialTextBox textSQLPASS;
        private MaterialSkin.Controls.MaterialTextBox textLoginSQL;
        private MaterialSkin.Controls.MaterialTextBox textPortSQL;
        private MaterialSkin.Controls.MaterialTextBox textDatabaseSQL;
        private MaterialSkin.Controls.MaterialComboBox cbDbType;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

