using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECatalog
{
    public class Materie
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nume { get; set; }
        public int NrCredite { get; set; }
        public int Nota { get; set; }

        public string Imagine
        {
            get
            {
                return (String.Concat(Nume.Where(c => !Char.IsWhiteSpace(c)))).ToLower() + ".png";
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
