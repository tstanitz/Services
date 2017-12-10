using System;
using System.Threading.Tasks;
using Grpc.Core;
using static GrpcDefinition.ContentServer;

namespace GrpcServer
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var server = new Server
            {
                Ports = { new ServerPort("localhost", 50051, ServerCredentials.Insecure) },
                Services = { BindService(new ContentServerImpl()) }
            };

            server.Start();
            Console.ReadKey();
            await server.ShutdownAsync();
        }
    }
}
