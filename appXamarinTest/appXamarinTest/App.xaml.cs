using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EnvWinProjectQuizz.Views;

namespace appXamarinTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TestPageDropdown();
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
