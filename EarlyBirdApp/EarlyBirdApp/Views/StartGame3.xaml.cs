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
    public partial class StartGame3 : ContentPage
    {
        public StartGame3()
        {
            InitializeComponent();
        }
        protected async void GoToPreviousPage(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        protected async void GoToStartPage(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}