namespace pitaya_crud.Forms
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            clientesButton = new Button();
            comprasButton = new Button();
            produtosButton = new Button();
            usuariosButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            graficoPanel = new Panel();
            reiniciarButton = new Button();
            TituloPitaya = new Label();
            Lema = new Label();
            SuspendLayout();
            // 
            // clientesButton
            // 
            clientesButton.BackColor = Color.LightSkyBlue;
            clientesButton.Image = (Image)resources.GetObject("clientesButton.Image");
            clientesButton.Location = new Point(648, 231);
            clientesButton.Name = "clientesButton";
            clientesButton.Size = new Size(140, 82);
            clientesButton.TabIndex = 0;
            clientesButton.UseVisualStyleBackColor = false;
            clientesButton.Click += clientesButton_Click;
            // 
            // comprasButton
            // 
            comprasButton.BackColor = Color.IndianRed;
            comprasButton.Image = (Image)resources.GetObject("comprasButton.Image");
            comprasButton.Location = new Point(648, 12);
            comprasButton.Name = "comprasButton";
            comprasButton.Size = new Size(140, 82);
            comprasButton.TabIndex = 1;
            comprasButton.UseVisualStyleBackColor = false;
            comprasButton.Click += comprasButton_Click;
            // 
            // produtosButton
            // 
            produtosButton.BackColor = Color.LightSkyBlue;
            produtosButton.Image = (Image)resources.GetObject("produtosButton.Image");
            produtosButton.Location = new Point(648, 119);
            produtosButton.Name = "produtosButton";
            produtosButton.Size = new Size(140, 82);
            produtosButton.TabIndex = 2;
            produtosButton.UseVisualStyleBackColor = false;
            produtosButton.Click += produtosButton_Click;
            // 
            // usuariosButton
            // 
            usuariosButton.BackColor = Color.IndianRed;
            usuariosButton.Image = (Image)resources.GetObject("usuariosButton.Image");
            usuariosButton.Location = new Point(648, 336);
            usuariosButton.Name = "usuariosButton";
            usuariosButton.Size = new Size(140, 82);
            usuariosButton.TabIndex = 3;
            usuariosButton.UseVisualStyleBackColor = false;
            usuariosButton.Click += usuariosButton_Click;
            // 
            // graficoPanel
            // 
            graficoPanel.BackColor = Color.Transparent;
            graficoPanel.Location = new Point(51, 68);
            graficoPanel.Name = "graficoPanel";
            graficoPanel.Size = new Size(497, 322);
            graficoPanel.TabIndex = 4;
            // 
            // reiniciarButton
            // 
            reiniciarButton.BackColor = Color.LightSkyBlue;
            reiniciarButton.Image = (Image)resources.GetObject("reiniciarButton.Image");
            reiniciarButton.Location = new Point(512, 396);
            reiniciarButton.Name = "reiniciarButton";
            reiniciarButton.Size = new Size(36, 34);
            reiniciarButton.TabIndex = 0;
            reiniciarButton.UseVisualStyleBackColor = false;
            reiniciarButton.Click += button1_Click;
            // 
            // TituloPitaya
            // 
            TituloPitaya.AccessibleRole = AccessibleRole.TitleBar;
            TituloPitaya.AutoSize = true;
            TituloPitaya.BackColor = Color.FromArgb(251, 254, 173);
            TituloPitaya.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TituloPitaya.ForeColor = Color.Blue;
            TituloPitaya.Location = new Point(275, 9);
            TituloPitaya.Name = "TituloPitaya";
            TituloPitaya.Size = new Size(216, 42);
            TituloPitaya.TabIndex = 7;
            TituloPitaya.Text = "Bem-vindo!";
            TituloPitaya.Click += TituloPitaya_Click;
            // 
            // Lema
            // 
            Lema.AccessibleRole = AccessibleRole.TitleBar;
            Lema.AutoSize = true;
            Lema.BackColor = Color.FromArgb(251, 254, 173);
            Lema.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lema.ForeColor = Color.Black;
            Lema.Location = new Point(51, 394);
            Lema.Name = "Lema";
            Lema.Size = new Size(124, 24);
            Lema.TabIndex = 12;
            Lema.Text = "Informações";
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(Lema);
            Controls.Add(TituloPitaya);
            Controls.Add(reiniciarButton);
            Controls.Add(graficoPanel);
            Controls.Add(usuariosButton);
            Controls.Add(produtosButton);
            Controls.Add(comprasButton);
            Controls.Add(clientesButton);
            Name = "TelaInicial";
            Text = "TelaInicial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clientesButton;
        private Button comprasButton;
        private Button produtosButton;
        private Button usuariosButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel graficoPanel;
        private Button reiniciarButton;
        private Label TituloPitaya;
        private Label Lema;
    }
}