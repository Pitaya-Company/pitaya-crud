using pitaya_crud.Models;
using pitaya_crud.Services;

namespace pitaya_crud.Forms
{
    public partial class TelaListagem : Form
    {
        private List<Cliente> _clientes = new();
        private readonly ClienteService _service;
        private readonly Dictionary<int, Cliente> _backupClientes = new();

        public TelaListagem()
        {
            InitializeComponent();
            _service = new ClienteService();
            this.Load += TelaListagem_Load;
        }

        private async void TelaListagem_Load(object? sender, EventArgs e)
        {
            await AtualizarDataGrid();
        }

        private async Task AtualizarDataGrid()
        {
            _clientes = await _service.GetClientesAsync() ?? new List<Cliente>();

            if (_clientes.Count == 0)
            {
                MessageBox.Show("Nenhum cliente foi encontrado.");
                return;
            }

            dataGridView1.SuspendLayout();
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _clientes;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (!(col is DataGridViewButtonColumn))
                    col.ReadOnly = true;
            }

            DefinirColunasAcao();
            AtualizarBotoesAcao();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.CellClick -= DataGridView1_CellClick;
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView1.ResumeLayout();
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

        private void AtualizarBotoesAcao()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Editar"].Value = "Editar";
                row.Cells["Excluir"].Value = "Excluir";
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string colunaClicada = dataGridView1.Columns[e.ColumnIndex].Name;
            string botaoTexto = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "";

            if (colunaClicada == "Editar")
            {
                if (botaoTexto == "Editar")
                    IniciarEdicao(e.RowIndex);
                else if (botaoTexto == "OK")
                    ConfirmarEdicao(e.RowIndex);
            }
            else if (colunaClicada == "Excluir")
            {
                if (botaoTexto == "Excluir")
                    ExcluirCliente(e.RowIndex);
                else if (botaoTexto == "Cancelar")
                    CancelarEdicao(e.RowIndex);
            }
        }

        private void IniciarEdicao(int rowIndex)
        {
            if (!_backupClientes.ContainsKey(rowIndex))
            {
                _backupClientes[rowIndex] = new Cliente
                {
                    Id = _clientes[rowIndex].Id,
                    Nome = _clientes[rowIndex].Nome,
                    Idade = _clientes[rowIndex].Idade,
                    Telefone = _clientes[rowIndex].Telefone,
                    Fumante = _clientes[rowIndex].Fumante,
                    Sexo = _clientes[rowIndex].Sexo
                };
            }

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (!(col is DataGridViewButtonColumn))
                    dataGridView1.Rows[rowIndex].Cells[col.Index].ReadOnly = false;
            }

            dataGridView1.Rows[rowIndex].Cells["Editar"].Value = "OK";
            dataGridView1.Rows[rowIndex].Cells["Excluir"].Value = "Cancelar";
        }

        private async void ConfirmarEdicao(int rowIndex)
        {
            Cliente clienteEditado = _clientes[rowIndex];

            if (!clienteEditado.IsValid())
            {
                MessageBox.Show("Os dados inseridos são inválidos!");
                return;
            }

            await _service.UpdateClienteAsync(clienteEditado);
            MessageBox.Show("Cliente atualizado com sucesso!");
            _backupClientes.Remove(rowIndex);
            await AtualizarDataGrid();
        }

        private void CancelarEdicao(int rowIndex)
        {
            if (_backupClientes.TryGetValue(rowIndex, out Cliente clienteBackup))
            {
                _clientes[rowIndex] = new Cliente
                {
                    Id = clienteBackup.Id,
                    Nome = clienteBackup.Nome,
                    Idade = clienteBackup.Idade,
                    Telefone = clienteBackup.Telefone,
                    Fumante = clienteBackup.Fumante,
                    Sexo = clienteBackup.Sexo
                };

                _backupClientes.Remove(rowIndex);

                // Restaura os valores nas células de exibição.
                dataGridView1.Rows[rowIndex].Cells["Nome"].Value = clienteBackup.Nome;
                dataGridView1.Rows[rowIndex].Cells["Idade"].Value = clienteBackup.Idade;
                dataGridView1.Rows[rowIndex].Cells["Telefone"].Value = clienteBackup.Telefone;
                dataGridView1.Rows[rowIndex].Cells["Fumante"].Value = clienteBackup.Fumante;
                dataGridView1.Rows[rowIndex].Cells["Sexo"].Value = clienteBackup.Sexo;
            }

            dataGridView1.Rows[rowIndex].Cells["Editar"].Value = "Editar";
            dataGridView1.Rows[rowIndex].Cells["Excluir"].Value = "Excluir";

            // Bloqueia novamente todas as células (exceto botões).
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (!(col is DataGridViewButtonColumn))
                    dataGridView1.Rows[rowIndex].Cells[col.Index].ReadOnly = true;
            }

            dataGridView1.Refresh();
        }

        private async void ExcluirCliente(int rowIndex)
        {
            var confirmacao = MessageBox.Show(
                "Deseja realmente excluir este cliente?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacao == DialogResult.Yes)
            {
                await _service.DeleteClienteAsync(_clientes[rowIndex].Id!);
                _clientes.RemoveAt(rowIndex);
                await AtualizarDataGrid();
                MessageBox.Show("Cliente excluído com sucesso!");
            }
        }

        private async void CaixaDePesquisa_TextChanged(object sender, EventArgs e)
        {
            _clientes = await _service.GetClientesAsync(null, caixaDePesquisa.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _clientes;
            DefinirColunasAcao();
            AtualizarBotoesAcao();
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

        private async void CadastrarButton_Click(object sender, EventArgs e)
        {
            var telaCadastro = new TelaCadastro();
            telaCadastro.ShowDialog();
            await AtualizarDataGrid();
        }
    }
}
