namespace ECatalog;

public partial class CalculatorMedie : ContentPage
{
	public CalculatorMedie()
	{
		InitializeComponent();
	}
    private void CalculeazaMedie(object sender, EventArgs e)
    {
        if (entryValoare.Text != null && entryValoare2.Text != null && entryValoare3.Text != null && entryValoare4.Text != null && entryValoare5.Text != null && entryValoare6.Text != null)
        {
            if (entryCredite.Text != null && entryCredite2.Text != null && entryCredite3.Text != null && entryCredite4.Text != null && entryCredite5.Text != null && entryCredite6.Text != null)
            {
                {
                    float sum = Int32.Parse(entryCredite.Text) + Int32.Parse(entryCredite2.Text) + Int32.Parse(entryCredite3.Text) + Int32.Parse(entryCredite4.Text) + Int32.Parse(entryCredite5.Text) + Int32.Parse(entryCredite6.Text);

                    int nota1 = Int32.Parse(entryCredite.Text) * Int32.Parse(entryValoare.Text);
                    int nota2 = Int32.Parse(entryCredite2.Text) * Int32.Parse(entryValoare2.Text);
                    int nota3 = Int32.Parse(entryCredite3.Text) * Int32.Parse(entryValoare3.Text);
                    int nota4 = Int32.Parse(entryCredite4.Text) * Int32.Parse(entryValoare4.Text);
                    int nota5 = Int32.Parse(entryCredite5.Text) * Int32.Parse(entryValoare5.Text);
                    int nota6 = Int32.Parse(entryCredite6.Text) * Int32.Parse(entryValoare6.Text);

                    float totalSum = nota1 + nota2 + nota3 + nota4 + nota5 + nota6;


                    float medie = totalSum / sum;

                    result.Text = medie.ToString("0.00");

                    SemanticScreenReader.Announce(result.Text);

                }
            }
            else
            {
                DisplayAlert("Info", "Introduceti toate creditele!", "OK");
            }
        }
        else
        {
            DisplayAlert("Info", "Introduceti toate notele!", "OK");
        }


    }

}