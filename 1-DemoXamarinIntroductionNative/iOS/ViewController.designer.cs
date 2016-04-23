// =============================================
// AUTHOR : Jorge Zeferino
// CREATE DATE : April 23, 2016
// PURPOSE : A simple Xamarin introduction demo
// =============================================

// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//

using System.CodeDom.Compiler;
using Foundation;
using UIKit;

namespace DemoXamarinIntroductionNative.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIButton Button { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView ImagePhoto { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton PhotoButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ImagePhoto != null) {
				ImagePhoto.Dispose ();
				ImagePhoto = null;
			}
			if (PhotoButton != null) {
				PhotoButton.Dispose ();
				PhotoButton = null;
			}
		}
	}
}
