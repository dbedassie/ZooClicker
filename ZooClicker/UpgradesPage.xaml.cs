using System;
using System.Collections.Generic;
using ZooClicker.ViewModels;
using ZooClicker.Models;
using Xamarin.Forms;

namespace ZooClicker
{
    public partial class UpgradesPage : ContentPage
    {
        public UpgradesPage(MainPageViewModel mpvm)
        {
            InitializeComponent();
            BindingContext = mpvm;
        }
    }
}
