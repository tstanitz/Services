using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Newtonsoft.Json;
using Shared.Domain;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebClient
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
        private readonly HttpClient client;
        private const string serverUrl = "http://localhost:5001";

        public BenchmarkClass()
        {
            client = new HttpClient();
        }

        [Benchmark]
        public async Task ExecuteContent()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{serverUrl}/api/content");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var contentJson = await response.Content.ReadAsStringAsync();
            var photoSets = JsonConvert.DeserializeObject<PhotoSetsDataResult>(contentJson);
        }

        [Benchmark]
        public async Task ExecuteUpload()
        {
            var request = new HttpRequestMessage(HttpMethod.Post, $"{serverUrl}/api/upload");
            var bytes = File.ReadAllBytes(@"TestPicture\test2.jpg");

            var uploadData = new UploadData
            {
                Data = bytes
            };

            request.Content = new StringContent(JsonConvert.SerializeObject(uploadData), Encoding.UTF8, "application/json");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
        }
    }
}
