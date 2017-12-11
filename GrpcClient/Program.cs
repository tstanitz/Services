using Grpc.Core;
using System;
using System.Threading.Tasks;
using static GrpcDefinition.ContentServer;

namespace GrpcClient
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            await GetContent_v1Async();
        }

        public static async Task GetContent_v1Async(int number = 0)
        {
            var channel = new Channel("localhost:50051", ChannelCredentials.Insecure);
            var client = new ContentServerClient(channel);
            var photoSets = await client.GetContent_v1Async(new GrpcDefinition.Request
            {
                Number = number
            });
            Console.WriteLine($"{photoSets.ActionName} - {photoSets.PhotoSets.PhotoSet[0].Id}");
            await channel.ShutdownAsync();
        }
    }
}
