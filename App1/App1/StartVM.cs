using System.Windows.Input;
using Xamarin.Forms;

namespace App1
{
    public class StartVM
    {
        public StartVM(INavigation navigation)
        {
            Navigation = navigation;
            Play = new Command(ToPlayPage);
        }
        public INavigation Navigation { get; }
        public ICommand Play { get;}
        public void ToPlayPage(object sender)
        {
            string whoI = sender as string;
            if (whoI == "X")
            {
                Navigation.PushAsync(new MainPage("X", "O"));
            }
            else
            {
                Navigation.PushAsync(new MainPage("O", "X"));
            }
        }
    }
}
