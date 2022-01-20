using System.Net.Sockets;

namespace MamaStalker.Server.Abstractions
{
    public interface IServer
    {
        void Start();
        void WaitForNewClients();
        void CreateClientThread(TcpClient socket);
    }
}
