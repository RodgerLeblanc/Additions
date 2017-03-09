using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Additions
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Additions.MainPage();
        }
    }
}
