using System.ComponentModel.DataAnnotations;
using pitaya_crud.Models;
using pitaya_crud.Services;

namespace pitaya_crud.Forms
{
    public partial class TelaCadastro : Form
    {
        private readonly ClienteService _service;
        public TelaCadastro()
        {
            InitializeComponent();
            _service = new ClienteService();
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void BotaoEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = new Cliente
                {
                    Nome = textBoxName.Text,
                    Idade = int.TryParse(textBoxIdade.Text, out int idade) ? idade : 0,
                    Telefone = textBoxTelefone.Text,
                    Sexo = comboBoxSexo.SelectedItem?.ToString() ?? "",
                    Fumante = checkBoxFumante.Checked
                };

                Cliente? novoCliente = await _service.CreateClienteAsync(cliente);

                if (novoCliente != null)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            catch (ValidationException ex)
            {
                MessageBox.Show($"Erro de validação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimparCampos()
        {
            textBoxName.Text = "";
            textBoxIdade.Text = "";
            textBoxTelefone.Text = "";
            comboBoxSexo.SelectedIndex = -1;
            checkBoxFumante.Checked = false;
        }
    }
}
