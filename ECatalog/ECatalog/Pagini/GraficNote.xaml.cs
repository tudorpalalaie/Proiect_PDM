using Microcharts;

namespace ECatalog;

public partial class GraficNote : ContentPage
{
    public ServiciuMaterii Materii { get; set; } = new ServiciuMaterii();
    public GraficNote()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        List<ChartEntry> chartEntries = new List<ChartEntry>();
        List<Materie> listaMaterii = await Materii.PreiaMaterii();
        Random rdn = new Random();

        foreach (Materie m in listaMaterii)
        {
            chartEntries.Add(new ChartEntry(Int32.Parse(m.Nota.ToString()))
            {
                Label = m.Nume,
                ValueLabel = m.Nota.ToString(),
                Color = new SkiaSharp.SKColor(
                    (byte)rdn.Next(256),
                       (byte)rdn.Next(256),
                       (byte)rdn.Next(256)
                       )
            }
            );
        }

        chartView.Chart = new RadarChart()
        {
            Entries = chartEntries
        };
    }
}