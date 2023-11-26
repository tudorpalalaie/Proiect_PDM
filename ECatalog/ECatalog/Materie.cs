using SQLite;

namespace ECatalog
{
    [Table("materie")]
    public class Materie
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
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
    }
}
