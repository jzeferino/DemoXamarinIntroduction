// =============================================
// AUTHOR : jzeferino
// PURPOSE : A simple Xamarin introduction demo
// =============================================

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Acr.UserDialogs;

namespace SharedCode.Service
{
    public class PhotoService
    {
        private HttpClient _client;

        public PhotoService()
        {
            _client = new HttpClient();
        }

        private async Task<byte[]> LoadImageAsync(string imageUrl)
        {
            UserDialogs.Instance.ShowLoading();

            try
            {
                var bytes = await _client.GetByteArrayAsync(imageUrl);
                if (bytes == null || bytes.Length == 0)
                {
                    throw new Exception("No content.");
                }
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

        public Task<byte[]> LoadImageAsync() => LoadImageAsync(Constants.RandomImageUrl);
    }
}

