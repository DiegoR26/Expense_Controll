using ExpenseControll.View.Elements;
using ExpenseControll.View.Pages;
using ExpenseControll.Model;
using System.Globalization;
using Microsoft.Maui.Controls;

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
                new MenuItemModel { ButtonText = "\uf4c0", FontSize = 35, LabelText = "Movimentações",  Command = new Command(() => MenuButtonClicked(0)) },
                new MenuItemModel { ButtonText = "\uf515", FontSize = 35, LabelText = "Balanço",  Command = new Command(() => MenuButtonClicked(1))  },
                new MenuItemModel { ButtonText = "\ue528", FontSize = 35, LabelText = "Lançamentos",  Command = new Command(() => MenuButtonClicked(2)) },
                new MenuItemModel { ButtonText = "\uf54a", FontSize = 35, LabelText = "Ajustes",  Command = new Command(() => MenuButtonClicked(3)) }
            });
            ScrollableMenuFrame.Content = new HorizontalScrollableMenu(menuItem.MenuItems.ToList());
        }
        private void MenuButtonClicked(int id)
        {
            switch (id)
            {
                case 0:
                    {
                        MainContentFrame.Content = new ExpensesView();
                        var menuItem = new HorizontalScrollableMenu(new List<MenuItemModel>
                        {
                            new MenuItemModel { ButtonText = "\uf30a", FontSize = 35, LabelText = "Voltar",  Command = new Command(() => MenuButtonClicked(9)) },
                            new MenuItemModel { ButtonText = $"R$50", FontSize = 10, LabelText = "Salário",  Command = new Command(() => MenuButtonClicked(1))  },
                            new MenuItemModel { ButtonText = "R$50,50", FontSize = 10, LabelText = "Vale",  Command = new Command(() => MenuButtonClicked(2))  },
                            new MenuItemModel { ButtonText = "R$528.00", FontSize = 10, LabelText = "Extras",  Command = new Command(() => MenuButtonClicked(3)) },
                            
                        });
                        ScrollableMenuFrame.Content = new HorizontalScrollableMenu(menuItem.MenuItems.ToList());


                    }
                    break;
                default:
                    InitializeMenu();
                    InitializeMainFrame();

                    break;
            }

            

          

        }

        private void InitializeMainFrame()
        {
            MainContentFrame.Content = new MainFrame();
        }

        private async void AddTransactionButton (object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TransactionEditorPage());

        }

        private void MonthButton_Clicked(object sender, EventArgs e)
        {    
            var culture = new CultureInfo("pt-BR");
            var ptBrMonthList = culture.DateTimeFormat.MonthNames.Take(12).ToList();
            //MonthPicker.ItemsSource = ptBrMonthList;
            //MonthPicker.SelectedIndex = DateTime.Now.Month - 1; //current month selected

        }

    
    }

}
