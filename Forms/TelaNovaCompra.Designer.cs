namespace pitaya_crud.Forms
{
    partial class TelaNovaCompra
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
            Cadastro = new Panel();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            caixaidCliente = new TextBox();
            caixaData = new TextBox();
            caixaValorTotal = new TextBox();
            label4 = new Label();
            label5 = new Label();
            caixabuscaProduto = new TextBox();
            Salvarbutton = new Button();
            Cancelarbutton = new Button();
            Cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Cadastro
            // 
            Cadastro.BackColor = Color.FromArgb(251, 254, 173);
            Cadastro.Controls.Add(label2);
            Cadastro.Dock = DockStyle.Top;
            Cadastro.Location = new Point(0, 0);
            Cadastro.Margin = new Padding(4);
            Cadastro.Name = "Cadastro";
            Cadastro.Size = new Size(1124, 60);
            Cadastro.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            label2.ForeColor = Color.Blue;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(492, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 39);
            label2.TabIndex = 3;
            label2.Text = "Compra";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(866, 419);
            dataGridView1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 64);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 14;
            label1.Text = "Produtos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(955, 67);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 15;
            label3.Text = "Id Cliente";
            // 
            // caixaidCliente
            // 
            caixaidCliente.Location = new Point(872, 90);
            caixaidCliente.Name = "caixaidCliente";
            caixaidCliente.Size = new Size(242, 27);
            caixaidCliente.TabIndex = 16;
            // 
            // caixaData
            // 
            caixaData.Location = new Point(872, 158);
            caixaData.Name = "caixaData";
            caixaData.Size = new Size(242, 27);
            caixaData.TabIndex = 17;
            // 
            // caixaValorTotal
            // 
            caixaValorTotal.Location = new Point(872, 237);
            caixaValorTotal.Name = "caixaValorTotal";
            caixaValorTotal.Size = new Size(242, 27);
            caixaValorTotal.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(968, 129);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 19;
            label4.Text = "Data";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(952, 206);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 20;
            label5.Text = "Valor Total";
            // 
            // caixabuscaProduto
            // 
            caixabuscaProduto.Location = new Point(251, 63);
            caixabuscaProduto.Name = "caixabuscaProduto";
            caixabuscaProduto.Size = new Size(435, 27);
            caixabuscaProduto.TabIndex = 23;
            // 
            // Salvarbutton
            // 
            Salvarbutton.BackColor = Color.Blue;
            Salvarbutton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Salvarbutton.ForeColor = SystemColors.Control;
            Salvarbutton.Location = new Point(941, 373);
            Salvarbutton.Name = "Salvarbutton";
            Salvarbutton.Size = new Size(119, 40);
            Salvarbutton.TabIndex = 24;
            Salvarbutton.Text = "SALVAR";
            Salvarbutton.UseVisualStyleBackColor = false;
            // 
            // Cancelarbutton
            // 
            Cancelarbutton.BackColor = Color.Red;
            Cancelarbutton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Cancelarbutton.ForeColor = SystemColors.Control;
            Cancelarbutton.Location = new Point(941, 437);
            Cancelarbutton.Name = "Cancelarbutton";
            Cancelarbutton.Size = new Size(119, 34);
            Cancelarbutton.TabIndex = 25;
            Cancelarbutton.Text = "CANCELAR";
            Cancelarbutton.UseVisualStyleBackColor = false;
            // 
            // TelaNovaCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 515);
            Controls.Add(Cancelarbutton);
            Controls.Add(Salvarbutton);
            Controls.Add(caixabuscaProduto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(caixaValorTotal);
            Controls.Add(caixaData);
            Controls.Add(caixaidCliente);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(Cadastro);
            Name = "TelaNovaCompra";
            Text = "TelaNovaCompra";
            Cadastro.ResumeLayout(false);
            Cadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Cadastro;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label3;
        private TextBox caixaidCliente;
        private TextBox caixaData;
        private TextBox caixaValorTotal;
        private Label label4;
        private Label label5;
        private TextBox caixabuscaProduto;
        private Button Salvarbutton;
        private Button Cancelarbutton;
    }
}