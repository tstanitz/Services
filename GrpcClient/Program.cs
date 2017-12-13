using Grpc.Core;
using System.Threading.Tasks;
using static GrpcDefinition.ContentServer;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using System.IO;
using System.Collections.Generic;

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
        public async Task ExecuteGetContent()
        {
            var photoSets = await client.GetContentAsync(new GrpcDefinition.Request());
        }

        [Benchmark]
        public async Task ExecuteUpload()
        {
            var content = File.ReadAllBytes(@"TestPicture\test2.jpg");
            var response = await client.UploadImageAsync(new GrpcDefinition.SendImage()
            {
                Data = Google.Protobuf.ByteString.CopyFrom(content)
            });
        }

        [Benchmark]
        public async Task ExecuteUploadStream()
        {
            var content = File.ReadAllBytes(@"TestPicture\test2.jpg");
            using (var call = client.UploadImageStream())
            {
                await call.RequestStream.WriteAsync(new GrpcDefinition.SendImage
                {
                    Data = Google.Protobuf.ByteString.CopyFrom(content)
                });
                await call.RequestStream.CompleteAsync();

                var response = await call.ResponseAsync;
            }
        }

        [Benchmark]
        public async Task ExecuteMultipleUpload()
        {
            var content = File.ReadAllBytes(@"TestPicture\test2.jpg");

            for (int i = 0; i < 3; i++)
            {
                var response = await client.UploadImageAsync(new GrpcDefinition.SendImage()
                {
                    Data = Google.Protobuf.ByteString.CopyFrom(content)
                });
            }
        }

        [Benchmark]
        public async Task ExecuteUploadMultipleInStream()
        {
            var content = File.ReadAllBytes(@"TestPicture\test2.jpg");
            using (var call = client.UploadImageStream())
            {
                for (int i = 0; i < 3; i++)
                {
                    await call.RequestStream.WriteAsync(new GrpcDefinition.SendImage
                    {
                        Data = Google.Protobuf.ByteString.CopyFrom(content)
                    });
                }
                
                await call.RequestStream.CompleteAsync();

                var response = await call.ResponseAsync;
            }

        }
    }
}
