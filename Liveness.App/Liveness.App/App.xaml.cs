using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Liveness.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //chaning the main page from the default to ContentPageExample
            //MainPage = new MainPage();
            MainPage = new ContentPage();
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
