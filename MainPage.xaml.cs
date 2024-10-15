using Data;
using Model;
using ExpenseControll.View.Pages;

namespace ExpenseControll
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }

        private void MonthSelector (object sender, EventArgs e)
        {
            DisplayAlert("Alert", "O botão foi clicado!", "OK");


        }

       


        private void Button_Clicked(object sender, EventArgs e)
        {
            ContentFrame.Content = new NewContent1(ContentFrame);
        }
        private void ExpenseTrackerClicked(object sender, EventArgs e)
        {
            ContentFrame.Content = new ExpenseTracker(ContentFrame);
        }


    }

}
