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
    public partial class TelaCompra : Form
    {
        private List<Compra> _compra = new();
        private readonly CompraService _service;

        private string _ordenadoPor = "";
        private bool _crescente = true;
        private string _idcliente = "";
        private string _idcompra = "";

        public TelaCompra()
        {
            InitializeComponent();
            _service = new CompraService();
            this.Load += TelaCompra_Load;
            dataGridView1.ColumnHeaderMouseClick += DataGridView1_ColumnHeaderMouseClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private async void TelaCompra_Load(object? sender, EventArgs e)
        {
            await AtualizarDataGrid();
        }

        private async Task AtualizarDataGrid()
        {
            if (!string.IsNullOrWhiteSpace(_idcliente) && string.IsNullOrWhiteSpace(_idcompra))
            {
                _compra = await _service.GetComprasAsync(
                    orderBy: string.IsNullOrWhiteSpace(_ordenadoPor) ? null : _ordenadoPor,
                    clienteId: _idcliente
                );
            }
            else if(string.IsNullOrWhiteSpace(_idcliente) && !string.IsNullOrWhiteSpace(_idcompra))
            {
                var compra = await _service.GetCompraByIdAsync(
                    id: _idcompra
                );
                _compra = new List<Compra> { compra };
            }
            else if (!string.IsNullOrWhiteSpace(_idcliente) && !string.IsNullOrWhiteSpace(_idcompra))
            {
                _compra = await _service.GetComprasAsync(
                    orderBy: string.IsNullOrWhiteSpace(_ordenadoPor) ? null : _ordenadoPor,
                    clienteId: null
                );
            }

            if (!_crescente)
                _compra.Reverse();

            if (_compra.Count == 0)
            {
                MessageBox.Show("Nenhuma compra encontrada.");
                return;
            }

            dataGridView1.SuspendLayout();
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _compra;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoResizeRows();

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (!(col is DataGridViewButtonColumn))
                    col.ReadOnly = true;
            }

            DefinirColunasAcao();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.CellClick -= DataGridView1_CellClick;
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView1.ResumeLayout();
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Produtos")
            {
                var compra = dataGridView1.Rows[e.RowIndex].DataBoundItem as Compra;
                if (compra != null && compra.Produtos != null)
                {
                    string textoFormatado = string.Join("\n", compra.Produtos.Select(p => $"{p.NomeProduto} - {p.Quantidade}"));
                    e.Value = textoFormatado;
                    e.FormattingApplied = true;
                }
            }
        }

        private void DefinirColunasAcao()
        {
            if (!dataGridView1.Columns.Contains("Editar"))
            {
                var colunaEditar = new DataGridViewButtonColumn
                {
                    Name = "Editar",
                    HeaderText = "Ações",
                    UseColumnTextForButtonValue = false
                };
                dataGridView1.Columns.Add(colunaEditar);
            }

            if (!dataGridView1.Columns.Contains("Excluir"))
            {
                var colunaExcluir = new DataGridViewButtonColumn
                {
                    Name = "Excluir",
                    HeaderText = "",
                    UseColumnTextForButtonValue = false
                };
                dataGridView1.Columns.Add(colunaExcluir);
            }
        }

        private async void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string colunaClicada = dataGridView1.Columns[e.ColumnIndex].Name;
            string botaoTexto = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "";

            if (colunaClicada == "Editar")
            {
                var compraSelecionada = _compra[e.RowIndex];
                var telaNovaCompra = new TelaNovaCompra(compraSelecionada);
                telaNovaCompra.ShowDialog();
                await AtualizarDataGrid();
            }
            else if (colunaClicada == "Excluir")
            {
                ExcluirCompra(e.RowIndex);
            }
        }

        private async void ExcluirCompra(int rowIndex)
        {
            var confirmacao = MessageBox.Show(
                "Deseja realmente excluir este cliente?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacao == DialogResult.Yes)
            {
                await _service.DeleteCompraAsync(_compra[rowIndex].Id!);
                _compra.RemoveAt(rowIndex);
                await AtualizarDataGrid();
                MessageBox.Show("Compra excluída com sucesso!");
            }
        }

        private void radioIdCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIdCliente.Checked)
                radioIdCompra.Checked = false;
        }

        private void radioIdCompra_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIdCompra.Checked)
                radioIdCliente.Checked = false;
        }

        private async void BuscarButton_Click(object sender, EventArgs e)
        {
            if (radioIdCliente.Checked)
            {
                _idcliente = caixaPesquisa.Text;
            }
            else if (radioIdCompra.Checked)
            {
                _idcompra = caixaPesquisa.Text;
            }
            await AtualizarDataGrid();
        }

        private void SairButton_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show("Tem certeza que deseja sair?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
                Close();
        }

        private async void NovaCompraButton_Click(object sender, EventArgs e)
        {
            var telaNovaCompra = new TelaNovaCompra();
            telaNovaCompra.ShowDialog();
            await AtualizarDataGrid();
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
