namespace pitaya_crud.Forms
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
            TextBoxLogin = new TextBox();
            TextBoxSenha = new TextBox();
            BotaoEntrar = new Button();
            PersonagemPitaya = new PictureBox();
            TituloPitaya = new Label();
            IconeEmail = new PictureBox();
            IconePassword = new PictureBox();
            FormaBackground = new PictureBox();
            Lema = new Label();
            LabelLogin = new Label();
            BotaoLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)PersonagemPitaya).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconeEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconePassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FormaBackground).BeginInit();
            SuspendLayout();
            // 
            // TextBoxLogin
            // 
            TextBoxLogin.BackColor = Color.Gainsboro;
            TextBoxLogin.BorderStyle = BorderStyle.FixedSingle;
            TextBoxLogin.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxLogin.ForeColor = Color.Black;
            TextBoxLogin.Location = new Point(572, 179);
            TextBoxLogin.Margin = new Padding(1);
            TextBoxLogin.MaxLength = 60;
            TextBoxLogin.Name = "TextBoxLogin";
            TextBoxLogin.Size = new Size(163, 25);
            TextBoxLogin.TabIndex = 0;
            TextBoxLogin.TextChanged += textBox1_TextChanged;
            // 
            // TextBoxSenha
            // 
            TextBoxSenha.BackColor = Color.Gainsboro;
            TextBoxSenha.BorderStyle = BorderStyle.FixedSingle;
            TextBoxSenha.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxSenha.ForeColor = Color.Black;
            TextBoxSenha.Location = new Point(572, 240);
            TextBoxSenha.Margin = new Padding(1);
            TextBoxSenha.MaxLength = 20;
            TextBoxSenha.Name = "TextBoxSenha";
            TextBoxSenha.Size = new Size(163, 25);
            TextBoxSenha.TabIndex = 1;
            TextBoxSenha.UseSystemPasswordChar = true;
            TextBoxSenha.TextChanged += textBox2_TextChanged_1;
            // 
            // BotaoEntrar
            // 
            BotaoEntrar.BackColor = Color.Blue;
            BotaoEntrar.FlatAppearance.BorderColor = Color.FromArgb(251, 254, 173);
            BotaoEntrar.FlatAppearance.BorderSize = 0;
            BotaoEntrar.FlatStyle = FlatStyle.Popup;
            BotaoEntrar.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoEntrar.ForeColor = Color.White;
            BotaoEntrar.Location = new Point(548, 295);
            BotaoEntrar.Name = "BotaoEntrar";
            BotaoEntrar.Size = new Size(106, 36);
            BotaoEntrar.TabIndex = 4;
            BotaoEntrar.Text = "ENTRAR";
            BotaoEntrar.UseVisualStyleBackColor = false;
            BotaoEntrar.Click += button1_Click;
            // 
            // PersonagemPitaya
            // 
            PersonagemPitaya.BackgroundImageLayout = ImageLayout.Center;
            PersonagemPitaya.Image = (Image)resources.GetObject("PersonagemPitaya.Image");
            PersonagemPitaya.Location = new Point(93, 147);
            PersonagemPitaya.Name = "PersonagemPitaya";
            PersonagemPitaya.Size = new Size(271, 231);
            PersonagemPitaya.SizeMode = PictureBoxSizeMode.StretchImage;
            PersonagemPitaya.TabIndex = 5;
            PersonagemPitaya.TabStop = false;
            PersonagemPitaya.Click += pictureBox1_Click;
            // 
            // TituloPitaya
            // 
            TituloPitaya.AccessibleRole = AccessibleRole.TitleBar;
            TituloPitaya.AutoSize = true;
            TituloPitaya.BackColor = Color.FromArgb(251, 254, 173);
            TituloPitaya.Font = new Font("SF Pro Display", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TituloPitaya.ForeColor = Color.Blue;
            TituloPitaya.Location = new Point(71, 77);
            TituloPitaya.Name = "TituloPitaya";
            TituloPitaya.Size = new Size(293, 44);
            TituloPitaya.TabIndex = 6;
            TituloPitaya.Text = "Pitaya Company";
            TituloPitaya.Click += label1_Click_1;
            // 
            // IconeEmail
            // 
            IconeEmail.BackColor = Color.White;
            IconeEmail.BackgroundImageLayout = ImageLayout.Center;
            IconeEmail.Image = (Image)resources.GetObject("IconeEmail.Image");
            IconeEmail.Location = new Point(548, 179);
            IconeEmail.Name = "IconeEmail";
            IconeEmail.Size = new Size(20, 20);
            IconeEmail.SizeMode = PictureBoxSizeMode.StretchImage;
            IconeEmail.TabIndex = 8;
            IconeEmail.TabStop = false;
            // 
            // IconePassword
            // 
            IconePassword.BackColor = Color.White;
            IconePassword.BackgroundImageLayout = ImageLayout.Center;
            IconePassword.Image = (Image)resources.GetObject("IconePassword.Image");
            IconePassword.Location = new Point(548, 240);
            IconePassword.Name = "IconePassword";
            IconePassword.Size = new Size(20, 21);
            IconePassword.SizeMode = PictureBoxSizeMode.StretchImage;
            IconePassword.TabIndex = 9;
            IconePassword.TabStop = false;
            // 
            // FormaBackground
            // 
            FormaBackground.BackgroundImageLayout = ImageLayout.Center;
            FormaBackground.Image = (Image)resources.GetObject("FormaBackground.Image");
            FormaBackground.Location = new Point(0, -3);
            FormaBackground.Name = "FormaBackground";
            FormaBackground.Size = new Size(455, 452);
            FormaBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            FormaBackground.TabIndex = 10;
            FormaBackground.TabStop = false;
            FormaBackground.Click += FormaBackground_Click;
            // 
            // Lema
            // 
            Lema.AccessibleRole = AccessibleRole.TitleBar;
            Lema.AutoSize = true;
            Lema.BackColor = Color.FromArgb(251, 254, 173);
            Lema.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lema.ForeColor = Color.Black;
            Lema.Location = new Point(146, 121);
            Lema.Name = "Lema";
            Lema.Size = new Size(252, 23);
            Lema.TabIndex = 11;
            Lema.Text = "Organize, Gerencie, Cresça.";
            Lema.Click += lema_Click;
            // 
            // LabelLogin
            // 
            LabelLogin.AccessibleRole = AccessibleRole.TitleBar;
            LabelLogin.AutoSize = true;
            LabelLogin.BackColor = Color.White;
            LabelLogin.Font = new Font("SF Pro Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelLogin.ForeColor = Color.Blue;
            LabelLogin.Location = new Point(596, 131);
            LabelLogin.Name = "LabelLogin";
            LabelLogin.Size = new Size(82, 32);
            LabelLogin.TabIndex = 12;
            LabelLogin.Text = "Login";
            // 
            // BotaoLimpar
            // 
            BotaoLimpar.BackColor = Color.Red;
            BotaoLimpar.FlatAppearance.BorderColor = Color.FromArgb(251, 254, 173);
            BotaoLimpar.FlatAppearance.BorderSize = 0;
            BotaoLimpar.FlatStyle = FlatStyle.Popup;
            BotaoLimpar.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotaoLimpar.ForeColor = Color.Black;
            BotaoLimpar.Location = new Point(660, 295);
            BotaoLimpar.Name = "BotaoLimpar";
            BotaoLimpar.Size = new Size(75, 36);
            BotaoLimpar.TabIndex = 13;
            BotaoLimpar.Text = "LIMPAR";
            BotaoLimpar.UseVisualStyleBackColor = false;
            BotaoLimpar.Click += button1_Click_1;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(BotaoLimpar);
            Controls.Add(LabelLogin);
            Controls.Add(Lema);
            Controls.Add(IconePassword);
            Controls.Add(IconeEmail);
            Controls.Add(TituloPitaya);
            Controls.Add(BotaoEntrar);
            Controls.Add(TextBoxSenha);
            Controls.Add(TextBoxLogin);
            Controls.Add(PersonagemPitaya);
            Controls.Add(FormaBackground);
            Font = new Font("SF Pro Display", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Pitaya Client";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PersonagemPitaya).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconeEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconePassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)FormaBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox TextBoxSenha;
        private System.Windows.Forms.Button BotaoEntrar;
        private System.Windows.Forms.PictureBox PersonagemPitaya;
        private System.Windows.Forms.Label TituloPitaya;
        private System.Windows.Forms.PictureBox IconeEmail;
        private System.Windows.Forms.PictureBox IconePassword;
        private System.Windows.Forms.PictureBox FormaBackground;
        private System.Windows.Forms.Label Lema;
        private System.Windows.Forms.Label LabelLogin;
        private Button BotaoLimpar;
    }
}

