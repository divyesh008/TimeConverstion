using System;
using NodaTime;
using Xamarin.Forms;

namespace TimeZoneConversion
{
    public partial class App : Application
    {

        public static string timeZoneName { get; set; } = string.Empty;

        public App()
        {
            this.InitializeComponent();
            var tz = string.Empty;
            var tz2 = string.Empty;

            if (Device.RuntimePlatform == Device.Android)
            {
                tz = TimeZoneInfo.Local.DisplayName;
                tz2 = TimeZoneInfo.Local.StandardName;
            }
            else if (Device.RuntimePlatform == Device.iOS)
            {
                tz = App.timeZoneName;
            }

            MainPage = new TimeZoneConversion.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
