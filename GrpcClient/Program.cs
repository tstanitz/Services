using Grpc.Core;
using System.Threading.Tasks;
using static GrpcDefinition.ContentServer;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;

namespace GrpcClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkClass>();
        }

    }

    public class BenchmarkClass
    {
        private readonly ContentServerClient client;

        public BenchmarkClass()
        {
            var channel = new Channel("localhost:50051", ChannelCredentials.Insecure);
            client = new ContentServerClient(channel);
        }

        [Benchmark]
        public async Task Execute()
        {
            var photoSets = await client.GetContent_v1Async(new GrpcDefinition.Request
            {
                Number = 1
            });
        }
    }
}
