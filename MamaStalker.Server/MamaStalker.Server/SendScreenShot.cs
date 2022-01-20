using MamaStalker.Capturer.Abstractions;
using MamaStalker.Server.Abstractions;
using System.Net.Sockets;
using System.Windows;

namespace MamaStalker.Server
{
    public class SendScreenShot : IServerAction
    {
        private readonly IServerSender _sender;
        private readonly ICapture _capturer;
        public SendScreenShot(IServerSender sender, ICapture capturer)
        {
            _sender = sender;
            _capturer = capturer;
        }
        public void Execute(TcpClient client)
        {
            _sender.SendData(client, _capturer.Capture());
        }
    }
}
