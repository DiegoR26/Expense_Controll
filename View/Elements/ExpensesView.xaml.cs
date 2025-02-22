using System.Collections.ObjectModel;

namespace ExpenseControll.View.Elements;

public partial class ExpensesView : ContentView
{
	private ObservableCollection<ExpensesAndExpectedExpenses> _expense;
	public ExpensesView()
	{
		InitializeComponent();

		_expense = new ObservableCollection<ExpensesAndExpectedExpenses>
		{
            new ExpensesAndExpectedExpenses {ExpenseName = "Comida", ExpenseAmount = 814.97, ExpectedExpense = 848.4},
			new ExpensesAndExpectedExpenses {ExpenseName = "Transporte", ExpenseAmount = 1099.39, ExpectedExpense = 747.54},
			new ExpensesAndExpectedExpenses {ExpenseName = "Aluguel", ExpenseAmount = 519.24, ExpectedExpense = 446.66},
			new ExpensesAndExpectedExpenses {ExpenseName = "Contas casa", ExpenseAmount = 429.72, ExpectedExpense = 625.31},
			new ExpensesAndExpectedExpenses {ExpenseName = "Supérfluo", ExpenseAmount = 1355.85, ExpectedExpense = 164.87},
			new ExpensesAndExpectedExpenses {ExpenseName = "Comer fora", ExpenseAmount = 271.16, ExpectedExpense = 936.8},
			new ExpensesAndExpectedExpenses {ExpenseName = "Investimento", ExpenseAmount = 1301.53, ExpectedExpense = 386.1},
			new ExpensesAndExpectedExpenses {ExpenseName = "Medicamento", ExpenseAmount = 51.47, ExpectedExpense = 102.55},
			new ExpensesAndExpectedExpenses {ExpenseName = "Condomínio", ExpenseAmount = 1281.71, ExpectedExpense = 969.48},
			new ExpensesAndExpectedExpenses {ExpenseName = "Curso", ExpenseAmount = 68.87, ExpectedExpense = 563.69},

        };
		ExpenseList.ItemsSource = _expense;
	}




	public class ExpensesAndExpectedExpenses()
	{
		public String ExpenseName { get; set; } = string.Empty;
		public double ExpenseAmount { get; set; }
		public double ExpectedExpense { get; set; }

	}









}