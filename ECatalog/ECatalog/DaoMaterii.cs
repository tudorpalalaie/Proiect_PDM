using SQLite;

namespace ECatalog
{
    public class DaoMaterii
    {
        SQLiteConnection conn;
        public DaoMaterii()
        {
            string caleBd = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Materii.db");
            conn = new SQLiteConnection(caleBd, false);
            conn.CreateTable<Materie>();
        }

        public int AdaugaMaterie(Materie materie)
        {
            return conn.Insert(materie);
        }

        public int AdaugaListaMaterii(List<Materie> listaMaterii)
        {
            return conn.InsertAll(listaMaterii);
        }

        public List<Materie> ObtineNumeleInregistrarilor()
        {

            return conn.Query<Materie>("SELECT Nume FROM Materii");
        }

        public List<Materie> ObtineMaterieDupaNume(string nume)
        {
            return conn.Query<Materie>("SELECT * FROM Materii WHERE Nume = ?", nume);
        }
    }
}
