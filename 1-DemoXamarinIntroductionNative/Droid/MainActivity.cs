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

namespace DemoXamarinIntroductionNative.Droid
{
    [Activity(Label = "DemoXamarinIntroductionNative", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        private ImageView _imgRandomPhoto;

        private Button _btnLoadImage;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            ActionBar.Hide();

            UserDialogs.Init(this);

            _imgRandomPhoto = FindViewById<ImageView>(Resource.Id.imgRandomPhoto);

            _btnLoadImage = FindViewById<Button>(Resource.Id.btnLoadImage);

            _btnLoadImage.Click += async delegate
            {

                await LoadImage();

                #region shared optimization
                /*await PhotoService.LoadImageAsync(bytes => {

				     _imgRandomPhoto.SetImageBitmap(BitmapFactory.DecodeByteArray(bytes, 0, bytes.Length));

				});*/
                #endregion
            };
        }

        private async Task LoadImage()
        {
            var bytes = await PhotoService.LoadImageAsync(Constants.RandomImageUrl);

            if (bytes != null && bytes.Length > 0)
            {

                _imgRandomPhoto.SetImageBitmap(BitmapFactory.DecodeByteArray(bytes, 0, bytes.Length));

            }

        }

    }
}


