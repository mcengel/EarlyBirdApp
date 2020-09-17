using EarlyBirdApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EarlyBirdApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StartGame1());
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
