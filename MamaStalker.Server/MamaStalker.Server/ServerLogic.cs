using log4net;
using MamaStalker.Server.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace MamaStalker.Server
{
    public class ServerLogic : IServer
    {
        private ILog _logger = LogManager.GetLogger(typeof(ServerLogic));

        private readonly IServerAction _serverAction;
        private readonly TcpListener _listener;
        private readonly Timer _actionTimer;
        private List<TcpClient> _connectedSockets;

        public ServerLogic(IServerAction serverAction, Timer actionTimer, int port)
        {
            _listener = new TcpListener(IPAddress.Any, port);
            _serverAction = serverAction;
            _actionTimer = actionTimer;

            _connectedSockets = new List<TcpClient>();
        }

        public void ExecuteServerAction(object sender, ElapsedEventArgs e)
        {
            if (_connectedSockets.Count != 0)
            {
                foreach (var client in _connectedSockets)
                {
                    _serverAction.Execute(client);
                }
            }
        }

        public void Start()
        {
            _actionTimer.Elapsed += ExecuteServerAction;
            _actionTimer.Start();
            WaitForNewClients();
        }

        public void WaitForNewClients()
        {
            while (true)
            {
                var newClient = _listener.AcceptTcpClient();
                _logger.Info($"Got a new client {(IPEndPoint)newClient.Client.RemoteEndPoint}");
                _connectedSockets.Add(newClient);
            }
        }
    }
}
