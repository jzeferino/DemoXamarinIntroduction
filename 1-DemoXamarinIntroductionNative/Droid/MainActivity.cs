// =============================================
// AUTHOR : jzeferino
// PURPOSE : A simple Xamarin introduction demo
// =============================================

using System.Threading.Tasks;
using Acr.UserDialogs;
using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Widget;
using SharedCode;
using SharedCode.ViewModel;

namespace DemoXamarinIntroductionNative.Droid
{
    [Activity(Label = "DemoXamarinIntroductionNative", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        private ImageView _imgRandomPhoto;
        private Button _btnLoadImage;
        private PhotoViewModel _photoViewModel;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            ActionBar.Hide();

            UserDialogs.Init(this);

            _imgRandomPhoto = FindViewById<ImageView>(Resource.Id.imgRandomPhoto);

            _btnLoadImage = FindViewById<Button>(Resource.Id.btnLoadImage);

            _photoViewModel = new PhotoViewModel();
            _btnLoadImage.Click += btnLoadImageClick;
            _photoViewModel.PropertyChanged += PhotoViewModelPropertyChanged;
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            _btnLoadImage.Click -= btnLoadImageClick;
            _photoViewModel.PropertyChanged -= PhotoViewModelPropertyChanged;

        }

        private void btnLoadImageClick(object sender, System.EventArgs e) => _photoViewModel.GetImageCommand.Execute(null);

        private void PhotoViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(_photoViewModel.Image):
                    _imgRandomPhoto.SetImageBitmap(BitmapFactory.DecodeByteArray(_photoViewModel.Image, 0, _photoViewModel.Image.Length));
                    break;

            }
        }
    }
}


