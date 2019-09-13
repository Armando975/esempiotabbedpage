using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EsempioAppCenterTabbed.Services;
using EsempioAppCenterTabbed.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace EsempioAppCenterTabbed
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("android=95811093-a178-49bd-bded-8e690d24c311;" +
                  "ios=56689543-a6e2-4fc0-b1c9-ec83ba385686;",
                  typeof(Analytics), typeof(Crashes));
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
