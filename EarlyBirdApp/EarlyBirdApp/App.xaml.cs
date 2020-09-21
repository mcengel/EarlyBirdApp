using EarlyBirdApp.DataAccess;
using EarlyBirdApp.Views;
using EarlyBirdApp.Views.AddContent;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EarlyBirdApp
{
    public partial class App : Application
    {
        static Database database;

        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "earlybirds.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new string[] { "RadioButton_Experimental" });
            MainPage = new NavigationPage(new AddPlayers());
        }//https://www.youtube.com/watch?v=UPD_2SVGQ6M

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
