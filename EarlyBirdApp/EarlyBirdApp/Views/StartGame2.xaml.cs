using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EarlyBirdApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartGame2 : ContentPage
    {
        public StartGame2()
        {
            InitializeComponent();
        }
        protected async void GoToNextPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StartGame3());
        }
    }
}