using System;
using Xamarin.Forms;

namespace Additions
{
    public delegate void NumberValueChangedEventHandler(object sender, EventArgs e);

    public partial class NumberView : StackLayout
    {
        public event EventHandler NumberValueChanged;

        public static readonly BindableProperty NumberValueProperty = BindableProperty.Create(nameof(NumberValue), typeof(int), typeof(NumberView), 1);

        public int NumberValue
        {
            get { return (int)GetValue(NumberValueProperty); }
            set { SetValue(NumberValueProperty, value); }
        }

        public NumberView()
        {
            InitializeComponent();

            NumberValue = 1;
            BindingContext = this;
        }

        private void Up_Button_Clicked(object sender, EventArgs e)
        {
            NumberValue++;

            OnNumberValueChanged(EventArgs.Empty);
        }

        private void Down_Button_Clicked(object sender, EventArgs e)
        {
            NumberValue--;
            if (NumberValue <= 0)
                NumberValue = 1;

            OnNumberValueChanged(EventArgs.Empty);
        }

        protected virtual void OnNumberValueChanged(EventArgs e)
        {
            if (NumberValueChanged != null)
                NumberValueChanged(this, e);
        }
    }
}
