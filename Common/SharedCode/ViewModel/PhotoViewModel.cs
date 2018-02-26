using System;
using SharedCode.Service;
using System.Windows.Input;
using SharedCode.Helpers;

namespace SharedCode.ViewModel
{
    public class PhotoViewModel : BaseViewModel
    {
        private PhotoService _photoService;

        public Command GetImageCommand { get; private set; }

        byte[] image = null;
        public byte[] Image
        {
            get { return image; }
            set { SetProperty(ref image, value); }
        }

        public PhotoViewModel()
        {
            _photoService = new PhotoService();
            GetImageCommand = new Command(async () => Image = await _photoService.LoadImageAsync());
        }
    }
}
