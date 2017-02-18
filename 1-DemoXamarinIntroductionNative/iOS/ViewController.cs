// =============================================
// AUTHOR : Jorge Zeferino
// CREATE DATE : April 23, 2016
// PURPOSE : A simple Xamarin introduction demo
// =============================================

using System;
using System.Threading.Tasks;
using Foundation;
using FullSharedCode;
using UIKit;

namespace DemoXamarinIntroductionNative.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle) { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            PhotoButton.TouchUpInside += async delegate
            {
                await LoadImage();

                #region shared optimization
                /*await PhotoService.LoadImageAsync(bytes =>
                {
                    ImagePhoto.Image = new UIImage(NSData.FromArray(bytes));
                });*/
                #endregion
            };
        }

        private async Task LoadImage()
        {
            var bytes = await PhotoService.LoadImageAsync(Constants.RandomImageUrl);
            if (bytes != null && bytes.Length > 0)
            {
                ImagePhoto.Image = new UIImage(NSData.FromArray(bytes));
            }
        }
    }
}
