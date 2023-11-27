﻿namespace ECatalog
{
    public partial class App : Application
    {
        public static DaoMaterii DaoMaterii { get; private set; }
        public static DaoStudent DaoStudent { get; private set; }


        public App(DaoMaterii daoMaterii, DaoStudent daoStudent)
        {
            InitializeComponent();

            MainPage = new AppShell();

            DaoMaterii = daoMaterii;
            DaoStudent = daoStudent;
        }
    }
}
