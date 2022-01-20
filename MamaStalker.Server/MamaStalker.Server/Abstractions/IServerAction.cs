using System.Net.Sockets;

namespace MamaStalker.Server.Abstractions
{
    public interface IServerAction
    {
        void Execute(TcpClient client);
    }
}
