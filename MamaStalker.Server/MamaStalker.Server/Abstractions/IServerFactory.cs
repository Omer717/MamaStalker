namespace MamaStalker.Server.Abstractions
{
    public interface IServerFactory
    {
        ServerLogic Create(int port, int interval);
    }
}
