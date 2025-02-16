using ExpenseControll.View.Elements;
using ExpenseControll.Model;
using System.Globalization;
namespace ExpenseControll.View.Pages;

public partial class TransactionEditorPage : ContentPage
{
    List <string> accounts = ["Nubank", "Inter", "Itaú"];
    List <string> categories = ["Mercado", "Supérfluo", "Contas da casa", "transporte", "Comer fora"];
    public TransactionEditorPage()
	{
		InitializeComponent();
        InitializeMenu();
        MonthPickerHandler();
        SetFlowToInput();
        AccountPicker.ItemsSource = accounts;
        CategoryPicker.ItemsSource = categories;





    }

    private void InitializeMenu()
    {

        var menuItem = new HorizontalScrollableMenu(new List<MenuItemModel>
            {
                new MenuItemModel { ButtonText = "\uf02e", LabelText = "Favorito 1" },
                new MenuItemModel { ButtonText = "\uf02e", LabelText = "Favorito 2" },
                new MenuItemModel { ButtonText = "\uf02e", LabelText = "Favorito 3" },
                new MenuItemModel { ButtonText = "\uf02e", LabelText = "Favorito 4" },
                new MenuItemModel { ButtonText = "\uf02e", LabelText = "Favorito 5" },
                new MenuItemModel { ButtonText = "\uf02e", LabelText = "Favorito 6" },
                new MenuItemModel { ButtonText = "\uf02e", LabelText = "Favorito 7" },
                new MenuItemModel { ButtonText = "\uf02e", LabelText = "Favorito 8" },
                new MenuItemModel { ButtonText = "\uf02e", LabelText = "Favorito 9" },
                new MenuItemModel { ButtonText = "\uf02e", LabelText = "Favorito 10" }
              
            });
        ScrollableMenuFrame.Content = new HorizontalScrollableMenu(menuItem.MenuItems.ToList());


    }


    #region value handler
    private void OnEntryChanged(object sender, TextChangedEventArgs e) 
    {
        var entry = sender as Entry; //sender is the object that triggered the action. If sender is null it will store null in entry instead of triggering an error
        if (entry == null || string.IsNullOrWhiteSpace(entry.Text)) return;//verify if the sender is an Entry type. If it's null, it has nothing to do so it will it'll stop the function here;
        var value = new string(entry.Text.Where(char.IsDigit).ToArray());
        /*It will filter the entry, keeping only numbers. 
         * "filter the text in entry, where the char is a digit and convert it into an array.
         * the char.IsDigit returns true only if the character is a number between 0 and 9
         */
        value = value.TrimStart('0');//It'll remove the zeros from the beginning of the number

        if (string.IsNullOrEmpty(value))
        {
            value = "0";
        }

        if (value.Length > 2)
        {
            value = value.Insert(value.Length - 2, ",");
            for (int i = value.Length - 6; i > 0; i = i - 3)
            {
                value = value.Insert(i, ".");
            }


        }
        else if (value.Length == 2)
        {
            value = "0," + value;

        }
        else if (value.Length == 1)
        {
            value = "0,0" + value;

        }
        entry.Text = value;




    }



    #endregion

    private void MonthPickerHandler()
    {
        var culture = new CultureInfo("pt-BR");
        var ptBrMonthList = culture.DateTimeFormat.MonthNames.Take(12).ToList();
        MonthPicker.ItemsSource = ptBrMonthList;
        MonthPicker.SelectedIndex = DateTime.Now.Month - 1; //current month selected

    }



    #region switch button

    private void FlowButton(object sender, EventArgs e)
    {


        if (sender is Button button)
        {
            string buttonId = button.StyleId; 
            if(buttonId == "0")
            {
                SetFlowToInput();


            }
            else if (buttonId == "1")

            {
                SetFlowToOutput();


            }
        }



    }

    private void SetFlowToInput()
    {
        InputFlowsButton.Shadow.Opacity = 0.5F;
        InputFlowsButton.Background = new SolidColorBrush(Color.FromArgb("#1f1f1f"));
        OutputFlowsButton.Shadow.Opacity = 0;
        OutputFlowsButton.Background = new SolidColorBrush(Color.FromArgb("#404040"));
    }
    private void SetFlowToOutput()
    {
        InputFlowsButton.Shadow.Opacity = 0;
        InputFlowsButton.Background = new SolidColorBrush(Color.FromArgb("#404040"));
        OutputFlowsButton.Shadow.Opacity = 0.5F;
        OutputFlowsButton.Background = new SolidColorBrush(Color.FromArgb("#1f1f1f"));
    }

    #endregion

    public async void CloseModalButton (object sender, EventArgs e)
	{
		await Navigation.PopModalAsync();
	}


}
