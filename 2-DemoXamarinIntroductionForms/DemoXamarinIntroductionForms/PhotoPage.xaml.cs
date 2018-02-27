// =============================================
// AUTHOR : jzeferino
// PURPOSE : A simple Xamarin introduction demo
// =============================================

using System.IO;
using System.Threading.Tasks;
using SharedCode;
using SharedCode.ViewModel;
using Xamarin.Forms;

namespace DemoXamarinIntroductionForms
{
    public partial class PhotoPage : ContentPage
    {
        private PhotoViewModel _photoViewModel;

        public PhotoPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _photoViewModel = new PhotoViewModel();

            if (Device.RuntimePlatform == Device.iOS)
            {
                BackgroundColor = Color.Black;
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _photoViewModel.PropertyChanged += PhotoViewModelPropertyChanged;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            _photoViewModel.PropertyChanged -= PhotoViewModelPropertyChanged;

        }

        private void PhotoViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(_photoViewModel.Image):
                    PhotoImage.Source = ImageSource.FromStream(() => new MemoryStream(_photoViewModel.Image));
                    break;
            }
        }
    }
}

