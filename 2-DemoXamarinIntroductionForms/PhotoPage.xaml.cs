// =============================================
// AUTHOR : Jorge Zeferino
// CREATE DATE : April 23, 2016
// PURPOSE : A simple Xamarin introduction demo
// =============================================

using System.IO;
using System.Threading.Tasks;
using FullSharedCode;
using Xamarin.Forms;

namespace DemoXamarinIntroductionForms
{
	public partial class PhotoPage : ContentPage
	{
		public PhotoPage ()
		{
			InitializeComponent ();

			NavigationPage.SetHasNavigationBar (this, false);

			BindingContext = this;

			if (Device.OS == TargetPlatform.iOS) {
			
				BackgroundColor = Color.Black;

			}

		}
			
		private Command _photoCommand;

		public Command PhotoCommand
		{
			get
			{
				return _photoCommand ?? (_photoCommand = new Command(async () => await LoadImage()));

				#region shared optimization
				/*return _photoCommand ?? (_photoCommand = new Command(async () => await PhotoService.LoadImageAsync(bytes => {

					PhotoImage.Source = ImageSource.FromStream(() => new MemoryStream(bytes));

				})));*/
				#endregion
			}
		}

	    private async Task LoadImage ()
		{
			var bytes = await PhotoService.LoadImageAsync(Constants.RandomImageUrl);

			if(bytes != null && bytes.Length > 0){

				PhotoImage.Source = ImageSource.FromStream(() => new MemoryStream(bytes));

			}

		}
	}
}

