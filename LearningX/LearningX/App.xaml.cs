﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearningX
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GridPage();
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
