using Microcharts;
using System.Collections.ObjectModel;

namespace ECatalog;

public partial class GraficNote : ContentPage
{
    public ServiciuMaterii ServiciuMaterii { get; set; } = new ServiciuMaterii();
    public ObservableCollection<Materie> ListaMaterii { get; set; }
    public GraficNote()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        try
        {
            List<ChartEntry> chartEntries = new List<ChartEntry>();
            List<Materie> listaMaterii = await ServiciuMaterii.PreiaMaterii();
            Random rdn = new Random();
            
            foreach (Materie m in listaMaterii)
            {
                chartEntries.Add(new ChartEntry(m.Nota)
                {
                    Label = m.Nume,
                    ValueLabel = m.Nota.ToString(),
                    Color = new SkiaSharp.SKColor(
                           (byte)rdn.Next(256),
                           (byte)rdn.Next(256),
                           (byte)rdn.Next(256))
                }
                );
            }

            chartView.Chart = new BarChart()
            {
                Entries = chartEntries,
                LabelOrientation = Orientation.Horizontal,
                ValueLabelOrientation = Orientation.Horizontal,
                ShowYAxisLines = true,
            };

            chartView2.Chart = new LineChart()
            {
                Entries = chartEntries,
                LabelOrientation = Orientation.Horizontal,
                ValueLabelOrientation = Orientation.Horizontal,
            };
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}