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
        private float _donations;

        public Dictionary<string, Habitat> Habitats { get; set; }
        public float Donations
        {
            get => _donations;
            set
            {
                _donations = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Donations"));
            }
        }

        public ICommand LionCommand { get; set; }
        public ICommand ChimpCommand { get; set; }
        public ICommand GiraffeCommand { get; set; }
        public ICommand FrogCommand { get; set; }


        public MainPageViewModel()
        {
            CreateHabitats();
            _donations = 100;

            LionCommand = new Command(() =>
            {
                Donations += Habitats["Lion"].Donations;
            });

            ChimpCommand = new Command(() =>
            {
                Donations += Habitats["Chimp"].Donations;
            });

            GiraffeCommand = new Command(() =>
            {
                Donations += Habitats["Giraffe"].Donations;
            });

            FrogCommand = new Command(() =>
            {
                Donations += Habitats["Frog"].Donations;
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void CreateHabitats()
        {
            Habitats = new Dictionary<string, Habitat>();
            LionHabitat lion = new LionHabitat();
            FrogHabitat frog = new FrogHabitat();
            ChimpHabitat chimp = new ChimpHabitat();
            GiraffeHabitat giraffe = new GiraffeHabitat();

            Habitats.Add(lion.Name, lion);
            Habitats.Add(frog.Name, frog);
            Habitats.Add(giraffe.Name, giraffe);
            Habitats.Add(chimp.Name, chimp);
        }
    }
}
