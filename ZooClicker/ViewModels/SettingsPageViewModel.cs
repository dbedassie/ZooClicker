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
    public class SettingsPageViewModel : INotifyPropertyChanged
    {
        private bool audio;
        private bool vibration;
        private bool animations;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool Audio
        {
            get
            {
                return audio;
            }
            set
            {
                audio = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Audio"));
            }
        }

        public bool Vibration
        {
            get
            {
                return vibration;
            }
            set
            {
                vibration = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Vibration"));
            }
        }

        public bool Animations
        {
            get
            {
                return animations;
            }
            set
            {
                animations = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Animations"));
            }
        }

        public ICommand AudioCommand { get; set; }
        public ICommand VibrationCommand { get; set; }
        public ICommand AnimationCommand { get; set; }

        public SettingsPageViewModel()
        {
            AudioCommand = new Command(ToggleAudio);
            VibrationCommand = new Command(ToggleVibration);
            AnimationCommand = new Command(ToggleAnimation);
        }

        private void ToggleAudio()
        {
            Audio = !Audio;
        }

        private void ToggleVibration()
        {
            Vibration = !Vibration;
        }

        private void ToggleAnimation()
        {
            Animations = !Animations;
        }
    }
}
