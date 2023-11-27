using SQLite;

namespace ECatalog
{
    [Table("student")]
    public class Student
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }
        public string NumeUtilizator { get; set; }
        public string ImagineProfil { get; set; }
        public int AnStudiu { get; set; }
        public string Grupa { get; set; }
        public string Seria { get; set; }
        public string FormaFinantare { get; set; }
    }
}
