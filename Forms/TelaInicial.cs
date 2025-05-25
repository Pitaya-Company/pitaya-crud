
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

        public TelaInicial()
        {
            InitializeComponent();
            _compraService = new CompraService();
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

            var dadosAgrupados = compras
                .GroupBy(c => new DateTime(c.Data.Year, c.Data.Month, 1))
                .OrderBy(g => g.Key)
                .ToList();

            if (dadosAgrupados.Count == 0)
            {
                graficoVendas.Series = Array.Empty<ISeries>();
                graficoVendas.XAxes = Array.Empty<Axis>();
                graficoVendas.YAxes = Array.Empty<Axis>();
                return;
            }

            var labels = dadosAgrupados.Select(g => g.Key.ToString("MMM yyyy")).ToArray();
            var values = dadosAgrupados.Select(g => (double)g.Sum(c => c.Total)).ToArray();

            var series = new LineSeries<double>
            {
                Name = "Vendas",
                Values = values,
                Fill = new SolidColorPaint(new SKColor(70, 130, 180, 100)),
                Stroke = new SolidColorPaint(new SKColor(70, 130, 180)) { StrokeThickness = 3 },
                GeometrySize = 0,
                LineSmoothness = 0.3,
            };


            graficoVendas.Series = [series];

            graficoVendas.XAxes =
            [
                new Axis
                {
                    Labels = labels,
                    LabelsRotation = 45,
                    Name = "Mês",
                    NamePadding = new LiveChartsCore.Drawing.Padding(0, 15, 0, 0),
                }
            ];

            graficoVendas.YAxes =
            [
                new Axis
                {
                    Name = "Total de Vendas (R$)",
                    Labeler = value => value.ToString("C2")
                }
            ];
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
            // new TelaUsuario.ShowDialog();
            // Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await CarregarDadosDeVendas();
        }
    }
}
