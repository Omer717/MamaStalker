namespace MamaStalker.Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serverFactory = new ServerFactory();
            var server = serverFactory.Create(int.Parse(args[0]), int.Parse(args[1]));
            server.Start();
        }
    }
}
