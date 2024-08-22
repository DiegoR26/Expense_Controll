
using Model.Enums;
using SQLite;

namespace Model
{
    public class ExpectedExpense
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Ignore]
        public Category Category { get; set; }
        public decimal Value { get; set; }
        public DateTime CompetenceDate { get; set; }
        public EExpectedExpenseType ExpectedExpenseType { get; set; }

        public int CategoryId { get; set; }

    }
}
