namespace pitaya_crud.Forms
{
    partial class TelaCadastroProduto
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox nomeTextBox;
        private TextBox valorTextBox;
        private TextBox quantidadeTextBox;
        private Button salvarButton;
        private Button cancelarButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            nomeTextBox = new TextBox();
            valorTextBox = new TextBox();
            quantidadeTextBox = new TextBox();
            salvarButton = new Button();
            cancelarButton = new Button();
            label = new Label();
            label1 = new Label();
            label2 = new Label();
            Cadastro = new Panel();
            label3 = new Label();
            Cadastro.SuspendLayout();
            SuspendLayout();
            // 
            // nomeTextBox
            // 
            nomeTextBox.Location = new Point(62, 143);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.PlaceholderText = "Nome do Produto";
            nomeTextBox.Size = new Size(100, 23);
            nomeTextBox.TabIndex = 1;
            nomeTextBox.TextChanged += nomeTextBox_TextChanged;
            // 
            // valorTextBox
            // 
            valorTextBox.Location = new Point(217, 143);
            valorTextBox.Name = "valorTextBox";
            valorTextBox.PlaceholderText = "Valor";
            valorTextBox.Size = new Size(100, 23);
            valorTextBox.TabIndex = 2;
            // 
            // quantidadeTextBox
            // 
            quantidadeTextBox.Location = new Point(375, 143);
            quantidadeTextBox.Name = "quantidadeTextBox";
            quantidadeTextBox.PlaceholderText = "Quantidade";
            quantidadeTextBox.Size = new Size(100, 23);
            quantidadeTextBox.TabIndex = 3;
            // 
            // salvarButton
            // 
            salvarButton.Location = new Point(184, 256);
            salvarButton.Name = "salvarButton";
            salvarButton.Size = new Size(90, 35);
            salvarButton.TabIndex = 4;
            salvarButton.Text = "Salvar";
            salvarButton.Click += salvarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(299, 256);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(90, 35);
            cancelarButton.TabIndex = 5;
            cancelarButton.Text = "Cancelar";
            cancelarButton.Click += cancelarButton_Click;
            // 
            // label
            // 
            label.Font = new Font("SF Pro Display", 12F);
            label.ForeColor = SystemColors.ControlText;
            label.ImeMode = ImeMode.NoControl;
            label.Location = new Point(62, 117);
            label.Name = "label";
            label.Size = new Size(51, 23);
            label.TabIndex = 6;
            label.Text = "Nome";
            // 
            // label1
            // 
            label1.Font = new Font("SF Pro Display", 12F);
            label1.ForeColor = SystemColors.ControlText;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(217, 117);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 7;
            label1.Text = "Valor";
            // 
            // label2
            // 
            label2.Font = new Font("SF Pro Display", 12F);
            label2.ForeColor = SystemColors.ControlText;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(375, 117);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 8;
            label2.Text = "Quantidade";
            // 
            // Cadastro
            // 
            Cadastro.BackColor = Color.FromArgb(251, 254, 173);
            Cadastro.Controls.Add(label3);
            Cadastro.Dock = DockStyle.Top;
            Cadastro.Location = new Point(0, 0);
            Cadastro.Name = "Cadastro";
            Cadastro.Size = new Size(565, 48);
            Cadastro.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Pro Display", 20.25F, FontStyle.Bold);
            label3.ForeColor = Color.Blue;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(152, 9);
            label3.Name = "label3";
            label3.Size = new Size(268, 32);
            label3.TabIndex = 3;
            label3.Text = "Cadastro de Produto";
            label3.Click += label3_Click;
            // 
            // TelaCadastroProduto
            // 
            ClientSize = new Size(565, 369);
            Controls.Add(Cadastro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label);
            Controls.Add(nomeTextBox);
            Controls.Add(valorTextBox);
            Controls.Add(quantidadeTextBox);
            Controls.Add(salvarButton);
            Controls.Add(cancelarButton);
            Name = "TelaCadastroProduto";
            Text = "Novo Produto";
            Cadastro.ResumeLayout(false);
            Cadastro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label;
        private Label label1;
        private Label label2;
        private Panel Cadastro;
        private Label label3;
    }
}