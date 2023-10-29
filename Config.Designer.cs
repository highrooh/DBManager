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
            this.cbDbType = new System.Windows.Forms.ComboBox();
            this.lDbType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textPortSQL = new System.Windows.Forms.TextBox();
            this.lPortSQL = new System.Windows.Forms.Label();
            this.textSQLServer = new System.Windows.Forms.TextBox();
            this.lSQLServer = new System.Windows.Forms.Label();
            this.textSQLPASS = new System.Windows.Forms.TextBox();
            this.lSQLPASS = new System.Windows.Forms.Label();
            this.textLoginSQL = new System.Windows.Forms.TextBox();
            this.lUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDbType
            // 
            this.cbDbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDbType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbDbType.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDbType.ForeColor = System.Drawing.Color.Black;
            this.cbDbType.FormattingEnabled = true;
            this.cbDbType.Items.AddRange(new object[] {
            "MSSQL",
            "MYSQL"});
            this.cbDbType.Location = new System.Drawing.Point(98, 425);
            this.cbDbType.Margin = new System.Windows.Forms.Padding(4);
            this.cbDbType.Name = "cbDbType";
            this.cbDbType.Size = new System.Drawing.Size(231, 22);
            this.cbDbType.TabIndex = 0;
            // 
            // lDbType
            // 
            this.lDbType.AutoSize = true;
            this.lDbType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lDbType.Font = new System.Drawing.Font("Caviar Dreams", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDbType.Location = new System.Drawing.Point(183, 403);
            this.lDbType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDbType.Name = "lDbType";
            this.lDbType.Size = new System.Drawing.Size(66, 18);
            this.lDbType.TabIndex = 1;
            this.lDbType.Text = "DB Type:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textPortSQL);
            this.panel1.Controls.Add(this.lPortSQL);
            this.panel1.Controls.Add(this.textSQLServer);
            this.panel1.Controls.Add(this.lSQLServer);
            this.panel1.Controls.Add(this.textSQLPASS);
            this.panel1.Controls.Add(this.lSQLPASS);
            this.panel1.Controls.Add(this.textLoginSQL);
            this.panel1.Controls.Add(this.lUserName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbDbType);
            this.panel1.Controls.Add(this.lDbType);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 548);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Config_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Config_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Config_MouseUp);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(98, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 71);
            this.button1.TabIndex = 13;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // textPortSQL
            // 
            this.textPortSQL.Location = new System.Drawing.Point(98, 358);
            this.textPortSQL.Margin = new System.Windows.Forms.Padding(4);
            this.textPortSQL.Name = "textPortSQL";
            this.textPortSQL.Size = new System.Drawing.Size(231, 25);
            this.textPortSQL.TabIndex = 11;
            // 
            // lPortSQL
            // 
            this.lPortSQL.AutoSize = true;
            this.lPortSQL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lPortSQL.Font = new System.Drawing.Font("Caviar Dreams", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPortSQL.Location = new System.Drawing.Point(174, 336);
            this.lPortSQL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPortSQL.Name = "lPortSQL";
            this.lPortSQL.Size = new System.Drawing.Size(71, 18);
            this.lPortSQL.TabIndex = 10;
            this.lPortSQL.Text = "Port SQL:";
            // 
            // textSQLServer
            // 
            this.textSQLServer.Location = new System.Drawing.Point(98, 171);
            this.textSQLServer.Margin = new System.Windows.Forms.Padding(4);
            this.textSQLServer.Name = "textSQLServer";
            this.textSQLServer.Size = new System.Drawing.Size(231, 25);
            this.textSQLServer.TabIndex = 9;
            // 
            // lSQLServer
            // 
            this.lSQLServer.AutoSize = true;
            this.lSQLServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lSQLServer.Font = new System.Drawing.Font("Caviar Dreams", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSQLServer.Location = new System.Drawing.Point(167, 149);
            this.lSQLServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSQLServer.Name = "lSQLServer";
            this.lSQLServer.Size = new System.Drawing.Size(87, 18);
            this.lSQLServer.TabIndex = 8;
            this.lSQLServer.Text = "Server SQL:";
            // 
            // textSQLPASS
            // 
            this.textSQLPASS.Location = new System.Drawing.Point(98, 295);
            this.textSQLPASS.Margin = new System.Windows.Forms.Padding(4);
            this.textSQLPASS.Name = "textSQLPASS";
            this.textSQLPASS.Size = new System.Drawing.Size(231, 25);
            this.textSQLPASS.TabIndex = 7;
            // 
            // lSQLPASS
            // 
            this.lSQLPASS.AutoSize = true;
            this.lSQLPASS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lSQLPASS.Font = new System.Drawing.Font("Caviar Dreams", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSQLPASS.Location = new System.Drawing.Point(174, 273);
            this.lSQLPASS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSQLPASS.Name = "lSQLPASS";
            this.lSQLPASS.Size = new System.Drawing.Size(75, 18);
            this.lSQLPASS.TabIndex = 6;
            this.lSQLPASS.Text = "Pass SQL:";
            // 
            // textLoginSQL
            // 
            this.textLoginSQL.Location = new System.Drawing.Point(98, 235);
            this.textLoginSQL.Margin = new System.Windows.Forms.Padding(4);
            this.textLoginSQL.Name = "textLoginSQL";
            this.textLoginSQL.Size = new System.Drawing.Size(231, 25);
            this.textLoginSQL.TabIndex = 5;
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lUserName.Font = new System.Drawing.Font("Caviar Dreams", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserName.Location = new System.Drawing.Point(167, 213);
            this.lUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(82, 18);
            this.lUserName.TabIndex = 4;
            this.lUserName.Text = "Login SQL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Caviar Dreams", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 0);
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
            this.label2.Location = new System.Drawing.Point(396, 0);
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

        private System.Windows.Forms.ComboBox cbDbType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lDbType;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.TextBox textLoginSQL;
        private System.Windows.Forms.TextBox textSQLPASS;
        private System.Windows.Forms.Label lSQLPASS;
        private System.Windows.Forms.TextBox textSQLServer;
        private System.Windows.Forms.Label lSQLServer;
        private System.Windows.Forms.TextBox textPortSQL;
        private System.Windows.Forms.Label lPortSQL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

