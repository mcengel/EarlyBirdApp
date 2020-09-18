using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EarlyBirdApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartGame1 : ContentPage
    {
        private int NumParticipants = 0;
        private bool IsRandomGamemode = true;
        public StartGame1()
        {
            InitializeComponent();
        }
        protected async void GoToNextPage(object sender, EventArgs e)
        {
            if(this.CheckEntries())
            {
                await Navigation.PushAsync(new StartGame2(this.NumParticipants,this.IsRandomGamemode));
            }            
        }
        private bool CheckEntries()
        {
            if(this.NumParticipants == 0)
            {
                return false;
            }
            return true;
        }

        protected void OnNumParticipantsValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            _numParticipantsLabel.Text = value.ToString();
            this.NumParticipants = value;
        }

        private void OnGameModeRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            string gamemode = e.Value.ToString();
            if(gamemode.Equals("Random"))
            {
                this.IsRandomGamemode = true;
            } 
            else
            {
                this.IsRandomGamemode = false;
            }
            Console.WriteLine("IsRandom:" + this.IsRandomGamemode);
        }


    }
}