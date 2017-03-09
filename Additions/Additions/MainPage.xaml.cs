using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Additions
{
    public partial class MainPage : ContentPage
    {
        public static readonly BindableProperty TotalValueProperty = BindableProperty.Create(nameof(TotalValue), typeof(int), typeof(MainPage), 0);

        public int TotalValue
        {
            get { return (int)GetValue(TotalValueProperty); }
            set { SetValue(TotalValueProperty, value); }
        }

        public MainPage()
        {
            InitializeComponent();

            TotalValue = FirstNumber.NumberValue + SecondNumber.NumberValue;

            BindingContext = this;
        }

        private void OnNumberValueChanged(object sender, EventArgs e)
        {
            TotalValue = FirstNumber.NumberValue + SecondNumber.NumberValue;
        }
    }
}
