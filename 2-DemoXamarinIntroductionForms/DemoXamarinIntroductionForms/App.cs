// =============================================
// AUTHOR : jzeferino
// PURPOSE : A simple Xamarin introduction demo
// =============================================

using Xamarin.Forms;

namespace DemoXamarinIntroductionForms
{
    public class App : Application
    {
        public App()
        {
            MainPage = new PhotoPage();
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

