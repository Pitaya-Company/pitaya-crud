
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView.Painting;
using pitaya_crud.Models;
using pitaya_crud.Services;
using SkiaSharp;
using LiveChartsCore.SkiaSharpView;

namespace pitaya_crud.Forms
{
    public partial class TelaInicial : Form
    {
        private CartesianChart graficoVendas;
        private readonly CompraService _compraService;
        private readonly ClienteService _clienteService;

        public TelaInicial()
        {
            InitializeComponent();
            _compraService = new CompraService();
            _clienteService = new ClienteService();
            InicializarGrafico();
            _ = CarregarDadosDeVendas();
        }

        private void InicializarGrafico()
        {
            graficoVendas = new CartesianChart
            {
                Dock = DockStyle.Fill,
                LegendPosition = LegendPosition.Top,
                TooltipPosition = TooltipPosition.Top,
            };

            graficoPanel.Controls.Add(graficoVendas);
        }

        private async Task CarregarDadosDeVendas()
        {
            List<Compra> compras = await _compraService.GetComprasAsync();
            List<Cliente> clientes = await _clienteService.GetClientesAsync();

            var comprasAgrupadas = compras
                .GroupBy(c => new DateTime(c.Data.Year, c.Data.Month, 1))
                .OrderBy(g => g.Key)
                .ToList();

            var clientesAgrupados = clientes
                .GroupBy(c => new DateTime(c.DataCriacao.Year, c.DataCriacao.Month, 1))
                .ToDictionary(g => g.Key, g => g.Count());

            if (comprasAgrupadas.Count == 0)
            {
                graficoVendas.Series = Array.Empty<ISeries>();
                graficoVendas.XAxes = Array.Empty<Axis>();
                graficoVendas.YAxes = Array.Empty<Axis>();
                return;
            }

            var labels = comprasAgrupadas.Select(g => g.Key.ToString("MMM yyyy")).ToArray();
            var valoresVendas = comprasAgrupadas.Select(g => (double)g.Sum(c => c.Total)).ToArray();
            var valoresClientes = comprasAgrupadas
                .Select(g => clientesAgrupados.TryGetValue(g.Key, out int count) ? (double)count : 0)
                .ToArray();

            var seriesVendas = new LineSeries<double>
            {
                Name = "Vendas (R$)",
                Values = valoresVendas,
                Fill = new SolidColorPaint(new SKColor(205, 92, 92, 100)),
                Stroke = new SolidColorPaint(new SKColor(205, 92, 92)) { StrokeThickness = 3 },
                GeometrySize = 0,
                LineSmoothness = 0.3,
            };

            var seriesClientes = new ColumnSeries<double>
            {
                Name = "Novos Clientes",
                Values = valoresClientes,
                Fill = new SolidColorPaint(new SKColor(135, 206, 250)),
                Stroke = null
            };

            graficoVendas.Series = new ISeries[] { seriesClientes, seriesVendas };

            graficoVendas.XAxes = new[]
            {
        new Axis
        {
            Labels = labels,
            LabelsRotation = 45,
            Name = "Mês",
            NamePadding = new LiveChartsCore.Drawing.Padding(0, 15, 0, 0),
        }
    };

            graficoVendas.YAxes = new[]
            {
        new Axis
        {
            Name = "Valores / Quantidades",
            Labeler = value => value.ToString("N0")
        }
    };
        }


        private void comprasButton_Click(object sender, EventArgs e)
        {
            new TelaCompra().ShowDialog();
            Show();
        }

        private void produtosButton_Click(object sender, EventArgs e)
        {
            new TelaProduto().ShowDialog();
            Show();
        }

        private void clientesButton_Click(object sender, EventArgs e)
        {
            new TelaListagem().ShowDialog();
            Show();
        }

        private void usuariosButton_Click(object sender, EventArgs e)
        {
            new TelaUsuario().ShowDialog();
            Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await CarregarDadosDeVendas();
        }

        private void TituloPitaya_Click(object sender, EventArgs e)
        {

        }
    }
}
