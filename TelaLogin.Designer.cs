namespace PitayaCompany
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxSenha = new System.Windows.Forms.TextBox();
            this.BotãoEntrar = new System.Windows.Forms.Button();
            this.PersonagemPitaya = new System.Windows.Forms.PictureBox();
            this.TituloPitaya = new System.Windows.Forms.Label();
            this.IconeEmail = new System.Windows.Forms.PictureBox();
            this.IconePassword = new System.Windows.Forms.PictureBox();
            this.FormaBackground = new System.Windows.Forms.PictureBox();
            this.Lema = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PersonagemPitaya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconeEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormaBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.TextBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxLogin.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLogin.ForeColor = System.Drawing.Color.Black;
            this.TextBoxLogin.Location = new System.Drawing.Point(572, 179);
            this.TextBoxLogin.Margin = new System.Windows.Forms.Padding(1);
            this.TextBoxLogin.MaxLength = 60;
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(163, 25);
            this.TextBoxLogin.TabIndex = 0;
            this.TextBoxLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextBoxSenha
            // 
            this.TextBoxSenha.BackColor = System.Drawing.Color.Gainsboro;
            this.TextBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSenha.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSenha.ForeColor = System.Drawing.Color.Black;
            this.TextBoxSenha.Location = new System.Drawing.Point(572, 240);
            this.TextBoxSenha.Margin = new System.Windows.Forms.Padding(1);
            this.TextBoxSenha.MaxLength = 20;
            this.TextBoxSenha.Name = "TextBoxSenha";
            this.TextBoxSenha.Size = new System.Drawing.Size(163, 25);
            this.TextBoxSenha.TabIndex = 1;
            this.TextBoxSenha.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // BotãoEntrar
            // 
            this.BotãoEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(173)))));
            this.BotãoEntrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(173)))));
            this.BotãoEntrar.FlatAppearance.BorderSize = 0;
            this.BotãoEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotãoEntrar.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotãoEntrar.ForeColor = System.Drawing.Color.Black;
            this.BotãoEntrar.Location = new System.Drawing.Point(548, 295);
            this.BotãoEntrar.Name = "BotãoEntrar";
            this.BotãoEntrar.Size = new System.Drawing.Size(187, 36);
            this.BotãoEntrar.TabIndex = 4;
            this.BotãoEntrar.Text = "ENTRAR";
            this.BotãoEntrar.UseVisualStyleBackColor = false;
            this.BotãoEntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // PersonagemPitaya
            // 
            this.PersonagemPitaya.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PersonagemPitaya.Image = ((System.Drawing.Image)(resources.GetObject("PersonagemPitaya.Image")));
            this.PersonagemPitaya.Location = new System.Drawing.Point(93, 147);
            this.PersonagemPitaya.Name = "PersonagemPitaya";
            this.PersonagemPitaya.Size = new System.Drawing.Size(271, 231);
            this.PersonagemPitaya.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PersonagemPitaya.TabIndex = 5;
            this.PersonagemPitaya.TabStop = false;
            this.PersonagemPitaya.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TituloPitaya
            // 
            this.TituloPitaya.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.TituloPitaya.AutoSize = true;
            this.TituloPitaya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(173)))));
            this.TituloPitaya.Font = new System.Drawing.Font("SF Pro Display", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloPitaya.ForeColor = System.Drawing.Color.Blue;
            this.TituloPitaya.Location = new System.Drawing.Point(71, 77);
            this.TituloPitaya.Name = "TituloPitaya";
            this.TituloPitaya.Size = new System.Drawing.Size(293, 44);
            this.TituloPitaya.TabIndex = 6;
            this.TituloPitaya.Text = "Pitaya Company";
            this.TituloPitaya.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // IconeEmail
            // 
            this.IconeEmail.BackColor = System.Drawing.Color.White;
            this.IconeEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IconeEmail.Image = ((System.Drawing.Image)(resources.GetObject("IconeEmail.Image")));
            this.IconeEmail.Location = new System.Drawing.Point(548, 179);
            this.IconeEmail.Name = "IconeEmail";
            this.IconeEmail.Size = new System.Drawing.Size(20, 20);
            this.IconeEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconeEmail.TabIndex = 8;
            this.IconeEmail.TabStop = false;
            // 
            // IconePassword
            // 
            this.IconePassword.BackColor = System.Drawing.Color.White;
            this.IconePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IconePassword.Image = ((System.Drawing.Image)(resources.GetObject("IconePassword.Image")));
            this.IconePassword.Location = new System.Drawing.Point(548, 240);
            this.IconePassword.Name = "IconePassword";
            this.IconePassword.Size = new System.Drawing.Size(20, 21);
            this.IconePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconePassword.TabIndex = 9;
            this.IconePassword.TabStop = false;
            // 
            // FormaBackground
            // 
            this.FormaBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FormaBackground.Image = ((System.Drawing.Image)(resources.GetObject("FormaBackground.Image")));
            this.FormaBackground.Location = new System.Drawing.Point(0, -3);
            this.FormaBackground.Name = "FormaBackground";
            this.FormaBackground.Size = new System.Drawing.Size(455, 452);
            this.FormaBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FormaBackground.TabIndex = 10;
            this.FormaBackground.TabStop = false;
            // 
            // Lema
            // 
            this.Lema.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Lema.AutoSize = true;
            this.Lema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(173)))));
            this.Lema.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lema.ForeColor = System.Drawing.Color.Black;
            this.Lema.Location = new System.Drawing.Point(146, 121);
            this.Lema.Name = "Lema";
            this.Lema.Size = new System.Drawing.Size(252, 23);
            this.Lema.TabIndex = 11;
            this.Lema.Text = "Organize, Gerencie, Cresça.";
            this.Lema.Click += new System.EventHandler(this.lema_Click);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.BackColor = System.Drawing.Color.White;
            this.LabelLogin.Font = new System.Drawing.Font("SF Pro Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogin.ForeColor = System.Drawing.Color.Blue;
            this.LabelLogin.Location = new System.Drawing.Point(596, 131);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(82, 32);
            this.LabelLogin.TabIndex = 12;
            this.LabelLogin.Text = "Login";
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.Lema);
            this.Controls.Add(this.IconePassword);
            this.Controls.Add(this.IconeEmail);
            this.Controls.Add(this.TituloPitaya);
            this.Controls.Add(this.BotãoEntrar);
            this.Controls.Add(this.TextBoxSenha);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.PersonagemPitaya);
            this.Controls.Add(this.FormaBackground);
            this.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaLogin";
            this.Text = " Pitaya Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonagemPitaya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconeEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormaBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox TextBoxSenha;
        private System.Windows.Forms.Button BotãoEntrar;
        private System.Windows.Forms.PictureBox PersonagemPitaya;
        private System.Windows.Forms.Label TituloPitaya;
        private System.Windows.Forms.PictureBox IconeEmail;
        private System.Windows.Forms.PictureBox IconePassword;
        private System.Windows.Forms.PictureBox FormaBackground;
        private System.Windows.Forms.Label Lema;
        private System.Windows.Forms.Label LabelLogin;
    }
}

