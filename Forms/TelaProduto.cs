using pitaya_crud.Models;
using pitaya_crud.Services;
using System.Data;

namespace pitaya_crud.Forms
{
    public partial class TelaProduto : Form
    {
        private List<Produto> _produtos = new();
        private readonly ProdutoService _service;

        private string _ordenadoPor = "";
        private bool _crescente = true;
        private string _filtroNome = "";

        public TelaProduto()
        {
            InitializeComponent();
            _service = new ProdutoService();

            this.Load += TelaProduto_Load;
            dataGridView1.ColumnHeaderMouseClick += DataGridView1_ColumnHeaderMouseClick;
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
        }

        private async void TelaProduto_Load(object? sender, EventArgs e)
        {
            await AtualizarDataGrid();
        }

        private async Task AtualizarDataGrid()
        {
            _produtos = await _service.GetProdutosAsync(
                orderBy: string.IsNullOrWhiteSpace(_ordenadoPor) ? null : _ordenadoPor,
                nome: string.IsNullOrWhiteSpace(_filtroNome) ? null : _filtroNome
            );

            if (!_crescente)
                _produtos.Reverse();

            dataGridView1.SuspendLayout();
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _produtos;

            dataGridView1.Columns["CodigoProduto"].HeaderText = "Código";
            dataGridView1.Columns["NomeProduto"].HeaderText = "Nome";
            dataGridView1.Columns["Valor"].DefaultCellStyle.Format = "C2";

            // Permite edição apenas em algumas colunas
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.ReadOnly = !(col.Name == "NomeProduto" || col.Name == "Valor" || col.Name == "Quantidade");
            }

            DefinirColunasAcao();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ResumeLayout();
        }

        private void DefinirColunasAcao()
        {
            if (!dataGridView1.Columns.Contains("Excluir"))
            {
                var colunaExcluir = new DataGridViewButtonColumn
                {
                    Name = "Excluir",
                    HeaderText = "Ações",
                    Text = "Excluir",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(colunaExcluir);
            }
        }

        private async void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string coluna = dataGridView1.Columns[e.ColumnIndex].Name;

            if (coluna == "Excluir")
            {
                var confirmacao = MessageBox.Show("Deseja excluir este produto?",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacao == DialogResult.Yes)
                {
                    await _service.DeleteProdutoAsync(_produtos[e.RowIndex].CodigoProduto);
                    _produtos.RemoveAt(e.RowIndex);
                    await AtualizarDataGrid();
                    MessageBox.Show("Produto excluído com sucesso.");
                }
            }
        }

        private async void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var linha = dataGridView1.Rows[e.RowIndex];
            if (linha.DataBoundItem is Produto produtoEditado)
            {
                try
                {
                    await _service.UpdateProdutoAsync(produtoEditado);
                    MessageBox.Show("Produto atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar produto: {ex.Message}");
                }
            }
        }

        private async void BuscarButton_Click(object sender, EventArgs e)
        {
            _filtroNome = txtNomeBusca.Text;
            await AtualizarDataGrid();
        }

        private async void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var coluna = dataGridView1.Columns[e.ColumnIndex];

            if (coluna is DataGridViewButtonColumn)
                return;

            string orderBy = coluna.Name.ToLower();

            if (_ordenadoPor == orderBy)
                _crescente = !_crescente;
            else
            {
                _ordenadoPor = orderBy;
                _crescente = true;
            }

            await AtualizarDataGrid();
        }

        private async void NovoProdutoButton_Click(object sender, EventArgs e)
        {
            var telaCadastroProduto = new TelaCadastroProduto();
            telaCadastroProduto.ShowDialog();
            await AtualizarDataGrid();
        }

        private void SairButton_Click(object sender, EventArgs e)
        {
            //var confirmacao = MessageBox.Show("Tem certeza que deseja sair?",
            //    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (confirmacao == DialogResult.Yes)
                Close();
        }
    }
}
