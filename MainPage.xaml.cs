using ExpenseControll.View.Elements;
using ExpenseControll.View.Pages;
using ExpenseControll.Model;

namespace ExpenseControll

{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            InitializeMenu();
            InitializeMainFrame();

        }

    
        private void InitializeMenu ()
        {
            var menuItem = new HorizontalScrollableMenu(new List<MenuItemModel>
            {
                new MenuItemModel { ButtonText = "\uf4c0", LabelText = "Movimentações" },
                new MenuItemModel { ButtonText = "\uf515", LabelText = "Balanço" },
                new MenuItemModel { ButtonText = "\ue528", LabelText = "Lançamentos" },
                new MenuItemModel { ButtonText = "\uf54a", LabelText = "Ajustes" }
            });
            ScrollableMenuFrame.Content = new HorizontalScrollableMenu(menuItem.MenuItems.ToList());
        }

        private void InitializeMainFrame()
        {
            MainContentFrame.Content = new MainFrame();
        }

        private async void AddTransactionButton (object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TransactionEditorPage());

        }


    }

}
