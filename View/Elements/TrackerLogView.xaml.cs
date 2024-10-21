namespace ExpenseControll.View.Elements;

public partial class TrackerLogView : ContentView
{ 
	public TrackerLogView()
	{
		InitializeComponent();

	}

	public TrackerLogView(string name, double rvalue, double evalue)
	{
        InitializeComponent();

        LogName.Text = name;
		LogRealValue.Text = rvalue.ToString();
		LogExpectedValue.Text = evalue.ToString();

	}



}