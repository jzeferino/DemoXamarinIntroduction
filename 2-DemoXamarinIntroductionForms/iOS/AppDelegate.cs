// =============================================
// AUTHOR : Jorge Zeferino
// CREATE DATE : April 23, 2016
// PURPOSE : A simple Xamarin introduction demo
// =============================================

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace DemoXamarinIntroductionForms.iOS
{
	[Register ("AppDelegate")]
	public class AppDelegate : FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			Forms.Init ();

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}
	}
}

