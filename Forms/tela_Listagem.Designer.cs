namespace tela_Listagem
{
    partial class tela_Listagem
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_Listagem));
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            idade = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            fumante = new DataGridViewCheckBoxColumn();
            sexo = new DataGridViewComboBoxColumn();
            editar = new DataGridViewButtonColumn();
            deletar = new DataGridViewButtonColumn();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            caixaDePesquisa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 42);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 46, 47);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(44, 46, 47);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nome, idade, telefone, fumante, sexo, editar, deletar });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(13, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(776, 357);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nome
            // 
            nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            nome.ReadOnly = true;
            // 
            // idade
            // 
            idade.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idade.HeaderText = "Idade";
            idade.Name = "idade";
            idade.ReadOnly = true;
            idade.Width = 60;
            // 
            // telefone
            // 
            telefone.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            telefone.HeaderText = "Telefone";
            telefone.Name = "telefone";
            telefone.ReadOnly = true;
            telefone.Width = 75;
            // 
            // fumante
            // 
            fumante.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            fumante.HeaderText = "Fumante";
            fumante.Name = "fumante";
            fumante.ReadOnly = true;
            fumante.Width = 59;
            // 
            // sexo
            // 
            sexo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            sexo.HeaderText = "Sexo";
            sexo.Name = "sexo";
            sexo.ReadOnly = true;
            sexo.Width = 39;
            // 
            // editar
            // 
            editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            editar.HeaderText = "Editar";
            editar.Name = "editar";
            editar.Width = 42;
            // 
            // deletar
            // 
            deletar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            deletar.HeaderText = "Deletar";
            deletar.Name = "deletar";
            deletar.Width = 49;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(caixaDePesquisa);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 33);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Dock = DockStyle.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(765, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // caixaDePesquisa
            // 
            caixaDePesquisa.Location = new Point(13, 6);
            caixaDePesquisa.Name = "caixaDePesquisa";
            caixaDePesquisa.Size = new Size(746, 23);
            caixaDePesquisa.TabIndex = 2;
            caixaDePesquisa.TextChanged += caixaDePesquisa_TextChanged;
            // 
            // tela_Listagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "tela_Listagem";
            Text = "Listagem de Usuários";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox caixaDePesquisa;
        private PictureBox pictureBox3;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn idade;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewCheckBoxColumn fumante;
        private DataGridViewComboBoxColumn sexo;
        private DataGridViewButtonColumn editar;
        private DataGridViewButtonColumn deletar;
    }
}
