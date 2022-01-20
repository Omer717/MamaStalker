using System.Net.Sockets;

namespace MamaStalker.Server.Abstractions
{
    public interface IServerSender
    {
        void SendImage(TcpClient client, byte[] data);
    }
}
