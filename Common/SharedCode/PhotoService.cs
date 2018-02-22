// =============================================
// AUTHOR : jzeferino
// PURPOSE : A simple Xamarin introduction demo
// =============================================

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Acr.UserDialogs;

namespace SharedCode
{
    public static class PhotoService
    {
        private static byte _easterEgg;

        public static async Task<byte[]> LoadImageAsync(string imageUrl)
        {
            #region _easterEgg

            _easterEgg++;
            if (_easterEgg % 13 == 0)
            {
                await UserDialogs.Instance.AlertAsync("Oops, you found the Easter Egg.", typeof(PhotoService).Namespace);
            }

            #endregion

            UserDialogs.Instance.ShowLoading();

            try
            {
                var httpClient = new HttpClient();
                var bytes = await httpClient.GetByteArrayAsync(imageUrl);

                UserDialogs.Instance.HideLoading();

                return bytes;
            }
            catch (Exception)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert("Oops, can't retrive the image, please try again.");
            }

            return null;
        }

        #region shared optimization

        public static async Task LoadImageAsync(Action<byte[]> readyToLoadImage)
        {
            var bytes = await LoadImageAsync(Constants.RandomImageUrl);
            if (bytes != null && bytes.Length > 0)
            {
                readyToLoadImage(bytes);
            }
        }

        #endregion
    }
}

