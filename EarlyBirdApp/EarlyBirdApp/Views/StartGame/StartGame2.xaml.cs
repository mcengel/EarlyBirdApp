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
        private readonly int NumberParticipants;
        private readonly bool IsRandomGamemode;
        public StartGame2(int NumberParticipants, bool IsRandomGamemode)
        {
            this.IsRandomGamemode = IsRandomGamemode;
            this.NumberParticipants = NumberParticipants;         
            InitializeComponent();
        }
        protected async void GoToNextPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StartGame3());
        }
        private string ConvertBoolToString(bool isRandom)
        {
            if(isRandom)
            {
                return "Random";
            }
            return "Control";
        }
    }
}