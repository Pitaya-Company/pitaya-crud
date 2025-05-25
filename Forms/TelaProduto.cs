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

        private Dictionary<int, Produto> _produtosOriginais = new();

        public TelaProduto()
        {
            InitializeComponent();
            _service = new ProdutoService();

            this.Load += TelaProduto_Load;
            dataGridView1.ColumnHeaderMouseClick += DataGridView1_ColumnHeaderMouseClick;
            dataGridView1.CellClick += DataGridView1_CellClick;
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
            if (!dataGridView1.Columns.Contains("Editar"))
            {
                var colunaEditar = new DataGridViewButtonColumn
                {
                    Name = "Editar",
                    HeaderText = "Editar",
                    UseColumnTextForButtonValue = false
                };
                dataGridView1.Columns.Add(colunaEditar);
            }

            if (!dataGridView1.Columns.Contains("Excluir"))
            {
                var colunaExcluir = new DataGridViewButtonColumn
                {
                    Name = "Excluir",
                    HeaderText = "Excluir",
                    UseColumnTextForButtonValue = false
                };
                dataGridView1.Columns.Add(colunaExcluir);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Editar"].Value = "Editar";
                row.Cells["Excluir"].Value = "Excluir";
            }
        }


        private async void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string coluna = dataGridView1.Columns[e.ColumnIndex].Name;
            var cellValue = dataGridView1.Rows[e.RowIndex].Cells[coluna].Value?.ToString();

            if (coluna == "Excluir" && cellValue == "Cancelar")
            {
                if (_produtosOriginais.ContainsKey(e.RowIndex))
                {
                    _produtos[e.RowIndex] = _produtosOriginais[e.RowIndex];
                    await AtualizarDataGrid();
                }
                return;
            }

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
            else if (coluna == "Editar")
            {
                if (cellValue == "Editar")
                {
                    _produtosOriginais[e.RowIndex] = new Produto
                    {
                        CodigoProduto = _produtos[e.RowIndex].CodigoProduto,
                        NomeProduto = _produtos[e.RowIndex].NomeProduto,
                        Valor = _produtos[e.RowIndex].Valor,
                        Quantidade = _produtos[e.RowIndex].Quantidade
                    };

                    dataGridView1.Rows[e.RowIndex].Cells["NomeProduto"].ReadOnly = false;
                    dataGridView1.Rows[e.RowIndex].Cells["Valor"].ReadOnly = false;
                    dataGridView1.Rows[e.RowIndex].Cells["Quantidade"].ReadOnly = false;

                    dataGridView1.Rows[e.RowIndex].Cells["Editar"].Value = "Confirmar";
                    dataGridView1.Rows[e.RowIndex].Cells["Excluir"].Value = "Cancelar";
                }
                else
                {
                    try
                    {
                        var produto = _produtos[e.RowIndex];
                        await _service.UpdateProdutoAsync(produto);
                        MessageBox.Show("Produto atualizado com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao atualizar produto: {ex.Message}");
                    }
                    finally
                    {
                        await AtualizarDataGrid();
                    }
                }
            }
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
            Close();
        }

        private async void txtNomeBusca_TextChanged(object sender, EventArgs e)
        {
            _filtroNome = txtNomeBusca.Text;
            _produtos = _produtos.Where(p => p.NomeProduto
                    .Contains(_filtroNome, StringComparison.CurrentCultureIgnoreCase))
                .ToList();
            await AtualizarDataGrid();
        }
    }
}
