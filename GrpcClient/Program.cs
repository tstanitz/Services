using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static GrpcDefinition.ContentServer;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var channel = new Channel("localhost:50051", ChannelCredentials.Insecure);
            var client = new ContentServerClient(channel);
            var photoSets = await client.GetContent_v1Async(new GrpcDefinition.Request());
            var ids = new List<string>();
            foreach (var photoSet in photoSets.PhotoSets)
            {
                foreach (var ps in photoSet.PhotoSet)
                {
                    ids.Add(ps.Id);
                }
            }

            Console.WriteLine($"{photoSets.ServerName}: {string.Join(", ", ids)}");
            await channel.ShutdownAsync();
        }
    }
}
