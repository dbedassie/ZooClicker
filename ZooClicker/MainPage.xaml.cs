using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZooClicker.ViewModels;

namespace ZooClicker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(Navigation);
            Title = "Zoo Clicker";


            Device.StartTimer(TimeSpan.FromSeconds(10), () =>
            {
                LuckyBtn.IsVisible = true;
                LuckyBtn.Command.CanExecute(true);
                // Return true to keep counting, return false to stop.
                return true;
            });
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SettingsPage());
        }

        void Button_Clicked_2(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new StatsPage());
        }


    }
}
