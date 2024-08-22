
using Model.Enums;
using SQLite;

namespace Model
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public ECurrency Currency { get; set; }

    }
}
