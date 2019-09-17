using System.ComponentModel;
using Xamarin.Forms;

namespace App1
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage(string _yourSymbol, string _enemySymbol)
        {          
            InitializeComponent();
            BindingContext = new CrossZerosVM(_yourSymbol, _enemySymbol);
        }
    }
}
