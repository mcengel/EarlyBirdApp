using EarlyBirdApp.DataAccess;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EarlyBirdApp.Views.AddContent
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPlayers : ContentPage
    {
        private GenericQuery<Player> GenericQuery;
        public AddPlayers()
        {
            InitializeComponent();
            GenericQuery = new GenericQuery<Player>(App.Database.GetSQLiteConnection());
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //listView.ItemsSource = await App.Database.GetPlayersAsync();
            listView.ItemsSource = await GenericQuery.GetDataAsync();
        }
        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameEntry.Text) && !string.IsNullOrWhiteSpace(ageEntry.Text))
            {
                await GenericQuery.SaveDataAsync(new Player
                {
                    Name = nameEntry.Text,
                    Age = int.Parse(ageEntry.Text)
                });

                nameEntry.Text = ageEntry.Text = string.Empty;
                listView.ItemsSource = await GenericQuery.GetDataAsync();
            }
        }
    }
}