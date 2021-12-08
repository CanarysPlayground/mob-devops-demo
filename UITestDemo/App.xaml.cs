using System;

using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace UITestDemo
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "https://localhost:5000";

        public App()
        {
            InitializeComponent();

            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<CloudDataStore>();

            if (Xamarin.Forms.Device.RuntimePlatform == Xamarin.Forms.Device.iOS)
                MainPage = new MainPage();
            else
                MainPage = new NavigationPage(new MainPage());
        }

        protected async override void OnStart()
        {

            AppCenter.Start("android=8e89b3c4-261e-419b-a704-df3f10821a90;" + "ios=7c8a10af-023f-4e29-8285-ccaf669da49e;", typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {

        }


        protected override void OnResume()
        {



        }
    }
}
