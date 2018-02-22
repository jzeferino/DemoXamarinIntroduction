// ============================================
// AUTHOR : jzeferino
// PURPOSE : A simple Xamarin introduction demo
// ============================================

using Acr.UserDialogs;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace DemoXamarinIntroductionForms.Droid
{
    [Activity(Label = "DemoXamarinIntroductionForms.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Forms.Init(this, bundle);

            UserDialogs.Init(this);

            LoadApplication(new App());

        }
    }
}

