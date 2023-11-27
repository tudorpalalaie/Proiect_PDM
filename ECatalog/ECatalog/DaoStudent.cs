using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECatalog
{
    public class DaoStudent
    {
        string _dbPath;
        SQLiteConnection conn;

        public DaoStudent(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Student>();
        }

        public void AdaugaStudent(Student student)
        {
            Init();
            conn = new SQLiteConnection(_dbPath);
            conn.Insert(student);
        }
    }
}