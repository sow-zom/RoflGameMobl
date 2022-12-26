﻿using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RoflGame.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.youtube.com/watch?v=dQw4w9WgXcQ"));
        }

        public ICommand OpenWebCommand { get; }
    }
}