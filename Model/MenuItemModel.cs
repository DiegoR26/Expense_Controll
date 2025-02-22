
namespace ExpenseControll.Model
{
    public class MenuItemModel
    {
        public string ButtonText { get; set; } = string.Empty;

        public int? FontSize { get; set; }
        public string LabelText { get; set; } = string.Empty;
        public Command? Command { get; set; }


    }
}
