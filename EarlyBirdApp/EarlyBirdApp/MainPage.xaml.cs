﻿using EarlyBirdApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EarlyBirdApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            
        }
        private async void StartButtonClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StartGame1());
        }

        private void GameSettingsButtonClicked(object sender, EventArgs e)
        {

        }

        private void EditorButtonClicked(object sender, EventArgs e)
        {

        }

        private void ExitGameButtonClicked(object sender, EventArgs e)
        {

        }

        private void SettingsButtonClicked(object sender, EventArgs e)
        {

        }
        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Console.WriteLine("&&&&&"+ Path.GetFullPath(Environment.CurrentDirectory));
        //        File.Create(Path.GetFullPath(Environment.CurrentDirectory));
        //        string path = Path.Combine(Path.GetTempPath(), @"persitence", "TextFile1.txt");
        //        Console.WriteLine("$$$$$" + Environment.CurrentDirectory);
        //        Console.WriteLine("§§§§§" + path);
        //        string[] file = System.IO.File.ReadAllLines(path);
        //        Console.WriteLine("?????" + file[0]);

        //    }catch(Exception errorMsg)
        //    {
        //        Console.WriteLine(errorMsg.Message);
        //    }
        //}

        //public void OnStartButtonClicked(object sender, EventArgs args)
        //{

        //}

        //public void OnSettingsButtonClicked(object sender, EventArgs args)
        //{

        //}

        //public void OnStatisticsButtonClicked(object sender, EventArgs args)
        //{

        //}
    }

}
