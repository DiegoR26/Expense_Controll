namespace ExpenseControll.View.Pages;

public partial class ExpenseTracker : ContentView
{ 
	private Frame _container;
	public ExpenseTracker(Frame fr)
	{
		InitializeComponent();
		_container = fr;

	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        _container.Content = null;
    }


}