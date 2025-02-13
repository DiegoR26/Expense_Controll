namespace ExpenseControll.View.Elements
{
    public partial class HorizontalScrollButton : ContentView
    {
        public static readonly BindableProperty ButtonTextProperty =
            BindableProperty.Create(nameof(ButtonText), typeof(string), typeof(HorizontalScrollButton), string.Empty, propertyChanged: OnButtonTextChanged);

        public static readonly BindableProperty LabelTextProperty =
            BindableProperty.Create(nameof(LabelText), typeof(string), typeof(HorizontalScrollButton), string.Empty);

        public string ButtonText
        {
            get => (string)GetValue(ButtonTextProperty);
            set => SetValue(ButtonTextProperty, value);
        }

        public string LabelText
        {
            get => (string)GetValue(LabelTextProperty);
            set => SetValue(LabelTextProperty, value);
        }

        public HorizontalScrollButton()
        {
            InitializeComponent();
        }

        private static void OnButtonTextChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (HorizontalScrollButton)bindable;
            if (control.Content is VerticalStackLayout stack)
            {
                if (stack.Children[0] is Button button)
                {
                    button.Text = (string)newValue;
                }
            }
        }
    }
}