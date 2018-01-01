using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using static GrpcDefinition.ContentServer;

namespace GrpcServer
{
    public class Program
    {
        private static readonly ManualResetEvent ShutDown = new ManualResetEvent(false);        
        static void Main(string[] args)
        {
            var server = new Server
            {
                Ports = { new ServerPort("0.0.0.0", 5002, ServerCredentials.Insecure) },
                Services = { BindService(new ContentServerImpl()) }
            };
            server.Start();
            Console.CancelKeyPress += new ConsoleCancelEventHandler((s, a) =>
            {
                ShutDown.Set();
                server.ShutdownAsync().Wait();
            });
            ShutDown.WaitOne();
        }
    }
}
