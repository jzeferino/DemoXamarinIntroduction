// =============================================
// AUTHOR : Jorge Zeferino
// CREATE DATE : April 23, 2016
// PURPOSE : A simple Xamarin introduction demo
// =============================================

using UIKit;

namespace DemoXamarinIntroductionNative.iOS
{
	public class Application
	{
		// This is the main entry point of the application.
	    private static void Main (string[] args)
		{
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main (args, null, "AppDelegate");
		}
	}
}
