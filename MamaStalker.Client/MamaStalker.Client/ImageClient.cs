using MamaStalker.Client.Abstractions;
using System.Net.Sockets;

namespace MamaStalker.Client
{
    public class ImageClient : IClient
    {
        private const int BUFFER_SIZE = 1024;

        private readonly TcpClient _client;
        private readonly NetworkStream _stream;

        public ImageClient(string ip, int port)
        {
            _client = new TcpClient(ip, port);
            _stream = _client.GetStream();
        }

        public byte[] ReciveBytes()
        {
            throw new System.NotImplementedException();
        }
    }
}
