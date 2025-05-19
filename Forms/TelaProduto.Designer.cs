namespace pitaya_crud.Forms
{
    partial class TelaProduto
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
            panel2 = new Panel();
            txtNomeBusca = new TextBox();
            BuscarButton = new Button();
            SairButton = new Button();
            NovoProdutoButton = new Button();
            panel1 = new Panel();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txtNomeBusca);
            panel2.Controls.Add(BuscarButton);
            panel2.Controls.Add(SairButton);
            panel2.Controls.Add(NovoProdutoButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 44);
            panel2.TabIndex = 6;
            // 
            // txtNomeBusca
            // 
            txtNomeBusca.Location = new Point(84, 10);
            txtNomeBusca.Name = "txtNomeBusca";
            txtNomeBusca.Size = new Size(511, 23);
            txtNomeBusca.TabIndex = 9;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(601, 11);
            BuscarButton.Margin = new Padding(3, 2, 3, 2);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(70, 22);
            BuscarButton.TabIndex = 8;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // SairButton
            // 
            SairButton.BackColor = Color.Red;
            SairButton.ForeColor = SystemColors.Control;
            SairButton.Location = new Point(3, 9);
            SairButton.Name = "SairButton";
            SairButton.Padding = new Padding(1);
            SairButton.Size = new Size(75, 25);
            SairButton.TabIndex = 4;
            SairButton.Text = "Voltar";
            SairButton.UseVisualStyleBackColor = false;
            SairButton.Click += SairButton_Click;
            // 
            // NovoProdutoButton
            // 
            NovoProdutoButton.BackColor = SystemColors.Highlight;
            NovoProdutoButton.ForeColor = SystemColors.Desktop;
            NovoProdutoButton.Location = new Point(679, 7);
            NovoProdutoButton.Margin = new Padding(5);
            NovoProdutoButton.Name = "NovoProdutoButton";
            NovoProdutoButton.Padding = new Padding(1);
            NovoProdutoButton.Size = new Size(108, 28);
            NovoProdutoButton.TabIndex = 3;
            NovoProdutoButton.Text = "Novo Produto";
            NovoProdutoButton.UseVisualStyleBackColor = false;
            NovoProdutoButton.Click += NovoProdutoButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 254, 173);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 42);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            label2.ForeColor = Color.Blue;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(342, 6);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 31);
            label2.TabIndex = 4;
            label2.Text = "Produtos";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 122);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(796, 298);
            dataGridView1.TabIndex = 4;
            // 
            // TelaProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "TelaProduto";
            Text = "TelaProduto";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button BuscarButton;
        private Button SairButton;
        private Button NovoProdutoButton;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox txtNomeBusca;
    }
}