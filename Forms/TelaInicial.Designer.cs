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
            button1 = new Button();
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
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Location = new Point(51, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Reiniciar ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(graficoPanel);
            Controls.Add(usuariosButton);
            Controls.Add(produtosButton);
            Controls.Add(comprasButton);
            Controls.Add(clientesButton);
            Name = "TelaInicial";
            Text = "TelaInicial";
            ResumeLayout(false);
        }

        #endregion

        private Button clientesButton;
        private Button comprasButton;
        private Button produtosButton;
        private Button usuariosButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel graficoPanel;
        private Button button1;
    }
}