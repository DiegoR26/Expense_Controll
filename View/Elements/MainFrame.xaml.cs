using System.Collections.ObjectModel;
using System.Diagnostics;


namespace ExpenseControll.View.Elements;

public partial class MainFrame : ContentView
{
    private ObservableCollection<Transactions> _transactions;
	public MainFrame()
	{
		InitializeComponent();
        _transactions = new ObservableCollection<Transactions>
        {
           new Transactions { Amount = 50.00, Date = "15/12/2024", Description = "Transporte" },
            new Transactions { Amount = 150.00, Date = "14/12/2024", Description = "Comida" },
            new Transactions { Amount = 45.00, Date = "14/12/2024", Description = "Supérfluo" },
            new Transactions { Amount = 17.00, Date = "05/12/2024", Description = "Comida" },
            new Transactions { Amount = 212.00, Date = "05/12/2024", Description = "Contas casa" },
            new Transactions { Amount = 50.00, Date = "15/12/2024", Description = "Transporte" },
            new Transactions { Amount = 150.00, Date = "14/12/2024", Description = "Comida" },
            new Transactions { Amount = 45.00, Date = "14/12/2024", Description = "Supérfluo" },
            new Transactions { Amount = 17.00, Date = "05/12/2024", Description = "Comida" },
            new Transactions { Amount = 212.00, Date = "05/12/2024", Description = "Contas casa" },
            new Transactions { Amount = 50.00, Date = "15/12/2024", Description = "Transporte" },
            new Transactions { Amount = 150.00, Date = "14/12/2024", Description = "Comida" },
            new Transactions { Amount = 45.00, Date = "14/12/2024", Description = "Supérfluo" },
            new Transactions { Amount = 17.00, Date = "05/12/2024", Description = "Comida" },
            new Transactions { Amount = 212.00, Date = "05/12/2024", Description = "Contas casa" },
            new Transactions { Amount = 50.00, Date = "15/12/2024", Description = "Transporte" },
            new Transactions { Amount = 150.00, Date = "14/12/2024", Description = "Comida" },
            new Transactions { Amount = 45.00, Date = "14/12/2024", Description = "Supérfluo" },
            new Transactions { Amount = 17.00, Date = "05/12/2024", Description = "Comida" },
            new Transactions { Amount = 212.00, Date = "05/12/2024", Description = "Contas casa" },
            new Transactions { Amount = 50.00, Date = "15/12/2024", Description = "Transporte" },
            new Transactions { Amount = 150.00, Date = "14/12/2024", Description = "Comida" },
            new Transactions { Amount = 45.00, Date = "14/12/2024", Description = "Supérfluo" },
            new Transactions { Amount = 17.00, Date = "05/12/2024", Description = "Comida" },
            new Transactions { Amount = 212.00, Date = "05/12/2024", Description = "Contas casa" },
            new Transactions { Amount = 50.00, Date = "15/12/2024", Description = "Transporte" },
            new Transactions { Amount = 150.00, Date = "14/12/2024", Description = "Comida" },
            new Transactions { Amount = 45.00, Date = "14/12/2024", Description = "Supérfluo" },
            new Transactions { Amount = 17.00, Date = "05/12/2024", Description = "Comida" },
            new Transactions { Amount = 212.00, Date = "05/12/2024", Description = "Contas casa" },

        };
        TransactionList.ItemsSource = _transactions;

    }



    public class Transactions
    {
        public double? Amount { get; set; }
        public String? Date { get; set; }
        public String? Description { get; set; }
    }
}





