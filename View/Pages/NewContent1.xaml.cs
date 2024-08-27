namespace ExpenseControll.View.Pages;

public partial class NewContent1 : ContentView
{
	private Frame _container;
	public NewContent1(Frame caralho)
	{
		InitializeComponent();
		_container = caralho;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		_container.Content = null;
    }
}