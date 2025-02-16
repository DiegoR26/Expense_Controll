using System.Collections.ObjectModel;
using ExpenseControll.Model;

namespace ExpenseControll.View.Elements
{
    public partial class HorizontalScrollableMenu : ContentView
    {
        public ObservableCollection<MenuItemModel> MenuItems { get; set; }

        public HorizontalScrollableMenu(IEnumerable<MenuItemModel> items)
        {
            InitializeComponent();


            MenuItems = new ObservableCollection<MenuItemModel>(items);
           

            BindingContext = this;
        }

       
    }
}

