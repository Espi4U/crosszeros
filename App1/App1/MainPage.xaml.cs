using System.ComponentModel;
using Xamarin.Forms;

namespace App1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage(string i, string u)
        {          
            InitializeComponent();
            BindingContext = new CrossZerosVM(i,u);
        }
    }
}
