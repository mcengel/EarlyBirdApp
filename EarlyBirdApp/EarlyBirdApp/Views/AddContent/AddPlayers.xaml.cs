using EarlyBirdApp.DataAccess;
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
        public AddPlayers()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetPlayersAsync();
        }
        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameEntry.Text) && !string.IsNullOrWhiteSpace(ageEntry.Text))
            {
                await App.Database.SavePlayersAsync(new Player
                {
                    Name = nameEntry.Text,
                    Age = int.Parse(ageEntry.Text)
                });

                nameEntry.Text = ageEntry.Text = string.Empty;
                listView.ItemsSource = await App.Database.GetPlayersAsync();
            }
        }
    }
}