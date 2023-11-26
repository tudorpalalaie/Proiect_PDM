namespace ECatalog;

public partial class Note : ContentPage
{
    List<Materie> materieList = new List<Materie>();
    public ServiciuMaterii ServiciuMaterii { get; set; } = new ServiciuMaterii();
    public Note()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        DaoMaterii daoMaterii = new DaoMaterii();

        materieList = await ServiciuMaterii.PreiaMaterii();
        daoMaterii.AdaugaListaMaterii(materieList);
        
        pickerMaterii.ItemsSource = materieList;

    }

    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        int selectedIndex = pickerMaterii.SelectedIndex;

        if (selectedIndex != -1)
        {
            entryNota.Text = materieList[pickerMaterii.SelectedIndex].Nota.ToString();
        }
    }

}