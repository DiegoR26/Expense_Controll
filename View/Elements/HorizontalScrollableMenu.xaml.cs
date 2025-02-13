using System.Collections.ObjectModel;

namespace ExpenseControll.View.Elements
{
    public partial class HorizontalScrollableMenu : ContentView
    {
        public ObservableCollection<MenuItemModel> MenuItems { get; set; }

        public HorizontalScrollableMenu()
        {
            InitializeComponent();

            MenuItems = new ObservableCollection<MenuItemModel>
            {
                new MenuItemModel { ButtonText = "\uf4c0", LabelText = "Movimenta��es" },
                new MenuItemModel { ButtonText = "\uf515", LabelText = "Balan�o" },
                new MenuItemModel { ButtonText = "\ue528", LabelText = "Lan�amentos" },
                new MenuItemModel { ButtonText = "\uf54a", LabelText = "Ajustes" }
            };


            BindingContext = this;
        }

        public class MenuItemModel
        {
            public string ButtonText { get; set; }
            public string LabelText { get; set; }
        }
    }
}
