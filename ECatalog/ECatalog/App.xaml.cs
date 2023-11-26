namespace ECatalog
{
    public partial class App : Application
    {
        public static DaoMaterii DaoMaterii { get; private set; }

        public App(DaoMaterii daoMaterii)
        {
            InitializeComponent();

            MainPage = new AppShell();

            DaoMaterii = daoMaterii;
        }
    }
}
