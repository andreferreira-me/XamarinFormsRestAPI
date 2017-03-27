using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinFormsRestAPI
{
    public partial class App : Application
    {
        private MainPage _mainpage;

        public App()
        {
            _mainpage = new XamarinFormsRestAPI.MainPage();

            InitializeComponent();

            MainPage = _mainpage;
        }

        protected override void OnStart()
        {
            _mainpage.Load();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
