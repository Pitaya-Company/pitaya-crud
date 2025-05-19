using pitaya_crud.Models;
using pitaya_crud.Services;

namespace pitaya_crud.Forms
{
    public partial class TelaCadastroProduto : Form
    {
        private readonly ProdutoService _service;

        public TelaCadastroProduto()
        {
            InitializeComponent();
            _service = new ProdutoService();
        }

        private async void salvarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Produto novoProduto = new Produto
                {
                    NomeProduto = nomeTextBox.Text,
                    Valor = int.TryParse(valorTextBox.Text, out var v) ? v : 0,
                    Quantidade = int.TryParse(quantidadeTextBox.Text, out var q) ? q : 0
                };

                await _service.CreateProdutoAsync(novoProduto);
                MessageBox.Show("Produto cadastrado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto: " + ex.Message);
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void codigoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}