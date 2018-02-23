// =============================================
// AUTHOR : jzeferino
// PURPOSE : A simple Xamarin introduction demo
// =============================================

using System;
using System.Threading.Tasks;
using Foundation;
using SharedCode;
using SharedCode.ViewModel;
using UIKit;

namespace DemoXamarinIntroductionNative.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle) { }
        private PhotoViewModel _photoViewModel;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            _photoViewModel = new PhotoViewModel();
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            PhotoButton.TouchUpInside += btnLoadImageClick;
            _photoViewModel.PropertyChanged += PhotoViewModelPropertyChanged;
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
            PhotoButton.TouchUpInside -= btnLoadImageClick;
            _photoViewModel.PropertyChanged -= PhotoViewModelPropertyChanged;
        }

        private void btnLoadImageClick(object sender, System.EventArgs e) => _photoViewModel.GetImageCommand.Execute(null);

        private void PhotoViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(_photoViewModel.Image):
                    ImagePhoto.Image = new UIImage(NSData.FromArray(_photoViewModel.Image));
                    break;
            }
        }
    }
}
