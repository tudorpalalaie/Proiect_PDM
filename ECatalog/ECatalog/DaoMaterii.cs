using SQLite;

namespace ECatalog
{
    public class DaoMaterii
    {
        string _dbPath;
        SQLiteConnection conn;
        
        public DaoMaterii(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Materie>();
        }

        public List<Materie> ObtineMaterii()
        {
            Init();
            return conn.Table<Materie>().ToList();
        }

        public void AdaugaMaterie(Materie materie)
        {
            conn = new SQLiteConnection(_dbPath);
            conn.Insert(materie);
        }

        public void StergeMaterie(int id)
        {
            conn = new SQLiteConnection(_dbPath);
            conn.Delete(new Materie { Id = id });
        }

        public int AdaugaListaMaterii(List<Materie> listaMaterii)
        {
            Init();
            return conn.InsertAll(listaMaterii);
        }

        public List<Materie> ObtineNumeleInregistrarilor()
        {
            conn = new SQLiteConnection(_dbPath);
            return conn.Query<Materie>("SELECT Nume FROM Materii");
        }

        public List<Materie> ObtineMaterieDupaNume(string nume)
        {
            conn = new SQLiteConnection(_dbPath);
            return conn.Query<Materie>("SELECT * FROM Materii WHERE Nume = ?", nume);
        }
    }
}
