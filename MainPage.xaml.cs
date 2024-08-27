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

        private void Button_Clicked(object sender, EventArgs e)
        {
            ContentFrame.Content = new NewContent1(ContentFrame);
        }
    }

}
