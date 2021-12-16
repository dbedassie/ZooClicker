using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Windows.Input;
using ZooClicker.Models;

namespace ZooClicker.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        #region Habitat Instantiation
        LionHabitat lion;
        FrogHabitat frog;
        ChimpHabitat chimp;
        GiraffeHabitat giraffe;
        #endregion

        #region Command Variables
        public ICommand LionCommand { get; set; }
        public ICommand ChimpCommand { get; set; }
        public ICommand GiraffeCommand { get; set; }
        public ICommand FrogCommand { get; set; }

        public ICommand LionUpgrade { get; set; }
        public ICommand ChimpUpgrade { get; set; }
        public ICommand GiraffeUpgrade { get; set; }
        public ICommand FrogUpgrade { get; set; }

        public ICommand LuckyCommand { get; set; }

        public ICommand UpgradesCommand { get; set; }
        #endregion

        #region Binding Helper Variables / Properties

        private int _donations;

        private int frogCost;
        private int giraffeCost;
        private int chimpCost;
        private int lionCost;

        private int frogLevel;
        private int giraffeLevel;
        private int chimpLevel;
        private int lionLevel;

        public int Donations
        {
            get => _donations;
            set
            {
                _donations = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Donations"));
            }
        }

        public int FrogLevel
        {
            get => frogLevel;
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FrogLevel"));
            }
        }
        public int GiraffeLevel
        {
            get => giraffeLevel;
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GiraffeLevel"));
            }
        }
        public int ChimpLevel
        {
            get => chimpLevel;
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChimpLevel"));
            }
        }
        public int LionLevel
        {
            get => lionLevel;
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LionLevel"));
            }
        }

        public int FrogCost
        {
            get => frogCost;
            set
            {
                frogCost = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FrogCost"));
            }
        }
        public int GiraffeCost
        {
            get => giraffeCost;
            set
            {
                giraffeCost = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GiraffeCost"));
            }
        }
        public int ChimpCost
        {
            get => chimpCost;
            set
            {
                chimpCost = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChimpCost"));
            }
        }
        public int LionCost
        {
            get => lionCost;
            set
            {
                lionCost = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LionCost"));
            }
        }

        #endregion

        public INavigation Navigation { get; set; }

        public MainPageViewModel(INavigation nav)
        {
            Navigation = nav;
            
            CreateHabitats();
            _donations = 100;

            #region Command Definitions

            LuckyCommand = new Command(() =>
            {
                Donations += 1000;
                LuckyCommand.CanExecute(false);
                
            });

            LionCommand = new Command(() =>
            {
                Donations += lion.Donations;
            });

            ChimpCommand = new Command(() =>
            {
                Donations += chimp.Donations;
            });

            GiraffeCommand = new Command(() =>
            {
                Donations += giraffe.Donations;
            });

            FrogCommand = new Command(() =>
            {
                Donations += frog.Donations;
            });

            FrogUpgrade = new Command(() =>
            {
                if(frog.CheckIfBuy(Donations))
                {
                    Donations -= frog.Cost;
                    FrogCost = frog.LevelUp();
                    frogLevel++;
                }
                else
                {
                    App.Current.MainPage.DisplayAlert("Oh No!", "You need more donations to upgrade this!", "Ok");
                }
            });

            GiraffeUpgrade = new Command(() =>
            {
                if (giraffe.CheckIfBuy(Donations))
                {
                    Donations -= giraffe.Cost;
                    GiraffeCost = giraffe.LevelUp();
                    giraffeLevel++;
                }
                else
                {
                    App.Current.MainPage.DisplayAlert("Oh No!", "You need more donations to upgrade this!", "Ok");
                }
            });

            ChimpUpgrade = new Command(() =>
            {
                if (chimp.CheckIfBuy(Donations))
                {
                    Donations -= chimp.Cost;
                    ChimpCost = chimp.LevelUp();
                    chimpLevel++;
                }
                else
                {
                    App.Current.MainPage.DisplayAlert("Oh No!", "You need more donations to upgrade this!", "Ok");
                }
            });

            LionUpgrade = new Command(() =>
            {
                if (lion.CheckIfBuy(Donations))
                {
                    Donations -= lion.Cost;
                    LionCost = lion.LevelUp();
                    lionLevel++;
                }
                else
                {
                    App.Current.MainPage.DisplayAlert("Oh No!", "You need more donations to upgrade this!", "Ok");
                }
            });

            UpgradesCommand = new Command(() =>
            {
                Navigation.PushAsync(new UpgradesPage(this));
            });

            #endregion
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void CreateHabitats()
        {
            lion = new LionHabitat();
            frog = new FrogHabitat();
            chimp = new ChimpHabitat();
            giraffe = new GiraffeHabitat();

            FrogCost = frog.Cost;
            GiraffeCost = giraffe.Cost;
            ChimpCost = chimp.Cost;
            LionCost = lion.Cost;

            FrogLevel = frog.Level;
            GiraffeLevel = giraffe.Level;
            ChimpLevel = chimp.Level;
            LionLevel = lion.Level;
        }

        #region Attempt to Create Lucky Donations

        #endregion
    }
}
