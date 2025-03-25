using pitaya_crud.Models;
using pitaya_crud.Services;

namespace pitaya_crud.Forms
{
    public partial class TelaListagem : Form
    {
        private List<Cliente>? _clientes;
        private readonly ClienteService _service;
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
                throw new Exception($"Ocorreu um erro ao carregar os clientes: {ex.Message}");
            }
        }

        public void AtualizarDataGrid()
        {
            dataGridView1.DataSource = null; // limpa antes
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _clientes;
            ConfigurarDataGrid();
        }

        public void ConfigurarDataGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BorderStyle = BorderStyle.None;

            // Centraliza o conteúdo de todas as colunas
            foreach (DataGridViewColumn coluna in dataGridView1.Columns)
            {
                coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dataGridView1.Left = (this.ClientSize.Width - dataGridView1.Width) / 2;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void CaixaDePesquisa_TextChanged(object sender, EventArgs e)
        {
            caixaDePesquisa.PlaceholderText = "Pesquise aqui...";
            _clientes = await _service.GetClientesAsync(null, caixaDePesquisa.Text);
            AtualizarDataGrid();
        }

    }
}
