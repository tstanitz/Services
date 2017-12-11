using Grpc.Core;
using System;
using System.Collections.Generic;
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

        public static async Task GetContent_v1Async()
        {
            var channel = new Channel("localhost:50051", ChannelCredentials.Insecure);
            var client = new ContentServerClient(channel);
            var photoSets = await client.GetContent_v1Async(new GrpcDefinition.Request());
            var ids = new List<string>();
            foreach (var ps in photoSets.PhotoSets.PhotoSet)
            {
                ids.Add(ps.Id);
            }

            Console.WriteLine($"{photoSets.ActionName}: {string.Join(", ", ids)}");
            await channel.ShutdownAsync();
        }
    }
}
