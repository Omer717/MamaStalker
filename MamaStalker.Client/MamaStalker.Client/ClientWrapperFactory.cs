using MamaStalker.Client.Abstractions;
using MamaStalker.Client.Image;

namespace MamaStalker.Client
{
    public class ClientWrapperFactory : IClientWrapperFactory
    {
        public ClientWrapper Create(string ip, int port)
        {
            var imgHandler = new ImageHandler(new ByteConverter(), new JpgImageSaver());
            var clientLogic = new ImageClient(ip, port);

            return new ClientWrapper(clientLogic, imgHandler);
        }
    }
}
