using System;

namespace MamaStalker.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new ClientWrapperFactory();
            var clientWrapper = factory.Create(args[0], int.Parse(args[1]));
            clientWrapper.RunMamaStalkerClient();
        }
    }
}
