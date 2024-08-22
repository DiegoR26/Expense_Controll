
using Model.Enums;
using SQLite;

namespace Model
{
    public class Favorite
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public ETransactionType TransactionType { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public string? Description { get; set; }

        [Ignore]
        public Account Account { get; set; }

        [Ignore]
        public Category? Category { get; set; }

        [Ignore]
        public User User { get; set; }

        public int AccountId { get; set; }
        public int? CategoryId { get; set; }
        public int UserId { get; set; }

    }
}
