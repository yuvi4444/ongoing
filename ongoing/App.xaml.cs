﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ongoing
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new pages.PageOne();
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