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

            Image.Source = studentAutentificat.ImagineProfil;
            UsernameLabel.Text = "Username: " + studentAutentificat.NumeUtilizator;
            NameLabel.Text = "Nume: " + studentAutentificat.Nume;
            EmailLabel.Text = "Email: " + studentAutentificat.Email;
            YearLabel.Text = "An studiu: " + studentAutentificat.AnStudiu;
            SeriesLabel.Text = "Seria: " + studentAutentificat.Seria;
            GroupLabel.Text = "Grupa: " + studentAutentificat.Grupa;
        }
    }
}