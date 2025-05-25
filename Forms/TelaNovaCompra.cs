using pitaya_crud.Models;
using pitaya_crud.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pitaya_crud.Forms
{
    public partial class TelaNovaCompra : Form
    {
        private Compra? _compraoriginal;
        private List<Produto> _produto = new();
        private List<Cliente> _clientes = new();
        private readonly CompraService _serviceCompra;
        private readonly ProdutoService _serviceProduto;
        private readonly ClienteService _serviceCliente;
        private string _ordenadoPor = "";
        private bool _crescente = true;
        private string _nomeproduto = "";

        public TelaNovaCompra(Compra? compra = null)
        {
            InitializeComponent();
            _compraoriginal = compra;
            _serviceCompra = new CompraService();
            _serviceProduto = new ProdutoService();
            _serviceCliente = new ClienteService();

            this.Load += TelaNovaCompra_Load;
            dataGridView1.ColumnHeaderMouseClick += DataGridView1_ColumnHeaderMouseClick;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            caixabuscaProduto.TextChanged += CaixabuscaProduto_TextChanged;
            caixaData.Click += CaixaData_Click;
        }

        private async void TelaNovaCompra_Load(object? sender, EventArgs e)
        {
            await CarregarClientesAsync();
            if (_compraoriginal != null)
            {
                var clienteSelecionado = _clientes.FirstOrDefault(c => c.Id == _compraoriginal.ClienteId);
                if (clienteSelecionado != null)
                {
                    clienteCombo.SelectedItem = clienteSelecionado;
                }
                caixaData.Text = _compraoriginal.Data.ToString("dd/MM/yyyy");
            }
            await AtualizarDataGrid();
        }

        private async Task CarregarClientesAsync()
        {
            _clientes = await _serviceCliente.GetClientesAsync();
            clienteCombo.DataSource = _clientes;
            clienteCombo.DisplayMember = "Nome";
            clienteCombo.ValueMember = "Id";
            clienteCombo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            clienteCombo.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private async Task AtualizarDataGrid()
        {
            var estadoAtual = new Dictionary<string, (bool selecionado, int quantidade)>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var prodId = row.Cells["CodigoProduto"]?.Value?.ToString();
                if (!string.IsNullOrEmpty(prodId))
                {
                    bool selecionado = row.Cells["Selecionar"]?.Value as bool? ?? false;
                    int.TryParse(row.Cells["QuantidadeP"]?.Value?.ToString(), out int quantidade);
                    estadoAtual[prodId] = (selecionado, quantidade);
                }
            }

            _produto = await _serviceProduto.GetProdutosAsync(
                orderBy: string.IsNullOrWhiteSpace(_ordenadoPor) ? null : _ordenadoPor,
                nome: _nomeproduto
            );
            if (!_crescente)
                _produto.Reverse();

            if (_produto.Count == 0)
            {
                MessageBox.Show("Nenhum produto encontrado.");
                return;
            }

            dataGridView1.SuspendLayout();
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _produto;
            AdicionarColunas();

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (!(col is DataGridViewButtonColumn) && col.Name != "QuantidadeP" && col.Name != "Selecionar")
                    col.ReadOnly = true;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string prodId = row.Cells["CodigoProduto"].Value?.ToString();
                if (estadoAtual.TryGetValue(prodId, out var estado))
                {
                    row.Cells["Selecionar"].Value = estado.selecionado;
                    row.Cells["QuantidadeP"].Value = estado.quantidade > 0 ? estado.quantidade.ToString() : "";
                }
                else if (_compraoriginal != null && _compraoriginal.Produtos != null)
                {
                    var itemCompra = _compraoriginal.Produtos.FirstOrDefault(i => i.ProdutoId == prodId);
                    if (itemCompra != null)
                    {
                        row.Cells["Selecionar"].Value = true;
                        row.Cells["QuantidadeP"].Value = itemCompra.QuantidadeP;
                    }
                    else
                    {
                        row.Cells["Selecionar"].Value = false;
                        row.Cells["QuantidadeP"].Value = "";
                    }
                }
                else
                {
                    row.Cells["Selecionar"].Value = false;
                    row.Cells["QuantidadeP"].Value = "";
                }
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ResumeLayout();
        }

        private void AdicionarColunas()
        {
            if (dataGridView1.Columns.Contains("Selecionar"))
            {
                dataGridView1.Columns.Remove("Selecionar");
            }
            if (dataGridView1.Columns.Contains("QuantidadeP"))
            {
                dataGridView1.Columns.Remove("QuantidadeP");
            }
            if (!dataGridView1.Columns.Contains("Selecionar"))
            {
                var colunaSelecionar = new DataGridViewCheckBoxColumn
                {
                    Name = "Selecionar",
                    HeaderText = "Selecionar"
                };
                dataGridView1.Columns.Insert(0, colunaSelecionar);
            }
            if (!dataGridView1.Columns.Contains("QuantidadeP"))
            {
                var colunaQuantidadeP = new DataGridViewTextBoxColumn
                {
                    Name = "QuantidadeP",
                    HeaderText = "QuantidadeP"
                };
                dataGridView1.Columns.Insert(1, colunaQuantidadeP);
            }
        }

        private void CalculaValorTotal()
        {
            decimal valorTotal = 0.00m;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Selecionar"].Value != null && Convert.ToBoolean(row.Cells["Selecionar"].Value))
                {
                    decimal valorUnitario = 0.00m;
                    if (row.Cells["Valor"].Value != null)
                    {
                        decimal.TryParse(row.Cells["Valor"].Value.ToString(), out valorUnitario);
                    }
                    int quantidade = 0;
                    if (row.Cells["QuantidadeP"].Value != null)
                    {
                        int.TryParse(row.Cells["QuantidadeP"].Value.ToString(), out quantidade);
                    }
                    valorTotal += valorUnitario * quantidade;
                }
            }
            caixaValorTotal.Text = valorTotal.ToString("N2");
        }

        private async void CaixabuscaProduto_TextChanged(object sender, EventArgs e)
        {
            _nomeproduto = caixabuscaProduto.Text;
            await AtualizarDataGrid();
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Selecionar" ||
                dataGridView1.Columns[e.ColumnIndex].Name == "QuantidadeP")
            {
                CalculaValorTotal();
            }
        }

        private void CaixaData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(caixaData.Text))
            {
                caixaData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
        }

        private async void Salvarbutton_Click(object sender, EventArgs e)
        {
            if (clienteCombo.SelectedItem == null)
            {
                MessageBox.Show("Selecione um cliente.");
                return;
            }

            var clienteSelecionado = clienteCombo.SelectedItem as Cliente;
            if (clienteSelecionado == null)
            {
                MessageBox.Show("Cliente inválido.");
                return;
            }

            if (!DateTime.TryParseExact(caixaData.Text, "dd/MM/yyyy",
                                        System.Globalization.CultureInfo.InvariantCulture,
                                        System.Globalization.DateTimeStyles.None, out DateTime data))
            {
                MessageBox.Show("Data inválida. Formato válido dd/MM/yyyy");
                return;
            }

            var produtosSelecionados = new List<ProdutoCompra>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool selecionado = Convert.ToBoolean(row.Cells["Selecionar"].Value);
                if (selecionado)
                {
                    string produtoId = row.Cells["CodigoProduto"].Value.ToString();
                    string nomeProduto = row.Cells["NomeProduto"].Value.ToString();
                    int quantidadep = int.Parse(row.Cells["QuantidadeP"].Value.ToString());

                    produtosSelecionados.Add(new ProdutoCompra
                    {
                        ProdutoId = produtoId,
                        NomeProduto = nomeProduto,
                        QuantidadeP = quantidadep
                    });
                }
            }

            var novaCompra = new Compra
            {
                ClienteId = clienteSelecionado.Id,
                Produtos = produtosSelecionados,
                Data = data,
                Total = decimal.Parse(caixaValorTotal.Text)
            };

            if (_compraoriginal != null)
            {
                novaCompra.Id = _compraoriginal.Id;
                Compra? compraAlterada = await _serviceCompra.UpdateCompraAsync(novaCompra);
                if (compraAlterada != null)
                {
                    MessageBox.Show("Compra alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                Compra? compraCriada = await _serviceCompra.CreateCompraAsync(novaCompra);
                if (compraCriada != null)
                {
                    MessageBox.Show("Compra realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            Cancelarbutton.Text = "SAIR";
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var coluna = dataGridView1.Columns[e.ColumnIndex];

            if (coluna is DataGridViewButtonColumn)
                return;

            string orderBy = coluna.Name.ToLower();

            if (_ordenadoPor == orderBy)
            {
                _crescente = !_crescente;
            }
            else
            {
                _ordenadoPor = orderBy;
                _crescente = true;
            }

            await AtualizarDataGrid();
        }

    }
}
