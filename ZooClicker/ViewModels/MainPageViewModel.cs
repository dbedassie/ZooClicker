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

        public MainPageViewModel()
        {
            Habitats = new Dictionary<string, Habitat>();
            LionHabitat lion = new LionHabitat();
            Habitats.Add(lion.Name, lion);
            _donations = 100;

            LionCommand = new Command(() =>
            {
                Donations += Habitats["Lion"].Donations;
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
