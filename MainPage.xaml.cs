using ExpenseControll.View.Elements;

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
            ScrollableMenuFrame.Content = new HorizontalScrollableMenu();
        }
        private void InitializeMainFrame()
        {
            MainContentFrame.Content = new MainFrame();
        }
    }

}
