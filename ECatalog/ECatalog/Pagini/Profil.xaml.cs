namespace ECatalog;

public partial class Profil : ContentPage
{
    public ServiciuAutentificareStudent ServiciuAuth { get; set; } = new ServiciuAutentificareStudent();
    Student studentAutentificat;
    public Profil()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        if (studentAutentificat == null)
        {
            studentAutentificat = new Student();
            studentAutentificat = await ServiciuAutentificareStudent.PreiaUtilizator();
            App.DaoStudent.AdaugaStudent(studentAutentificat);
            
            NameLabel.Text = "Nume: " + studentAutentificat.NumeUtilizator;
            Image.Source = studentAutentificat.ImagineProfil;
            YearLabel.Text = "An studiu: " + studentAutentificat.AnStudiu;
            GroupLabel.Text = "Grupa: " + studentAutentificat.Grupa;
            SeriesLabel.Text = "Seria: " + studentAutentificat.Seria;
            FinanceLabel.Text = "Forma finantare: " + studentAutentificat.FormaFinantare;
        }
    }
}