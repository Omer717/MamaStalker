using MamaStalker.Client.Abstractions;
using MamaStalker.Client.Image.Abstractions;
using System;

namespace MamaStalker.Client
{
    public class ClientWrapper
    {
        private readonly IClient _client;
        private readonly IImageHandler _imageHandler;

        public ClientWrapper(IClient client, IImageHandler imageHandler)
        {
            _client = client;
            _imageHandler = imageHandler;
        }

        public void RunMamaStalkerClient()
        {
            while (true)
            {
                _imageHandler.SaveBytesToImageFile(DateTime.Now.ToString(), _client.ReciveBytes());
            }
        }
    }
}
