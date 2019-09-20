using Acr.UserDialogs;
using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1
{
    public class CrossZerosVM : INotifyPropertyChanged
    {
        public CrossZerosVM(string _yourSymbol,string _enemySymbol)
        {
            Press = new Command(PressButton);
            Reset_ = new Command(Reset);
            YourSymbol = _yourSymbol;
            EnemySymbol = _enemySymbol;
        }
        public ICommand Press { get; }
        public ICommand Reset_ { get; }
        public string YourSymbol { get; set; }
        public string EnemySymbol { get; set; }
        private string _b_00;
        public string B_00
        {
            get => _b_00;
            set
            {
                _b_00 = value;
                OnPropertyChanged("B_00");
            }
        }
        private string _b_01;
        public string B_01
        {
            get => _b_01;
            set
            {
                _b_01 = value;
                OnPropertyChanged("B_01");
            }
        }
        private string _b_02;
        public string B_02
        {
            get => _b_02;
            set
            {
                _b_02 = value;
                OnPropertyChanged("B_02");
            }
        }
        private string _b_10;
        public string B_10
        {
            get => _b_10;
            set
            {
                _b_10 = value;
                OnPropertyChanged("B_10");
            }
        }
        private string _b_11;
        public string B_11
        {
            get => _b_11;
            set
            {
                _b_11 = value;
                OnPropertyChanged("B_11");
            }
        }
        private string _b_12;
        public string B_12
        {
            get => _b_12;
            set
            {
                _b_12 = value;
                OnPropertyChanged("B_12");
            }
        }
        private string _b_20;
        public string B_20
        {
            get => _b_20;
            set
            {
                _b_20 = value;
                OnPropertyChanged("B_20");
            }
        }
        private string _b_21;
        public string B_21
        {
            get => _b_21;
            set
            {
                _b_21 = value;
                OnPropertyChanged("B_21");
            }
        }
        private string _b_22;
        public string B_22
        {
            get => _b_22;
            set
            {
                _b_22 = value;
                OnPropertyChanged("B_22");
            }
        }
        public void PressButton(object sender)
        {
            string but = sender as string;
            bool isChoise = false;
            while (!isChoise)
            {
                switch (but)
                {
                    case "_00":
                        if (string.IsNullOrEmpty(B_00))
                        {
                            B_00 = YourSymbol;
                            isChoise = true;
                        }
                        else
                        {
                            return;
                        }
                        break;
                    case "_01":
                        if (string.IsNullOrEmpty(B_01))
                        {
                            B_01 = YourSymbol;
                            isChoise = true;
                        }
                        else
                        {
                            return;
                        }
                        break;
                    case "_02":
                        if (string.IsNullOrEmpty(B_02))
                        {
                            B_02 = YourSymbol;
                            isChoise = true;
                        }
                        else
                        {
                            return;
                        }
                        break;
                    case "_10":
                        if (string.IsNullOrEmpty(B_10))
                        {
                            B_10 = YourSymbol;
                            isChoise = true;
                        }
                        else
                        {
                            return;
                        }
                        break;
                    case "_11":
                        if (string.IsNullOrEmpty(B_11))
                        {
                            B_11 = YourSymbol;
                            isChoise = true;
                        }
                        else
                        {
                            return;
                        }
                        break;
                    case "_12":
                        if (string.IsNullOrEmpty(B_12))
                        {
                            B_12 = YourSymbol;
                            isChoise = true;
                        }
                        else
                        {
                            return;
                        }
                        break;
                    case "_20":
                        if (string.IsNullOrEmpty(B_20))
                        {
                            B_20 = YourSymbol;
                            isChoise = true;
                        }
                        else
                        {
                            return;
                        }
                        break;
                    case "_21":
                        if (string.IsNullOrEmpty(B_21))
                        {
                            B_21 = YourSymbol;
                            isChoise = true;
                        }
                        else
                        {
                            return;
                        }
                        break;
                    case "_22":
                        if (string.IsNullOrEmpty(B_22))
                        {
                            B_22 = YourSymbol;
                            isChoise = true;
                        }
                        else
                        {
                            return;
                        }
                        break;
                }
            }
            if (string.IsNullOrEmpty(B_00) || string.IsNullOrEmpty(B_01) || string.IsNullOrEmpty(B_02) ||
                string.IsNullOrEmpty(B_10) || string.IsNullOrEmpty(B_11) || string.IsNullOrEmpty(B_12) ||
                string.IsNullOrEmpty(B_20) || string.IsNullOrEmpty(B_21) || string.IsNullOrEmpty(B_22))
            {
                if (!SearchWinner())
                {
                    SetRandomZero();
                }
            }
            else
            {
                SearchWinner();
            }

        }
        public void Reset()
        {
            B_00 = ""; B_01 = ""; B_02 = "";
            B_10 = ""; B_11 = ""; B_12 = "";
            B_20 = ""; B_21 = ""; B_22 = "";
        }
        public bool SearchWinner()
        {
            string[] colums =
            {
                string.Format(B_00+B_10+B_20),
                string.Format(B_01+B_11+B_21),
                string.Format(B_02+B_12+B_22),
            };
            string[] rows =
            {
                string.Format(B_00+B_01+B_02),
                string.Format(B_10+B_11+B_12),
                string.Format(B_20+B_21+B_22)
            };
            string[] diags =
            {
                string.Format(B_00+B_11+B_22),
                string.Format(B_02+B_11+B_20),
                string.Format("1")
            };
            for (int i = 0; i <= 2; i++)
            {
                if (rows[i].Where(x => x == 'X').Count() == 3)
                {
                    UserDialogs.Instance.Alert("Переможець Х", "Кінець гри");
                    Reset();
                    return true;
                }
                else if (rows[i].Where(x => x == 'O').Count() == 3)
                {
                    UserDialogs.Instance.Alert("Переможець О", "Кінець гри");
                    Reset();
                    return true;
                }
                if (colums[i].Where(x => x == 'X').Count() == 3)
                {
                    UserDialogs.Instance.Alert("Переможець Х", "Кінець гри");
                    Reset();
                    return true;
                }
                else if (colums[i].Where(x => x == 'O').Count() == 3)
                {
                    UserDialogs.Instance.Alert("Переможець О", "Кінець гри");
                    Reset();
                    return true;
                }
                if (diags[i].Where(x => x == 'X').Count() == 3)
                {
                    UserDialogs.Instance.Alert("Переможець Х", "Кінець гри");
                    Reset();
                    return true;
                }
                else if (diags[i].Where(x => x == 'O').Count() == 3)
                {
                    UserDialogs.Instance.Alert("Переможець О", "Кінець гри");
                    Reset();
                    return true;
                }
            }
            return false;
        }
        public async void SetRandomZero()
        {
            Random r = new Random();
            bool isZero = false;
            await Task.Run(() =>
            {
                UserDialogs.Instance.ShowLoading("Loading", MaskType.Black);
            });
            await Task.Delay(1500);
            while (!isZero)
            {
                int point = r.Next(0, 8);
                switch (point)
                {
                    case 0:
                        if (string.IsNullOrEmpty(B_00))
                        {
                            B_00 = EnemySymbol;
                            isZero = true;
                            UserDialogs.Instance.HideLoading();
                        }
                        break;
                    case 1:
                        if (string.IsNullOrEmpty(B_01))
                        {
                            B_01 = EnemySymbol;
                            isZero = true;
                            UserDialogs.Instance.HideLoading();
                        }
                        break;
                    case 2:
                        if (string.IsNullOrEmpty(B_02))
                        {
                            B_02 = EnemySymbol;
                            isZero = true;
                            UserDialogs.Instance.HideLoading();
                        }
                        break;
                    case 3:
                        if (string.IsNullOrEmpty(B_10))
                        {
                            B_10 = EnemySymbol;
                            isZero = true;
                            UserDialogs.Instance.HideLoading();
                        }
                        break;
                    case 4:
                        if (string.IsNullOrEmpty(B_11))
                        {
                            B_11 = EnemySymbol;
                            isZero = true;
                            UserDialogs.Instance.HideLoading();
                        }
                        break;
                    case 5:
                        if (string.IsNullOrEmpty(B_12))
                        {
                            B_12 = EnemySymbol;
                            isZero = true;
                            UserDialogs.Instance.HideLoading();
                        }
                        break;
                    case 6:
                        if (string.IsNullOrEmpty(B_20))
                        {
                            B_20 = EnemySymbol;
                            isZero = true;
                            UserDialogs.Instance.HideLoading();
                        }
                        break;
                    case 7:
                        if (string.IsNullOrEmpty(B_21))
                        {
                            B_21 = EnemySymbol;
                            isZero = true;
                            UserDialogs.Instance.HideLoading();
                        }
                        break;
                    case 8:
                        if (string.IsNullOrEmpty(B_22))
                        {
                            B_22 = EnemySymbol;
                            isZero = true;
                            UserDialogs.Instance.HideLoading();
                        }
                        break;
                }
            }
            SearchWinner();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}