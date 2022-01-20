using MamaStalker.Capturer;
using MamaStalker.Server.Abstractions;
using System.Timers;

namespace MamaStalker.Server
{
    public class ServerFactory : IServerFactory
    {
        public ServerLogic Create(int port, int interval)
        {
            var timer = new Timer(interval);
            var serverAction = new SendScreenShot(new ImageSender(), new ScreenCapturer());

            return new ServerLogic(serverAction, timer, port);
        }
    }
}
