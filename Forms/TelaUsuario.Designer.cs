namespace pitaya_crud.Forms
{
    partial class TelaUsuario
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            emailText = new TextBox();
            label2 = new Label();
            label3 = new Label();
            senhaText = new TextBox();
            registrarButton = new Button();
            limparButton = new Button();
            deletarButton = new Button();
            alterarButton = new Button();
            label4 = new Label();
            senhaExistenteText = new TextBox();
            label5 = new Label();
            emailExistenteText = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSalmon;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 457);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(559, 121);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 1;
            label1.Text = "Registrar";
            // 
            // emailText
            // 
            emailText.Location = new Point(549, 177);
            emailText.Name = "emailText";
            emailText.Size = new Size(167, 23);
            emailText.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(489, 180);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(489, 221);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Senha";
            // 
            // senhaText
            // 
            senhaText.Location = new Point(549, 218);
            senhaText.Name = "senhaText";
            senhaText.Size = new Size(167, 23);
            senhaText.TabIndex = 4;
            // 
            // registrarButton
            // 
            registrarButton.BackColor = Color.LightSkyBlue;
            registrarButton.Location = new Point(513, 260);
            registrarButton.Name = "registrarButton";
            registrarButton.Size = new Size(75, 23);
            registrarButton.TabIndex = 6;
            registrarButton.Text = "Cadastrar";
            registrarButton.UseVisualStyleBackColor = false;
            registrarButton.Click += registrarButton_Click;
            // 
            // limparButton
            // 
            limparButton.BackColor = Color.IndianRed;
            limparButton.Location = new Point(614, 260);
            limparButton.Name = "limparButton";
            limparButton.Size = new Size(75, 23);
            limparButton.TabIndex = 7;
            limparButton.Text = "Limpar";
            limparButton.UseVisualStyleBackColor = false;
            limparButton.Click += limparButton_Click;
            // 
            // deletarButton
            // 
            deletarButton.BackColor = Color.IndianRed;
            deletarButton.Location = new Point(200, 260);
            deletarButton.Name = "deletarButton";
            deletarButton.Size = new Size(75, 23);
            deletarButton.TabIndex = 14;
            deletarButton.Text = "Deletar";
            deletarButton.UseVisualStyleBackColor = false;
            deletarButton.Click += deletarButton_Click;
            // 
            // alterarButton
            // 
            alterarButton.BackColor = Color.LightSkyBlue;
            alterarButton.Location = new Point(103, 260);
            alterarButton.Name = "alterarButton";
            alterarButton.Size = new Size(75, 23);
            alterarButton.TabIndex = 13;
            alterarButton.Text = "Alterar";
            alterarButton.UseVisualStyleBackColor = false;
            alterarButton.Click += alterarButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSalmon;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(76, 216);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 12;
            label4.Text = "Senha";
            // 
            // senhaExistenteText
            // 
            senhaExistenteText.Location = new Point(139, 213);
            senhaExistenteText.Name = "senhaExistenteText";
            senhaExistenteText.Size = new Size(167, 23);
            senhaExistenteText.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightSalmon;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(79, 180);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 10;
            label5.Text = "Email";
            // 
            // emailExistenteText
            // 
            emailExistenteText.Location = new Point(139, 177);
            emailExistenteText.Name = "emailExistenteText";
            emailExistenteText.Size = new Size(167, 23);
            emailExistenteText.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightSalmon;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(103, 121);
            label6.Name = "label6";
            label6.Size = new Size(162, 25);
            label6.TabIndex = 8;
            label6.Text = "Alterar ou Deletar";
            // 
            // TelaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deletarButton);
            Controls.Add(alterarButton);
            Controls.Add(label4);
            Controls.Add(senhaExistenteText);
            Controls.Add(label5);
            Controls.Add(emailExistenteText);
            Controls.Add(label6);
            Controls.Add(limparButton);
            Controls.Add(registrarButton);
            Controls.Add(label3);
            Controls.Add(senhaText);
            Controls.Add(label2);
            Controls.Add(emailText);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "TelaUsuario";
            Text = "TelaUsuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox emailText;
        private Label label2;
        private Label label3;
        private TextBox senhaText;
        private Button registrarButton;
        private Button limparButton;
        private Button deletarButton;
        private Button alterarButton;
        private Label label4;
        private TextBox senhaExistenteText;
        private Label label5;
        private TextBox emailExistenteText;
        private Label label6;
    }
}