using pitaya_crud.Models;
using pitaya_crud.Services;

namespace pitaya_crud.Forms
{
    public partial class TelaListagem : Form
    {
        private List<Cliente>? _clientes;
        private readonly ClienteService _service;
        private Dictionary<int, Cliente> _backupClientes = new();

        public TelaListagem()
        {
            InitializeComponent();
            _service = new ClienteService();
            this.Load += TelaListagem_Load;
        }

        private async void TelaListagem_Load(object? sender, EventArgs e)
        {
            try
            {
                _clientes = await _service.GetClientesAsync();
                if (_clientes == null || _clientes.Count == 0)
                {
                    MessageBox.Show("Nenhum cliente foi encontrado");
                }
                AtualizarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao carregar os clientes: {ex.Message}");
            }
        }

        public void AtualizarDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _clientes;

            if (dataGridView1.Columns["Editar"] == null)
            {
                var colunaEditar = new DataGridViewButtonColumn
                {
                    Name = "Editar",
                    HeaderText = "",
                    UseColumnTextForButtonValue = false
                };
                dataGridView1.Columns.Add(colunaEditar);
            }

            if (dataGridView1.Columns["Excluir"] == null)
            {
                var colunaExcluir = new DataGridViewButtonColumn
                {
                    Name = "Excluir",
                    HeaderText = "",
                    UseColumnTextForButtonValue = false
                };
                dataGridView1.Columns.Add(colunaExcluir);
            }

            ConfigurarDataGrid();
            AtualizarBotoesDeAcao();

            dataGridView1.CellClick -= DataGridView1_CellClick;
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        public void ConfigurarDataGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BorderStyle = BorderStyle.None;

            foreach (DataGridViewColumn coluna in dataGridView1.Columns)
            {
                coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dataGridView1.Left = (this.ClientSize.Width - dataGridView1.Width) / 2;
        }

        // Os botões das colunas de ação se transformam ao selecionar Editar
        private void AtualizarBotoesDeAcao()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Index >= 0)
                {
                    if (_backupClientes.ContainsKey(row.Index))
                    {
                        row.Cells["Editar"].Value = "OK";
                        row.Cells["Excluir"].Value = "Cancelar";
                    }
                    else
                    {
                        row.Cells["Editar"].Value = "Editar";
                        row.Cells["Excluir"].Value = "Excluir";
                    }
                }
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
                {
                    string buttonText = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "Editar";

                    if (buttonText == "Editar")
                    {
                        IniciarEdicao(e.RowIndex);
                    }
                    else if (buttonText == "OK")
                    {
                        ConfirmarEdicao(e.RowIndex);
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Excluir")
                {
                    string buttonText = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "Excluir";

                    if (buttonText == "Excluir")
                    {
                        ExcluirCliente(e.RowIndex);
                    }
                    else if (buttonText == "Cancelar")
                    {
                        CancelarEdicao(e.RowIndex);
                    }
                }
            }
        }

        private void IniciarEdicao(int rowIndex)
        {
            if (!_backupClientes.ContainsKey(rowIndex))
            {
                _backupClientes[rowIndex] = new Cliente
                {
                    Id = _clientes![rowIndex].Id,
                    Nome = _clientes[rowIndex].Nome,
                    Idade = _clientes[rowIndex].Idade,
                    Telefone = _clientes[rowIndex].Telefone,
                    Fumante = _clientes[rowIndex].Fumante,
                    Sexo = _clientes[rowIndex].Sexo
                };
            }

            dataGridView1.Rows[rowIndex].Cells["Nome"].ReadOnly = false;
            dataGridView1.Rows[rowIndex].Cells["Idade"].ReadOnly = false;
            dataGridView1.Rows[rowIndex].Cells["Telefone"].ReadOnly = false;
            dataGridView1.Rows[rowIndex].Cells["Sexo"].ReadOnly = false;

            dataGridView1.Rows[rowIndex].Cells["Editar"].Value = "OK";
            dataGridView1.Rows[rowIndex].Cells["Excluir"].Value = "Cancelar";
        }

        private async void ConfirmarEdicao(int rowIndex)
        {
            Cliente clienteEditado = _clientes![rowIndex];

            if (!clienteEditado.IsValid())
            {
                MessageBox.Show("Os dados inseridos são inválidos!");
                return;
            }

            try
            {
                await _service.UpdateClienteAsync(clienteEditado);
                MessageBox.Show("Cliente atualizado com sucesso!");
                _backupClientes.Remove(rowIndex);
                AtualizarBotoesDeAcao();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar cliente: {ex.Message}");
            }
        }

        private void CancelarEdicao(int rowIndex)
        {
            if (_backupClientes.ContainsKey(rowIndex))
            {
                _clientes![rowIndex] = _backupClientes[rowIndex];
                _backupClientes.Remove(rowIndex);
            }

            AtualizarDataGrid();
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
                try
                {
                    await _service.DeleteClienteAsync(_clientes![rowIndex].Id!);
                    _clientes.RemoveAt(rowIndex);
                    AtualizarDataGrid();
                    MessageBox.Show("Cliente excluído com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir cliente: {ex.Message}");
                }
            }
        }

        private async void CaixaDePesquisa_TextChanged(object sender, EventArgs e)
        {
            caixaDePesquisa.PlaceholderText = "Pesquise aqui...";
            _clientes = await _service.GetClientesAsync(null, caixaDePesquisa.Text);
            AtualizarDataGrid();
        }

        private void CadastrarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastrar clicado");
        }

        private void SairButton_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show(
                "Sair agora?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacao == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
