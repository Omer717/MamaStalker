using MamaStalker.Server.Abstractions;
using System;
using System.Net.Sockets;

namespace MamaStalker.Server
{
    public class ImageSender : IServerSender
    {
        public void SendImage(TcpClient client, byte[] data)
        {
            var stream = client.GetStream();
            stream.Write(data, 0, Buffer.ByteLength(data));
        }
    }
}
