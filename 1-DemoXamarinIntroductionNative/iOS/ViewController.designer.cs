// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
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
        UIKit.UIImageView ImagePhoto { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton PhotoButton { get; set; }

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