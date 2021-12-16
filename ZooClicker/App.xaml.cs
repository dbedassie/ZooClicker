using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZooClicker
{
    public partial class App : Application
    {
        public static float Donations = 100;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
