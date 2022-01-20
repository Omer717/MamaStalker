using System.Timers;

namespace MamaStalker.Server.Abstractions
{
    public interface IServer
    {
        void Start();
        void WaitForNewClients();
        void ExecuteServerAction(object sender, ElapsedEventArgs e);
    }
}
