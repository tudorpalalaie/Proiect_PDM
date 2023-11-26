namespace ECatalog;

public partial class Materii : ContentPage

{
    public ServiciuMaterii ServiciuMaterii { get; set; } = new ServiciuMaterii();
    List<Materie> listaMaterii = new List<Materie>();
    public Materii()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        if (listaMaterii.Count == 0)
        {
            listaMaterii = await ServiciuMaterii.PreiaMaterii();
            App.DaoMaterii.AdaugaListaMaterii(listaMaterii);
        }

        lvMaterii.ItemsSource = listaMaterii;
    }

    private void lvMaterii_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        DisplayAlert("Info", e.SelectedItem.ToString(), "OK");
    }

    private void OnDelete(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DaoMaterii.StergeMaterie((int)button.BindingContext);
        lvMaterii.ItemsSource = App.DaoMaterii.ObtineMaterii();
    }
}