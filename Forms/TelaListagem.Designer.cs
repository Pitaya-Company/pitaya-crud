
namespace pitaya_crud.Forms
{
    partial class TelaListagem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaListagem));
            panel1 = new Panel();
            panel2 = new Panel();
            SairButton = new Button();
            CadastrarButton = new Button();
            caixaDePesquisa = new TextBox();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 254, 173);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(6, 7);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(898, 56);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(SairButton);
            panel2.Controls.Add(CadastrarButton);
            panel2.Controls.Add(caixaDePesquisa);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(6, 63);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(898, 44);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // SairButton
            // 
            SairButton.BackColor = Color.Red;
            SairButton.ForeColor = SystemColors.Control;
            SairButton.Location = new Point(3, 5);
            SairButton.Margin = new Padding(3, 4, 3, 4);
            SairButton.Name = "SairButton";
            SairButton.Padding = new Padding(1);
            SairButton.Size = new Size(86, 33);
            SairButton.TabIndex = 4;
            SairButton.Text = "Sair";
            SairButton.UseVisualStyleBackColor = false;
            SairButton.Click += SairButton_Click;
            // 
            // CadastrarButton
            // 
            CadastrarButton.BackColor = SystemColors.Highlight;
            CadastrarButton.ForeColor = SystemColors.Desktop;
            CadastrarButton.Location = new Point(817, 3);
            CadastrarButton.Margin = new Padding(6, 7, 6, 7);
            CadastrarButton.Name = "CadastrarButton";
            CadastrarButton.Padding = new Padding(1);
            CadastrarButton.Size = new Size(86, 37);
            CadastrarButton.TabIndex = 3;
            CadastrarButton.Text = "Cadastrar";
            CadastrarButton.UseVisualStyleBackColor = false;
            CadastrarButton.Click += CadastrarButton_Click;
            // 
            // caixaDePesquisa
            // 
            caixaDePesquisa.Location = new Point(112, 8);
            caixaDePesquisa.Margin = new Padding(3, 4, 3, 4);
            caixaDePesquisa.Name = "caixaDePesquisa";
            caixaDePesquisa.Size = new Size(687, 27);
            caixaDePesquisa.TabIndex = 2;
            caixaDePesquisa.TextChanged += CaixaDePesquisa_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 115);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(899, 475);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TelaListagem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(910, 600);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "TelaListagem";
            Padding = new Padding(6, 7, 6, 7);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listagem de Usuários";
            Load += TelaListagem_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox caixaDePesquisa;
        private DataGridView dataGridView1;
        private Button CadastrarButton;
        private Button SairButton;
    }
}