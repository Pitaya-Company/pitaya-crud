namespace pitaya_crud.Forms
{
    partial class TelaCompra
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            radioIdCompra = new RadioButton();
            radioIdCliente = new RadioButton();
            BuscarButton = new Button();
            SairButton = new Button();
            NovaCompraButton = new Button();
            caixaPesquisa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(910, 398);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 254, 173);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 56);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(radioIdCompra);
            panel2.Controls.Add(radioIdCliente);
            panel2.Controls.Add(BuscarButton);
            panel2.Controls.Add(SairButton);
            panel2.Controls.Add(NovaCompraButton);
            panel2.Controls.Add(caixaPesquisa);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 56);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(913, 59);
            panel2.TabIndex = 3;
            // 
            // radioIdCompra
            // 
            radioIdCompra.AutoSize = true;
            radioIdCompra.Location = new Point(513, 32);
            radioIdCompra.Name = "radioIdCompra";
            radioIdCompra.Size = new Size(147, 24);
            radioIdCompra.TabIndex = 10;
            radioIdCompra.TabStop = true;
            radioIdCompra.Text = "Buscar id Compra";
            radioIdCompra.UseVisualStyleBackColor = true;
            // 
            // radioIdCliente
            // 
            radioIdCliente.AutoSize = true;
            radioIdCliente.Location = new Point(513, 3);
            radioIdCliente.Name = "radioIdCliente";
            radioIdCliente.Size = new Size(140, 24);
            radioIdCliente.TabIndex = 9;
            radioIdCliente.TabStop = true;
            radioIdCliente.Text = "Buscar id Cliente";
            radioIdCliente.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(667, 14);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(94, 29);
            BuscarButton.TabIndex = 8;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // SairButton
            // 
            SairButton.BackColor = Color.Red;
            SairButton.ForeColor = SystemColors.Control;
            SairButton.Location = new Point(3, 12);
            SairButton.Margin = new Padding(3, 4, 3, 4);
            SairButton.Name = "SairButton";
            SairButton.Padding = new Padding(1);
            SairButton.Size = new Size(86, 33);
            SairButton.TabIndex = 4;
            SairButton.Text = "Sair";
            SairButton.UseVisualStyleBackColor = false;
            SairButton.Click += SairButton_Click;
            // 
            // NovaCompraButton
            // 
            NovaCompraButton.BackColor = SystemColors.Highlight;
            NovaCompraButton.ForeColor = SystemColors.Desktop;
            NovaCompraButton.Location = new Point(776, 9);
            NovaCompraButton.Margin = new Padding(6, 7, 6, 7);
            NovaCompraButton.Name = "NovaCompraButton";
            NovaCompraButton.Padding = new Padding(1);
            NovaCompraButton.Size = new Size(123, 37);
            NovaCompraButton.TabIndex = 3;
            NovaCompraButton.Text = "Nova compra";
            NovaCompraButton.UseVisualStyleBackColor = false;
            NovaCompraButton.Click += NovaCompraButton_Click;
            // 
            // caixaPesquisa
            // 
            caixaPesquisa.Location = new Point(95, 15);
            caixaPesquisa.Margin = new Padding(3, 4, 3, 4);
            caixaPesquisa.Name = "caixaPesquisa";
            caixaPesquisa.Size = new Size(412, 27);
            caixaPesquisa.TabIndex = 2;
            // 
            // TelaCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 521);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "TelaCompra";
            Text = "TelaCompra";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private Button SairButton;
        private Button NovaCompraButton;
        private TextBox caixaPesquisa;
        private Button BuscarButton;
        private RadioButton radioIdCompra;
        private RadioButton radioIdCliente;
    }
}