using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinFormsRestAPI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new XamarinFormsRestAPI.MainPage();
        }

        protected override async void OnStart()
        {
            var client = new Services.RestClient();

            var json = client.Serialize();

            await MainPage.DisplayAlert("Json: ", json, "Cancel");
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
