namespace pitaya_crud.Forms
{
    partial class TelaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            checkBoxFumante = new CheckBox();
            textBoxName = new TextBox();
            labelNome = new Label();
            label2 = new Label();
            labelIdade = new Label();
            textBoxIdade = new TextBox();
            comboBoxSexo = new ComboBox();
            labelTelefone = new Label();
            textBoxTelefone = new TextBox();
            labelFumante = new Label();
            labelSexo = new Label();
            Cadastro = new Panel();
            botaoSalvar = new Button();
            botaoFechar = new Button();
            Cadastro.SuspendLayout();
            SuspendLayout();
            // 
            // checkBoxFumante
            // 
            resources.ApplyResources(checkBoxFumante, "checkBoxFumante");
            checkBoxFumante.Name = "checkBoxFumante";
            checkBoxFumante.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(textBoxName, "textBoxName");
            textBoxName.Name = "textBoxName";
            textBoxName.TextChanged += textBox1_TextChanged;
            // 
            // labelNome
            // 
            resources.ApplyResources(labelNome, "labelNome");
            labelNome.ForeColor = SystemColors.ControlText;
            labelNome.Name = "labelNome";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.Blue;
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // labelIdade
            // 
            resources.ApplyResources(labelIdade, "labelIdade");
            labelIdade.Name = "labelIdade";
            // 
            // textBoxIdade
            // 
            textBoxIdade.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(textBoxIdade, "textBoxIdade");
            textBoxIdade.Name = "textBoxIdade";
            // 
            // comboBoxSexo
            // 
            resources.ApplyResources(comboBoxSexo, "comboBoxSexo");
            comboBoxSexo.FormattingEnabled = true;
            comboBoxSexo.Items.AddRange(new object[] { resources.GetString("comboBoxSexo.Items"), resources.GetString("comboBoxSexo.Items1") });
            comboBoxSexo.Name = "comboBoxSexo";
            comboBoxSexo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelTelefone
            // 
            resources.ApplyResources(labelTelefone, "labelTelefone");
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Click += label4_Click;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(textBoxTelefone, "textBoxTelefone");
            textBoxTelefone.Name = "textBoxTelefone";
            // 
            // labelFumante
            // 
            resources.ApplyResources(labelFumante, "labelFumante");
            labelFumante.Name = "labelFumante";
            // 
            // labelSexo
            // 
            resources.ApplyResources(labelSexo, "labelSexo");
            labelSexo.Name = "labelSexo";
            // 
            // Cadastro
            // 
            Cadastro.BackColor = Color.FromArgb(251, 254, 173);
            Cadastro.Controls.Add(label2);
            resources.ApplyResources(Cadastro, "Cadastro");
            Cadastro.Name = "Cadastro";
            // 
            // botaoSalvar
            // 
            botaoSalvar.BackColor = Color.Blue;
            botaoSalvar.FlatAppearance.BorderColor = Color.FromArgb(251, 254, 173);
            botaoSalvar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(botaoSalvar, "botaoSalvar");
            botaoSalvar.ForeColor = Color.White;
            botaoSalvar.Name = "botaoSalvar";
            botaoSalvar.UseVisualStyleBackColor = false;
            botaoSalvar.Click += BotaoEntrar_Click;
            // 
            // botaoFechar
            // 
            botaoFechar.BackColor = Color.Red;
            botaoFechar.FlatAppearance.BorderColor = Color.FromArgb(251, 254, 173);
            botaoFechar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(botaoFechar, "botaoFechar");
            botaoFechar.ForeColor = Color.White;
            botaoFechar.Name = "botaoFechar";
            botaoFechar.UseVisualStyleBackColor = false;
            botaoFechar.Click += botaoFechar_Click;
            // 
            // TelaCadastro
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(botaoFechar);
            Controls.Add(botaoSalvar);
            Controls.Add(Cadastro);
            Controls.Add(labelSexo);
            Controls.Add(labelFumante);
            Controls.Add(textBoxTelefone);
            Controls.Add(labelTelefone);
            Controls.Add(comboBoxSexo);
            Controls.Add(textBoxIdade);
            Controls.Add(labelIdade);
            Controls.Add(labelNome);
            Controls.Add(textBoxName);
            Controls.Add(checkBoxFumante);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "TelaCadastro";
            Load += TelaCadastro_Load;
            Cadastro.ResumeLayout(false);
            Cadastro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxFumante;
        private TextBox textBoxName;
        private Label labelNome;
        private Label label2;
        private Label labelIdade;
        private TextBox textBoxIdade;
        private ComboBox comboBoxSexo;
        private Label labelTelefone;
        private TextBox textBoxTelefone;
        private Label labelFumante;
        private Label labelSexo;
        private Panel Cadastro;
        private Button botaoSalvar;
        private Button botaoFechar;
    }
}