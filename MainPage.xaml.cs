using Data;
using Model;

namespace ExpenseControll
{
    public partial class MainPage : ContentPage
    {

        private readonly TransactionService transactionService = new TransactionService();

        public MainPage()
        {
            InitializeComponent();

            LbTest.Text = transactionService.GetDBPath();

            Task.Run(async () => TransactionList.ItemsSource = await transactionService.GetAllAsync());

        }

        private async void BtTest_Clicked(object sender, EventArgs e)
        {
            await transactionService.InsertAsync(new Model.Transaction
            {
                TransactionType = 0,
                LogDate = DateTime.Now,
                CompetenceDate = DateTime.Now,
                Value = 0,
                Description = "Teste Descrição",
                AccountId = 0,
                CategoryId = 0,
                UserId = 0,

            });
        }
    }

}
