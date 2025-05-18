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
        private readonly CompraService _serviceCompra;
        private readonly ProdutoService _serviceProduto;
        private string _ordenadoPor = "";
        private bool _crescente = true;
        private string _nomeproduto = "";

        public TelaNovaCompra(Compra? compra = null)
        {
            InitializeComponent();
            _compraoriginal = compra;
            _serviceCompra = new CompraService();
            _serviceProduto = new ProdutoService();
            if (_compraoriginal != null)
            {
                caixaidCliente.Text = _compraoriginal.ClienteId;
                caixaData.Text = _compraoriginal.Data.ToString("dd/MM/yyyy");
            }
            this.Load += TelaNovaCompra_Load;
            dataGridView1.ColumnHeaderMouseClick += DataGridView1_ColumnHeaderMouseClick;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            caixabuscaProduto.TextChanged += CaixabuscaProduto_TextChanged;
            caixaData.Click += CaixaData_Click;
        }

        private async void TelaNovaCompra_Load(object? sender, EventArgs e)
        {
            await AtualizarDataGrid();
        }

        private async Task AtualizarDataGrid()
        {
            _produto = await _serviceProduto.GetProdutosAsync(
                orderBy: string.IsNullOrWhiteSpace(_ordenadoPor) ? null : _ordenadoPor,
                nome: _nomeproduto
            );
            if (!_crescente)
                _produto.Reverse();
            if (_produto.Count == 0)
            {
                MessageBox.Show("Nenhuma produto encontrado.");
                return;
            }
            dataGridView1.SuspendLayout();
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _produto;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (!(col is DataGridViewButtonColumn))
                    col.ReadOnly = true;
            }
            AdicionarColunas();
            if (_compraoriginal != null && _compraoriginal.Produtos != null)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string prodId = row.Cells["Id"].Value?.ToString();
                    var itemCompra = _compraoriginal.Produtos.FirstOrDefault(i => i.ProdutoId == prodId);
                    if (itemCompra != null)
                    {
                        row.Cells["Selecionar"].Value = true;
                        row.Cells["Quantidade"].Value = itemCompra.Quantidade;
                    }
                    else
                    {
                        row.Cells["Selecionar"].Value = false;
                        row.Cells["Quantidade"].Value = "";
                    }
                }
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ResumeLayout();
        }

        private void AdicionarColunas()
        {
            DataGridViewCheckBoxColumn colunaSelecionar = new DataGridViewCheckBoxColumn();
            colunaSelecionar.Name = "Selecionar";
            colunaSelecionar.HeaderText = "Selecionar";
            dataGridView1.Columns.Add(colunaSelecionar);
            DataGridViewTextBoxColumn colunaQuantidade = new DataGridViewTextBoxColumn();
            colunaQuantidade.Name = "Quantidade";
            colunaQuantidade.HeaderText = "Quantidade";
            dataGridView1.Columns.Add(colunaQuantidade);
        }

        private void CalculaValorTotal()
        {
            decimal valorTotal = 0.00m;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Selecionar"].Value != null && Convert.ToBoolean(row.Cells["Selecionar"].Value))
                {
                    decimal valorUnitario = 0.00m;
                    if (row.Cells["Preco"].Value != null)
                    {
                        decimal.TryParse(row.Cells["Preco"].Value.ToString(), out valorUnitario);
                    }
                    int quantidade = 0;
                    if (row.Cells["Quantidade"].Value != null)
                    {
                        int.TryParse(row.Cells["Quantidade"].Value.ToString(), out quantidade);
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
                dataGridView1.Columns[e.ColumnIndex].Name == "Quantidade")
            {
                CalculaValorTotal();
            }
        }

        private void CaixaData_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(caixaData.Text))
            {
                caixaData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
        }

        private async void Salvarbutton_Click(object sender, EventArgs e)
        {
            DateTime data;
            if(DateTime.TryParseExact(caixaData.Text, "dd/MM/yyyy",
                                                  System.Globalization.CultureInfo.InvariantCulture,
                                                  System.Globalization.DateTimeStyles.None, out data))
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
                    string produtoId = row.Cells["Id"].Value.ToString();
                    string nomeProduto = row.Cells["Nome"].Value.ToString();
                    int quantidade = int.Parse(row.Cells["Quantidade"].Value.ToString());

                    produtosSelecionados.Add(new ProdutoCompra
                    {
                        ProdutoId = produtoId,
                        NomeProduto = nomeProduto,
                        Quantidade = quantidade
                    });
                }
            }
            if (_compraoriginal != null)
            {
                var compraeditada = new Compra()
                {
                    Id = _compraoriginal.Id,
                    ClienteId = caixaidCliente.Text,
                    Produtos = produtosSelecionados,
                    Data = DateTime.Parse(caixaData.Text),
                    Total = decimal.Parse(caixaValorTotal.Text)
                };
                Compra? compraalterada = await _serviceCompra.UpdateCompraAsync(compraeditada);
                if (compraalterada != null)
                {
                    MessageBox.Show("Compra alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (_compraoriginal == null)
            {
                var novacompra = new Compra()
                {
                    ClienteId = caixaidCliente.Text,
                    Produtos = produtosSelecionados,
                    Data = DateTime.Parse(caixaData.Text),
                    Total = decimal.Parse(caixaValorTotal.Text)
                };
                Compra? compra = await _serviceCompra.CreateCompraAsync(novacompra);
                if (compra != null)
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
