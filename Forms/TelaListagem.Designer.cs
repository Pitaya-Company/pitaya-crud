﻿
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
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 42);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(SairButton);
            panel2.Controls.Add(CadastrarButton);
            panel2.Controls.Add(caixaDePesquisa);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(5, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(790, 33);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // SairButton
            // 
            SairButton.BackColor = Color.Red;
            SairButton.ForeColor = SystemColors.Control;
            SairButton.Location = new Point(3, 4);
            SairButton.Name = "SairButton";
            SairButton.Padding = new Padding(1);
            SairButton.Size = new Size(75, 25);
            SairButton.TabIndex = 4;
            SairButton.Text = "Sair";
            SairButton.UseVisualStyleBackColor = false;
            SairButton.Click += SairButton_Click;
            // 
            // CadastrarButton
            // 
            CadastrarButton.BackColor = SystemColors.Highlight;
            CadastrarButton.ForeColor = SystemColors.Desktop;
            CadastrarButton.Location = new Point(715, 2);
            CadastrarButton.Margin = new Padding(5);
            CadastrarButton.Name = "CadastrarButton";
            CadastrarButton.Padding = new Padding(1);
            CadastrarButton.Size = new Size(75, 28);
            CadastrarButton.TabIndex = 3;
            CadastrarButton.Text = "Cadastrar";
            CadastrarButton.UseVisualStyleBackColor = false;
            CadastrarButton.Click += CadastrarButton_Click;
            // 
            // caixaDePesquisa
            // 
            caixaDePesquisa.Location = new Point(98, 6);
            caixaDePesquisa.Name = "caixaDePesquisa";
            caixaDePesquisa.Size = new Size(602, 23);
            caixaDePesquisa.TabIndex = 2;
            caixaDePesquisa.TextChanged += CaixaDePesquisa_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(787, 356);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TelaListagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TelaListagem";
            Padding = new Padding(5);
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