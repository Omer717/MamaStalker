using System.Net.Sockets;

namespace MamaStalker.Server.Abstractions
{
    public interface IServerReciver
    {
        byte[] ReciveData(TcpClient client);
    }
}
