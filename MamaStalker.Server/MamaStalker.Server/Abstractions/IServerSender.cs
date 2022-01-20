using System.Net.Sockets;

namespace MamaStalker.Server.Abstractions
{
    public interface IServerSender
    {
        void SendData(TcpClient client, byte[] data);
    }
}
