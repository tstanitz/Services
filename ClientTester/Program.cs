using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ClientTester
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await PerformRequest(500, ExecuteGetContentV1Request);
            await PerformRequest(500, ExecuteGetApiContentRequest);
            
        }

        static async Task ExecuteGetApiContentRequest() => await WebClient.Program.GetApiContenAsync();

        static async Task ExecuteGetContentV1Request() => await GrpcClient.Program.GetContent_v1Async();

        static async Task PerformRequest(int numberOfRequests, Func<Task> request)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < numberOfRequests; i++)
            {
                await request();
            }
            Console.WriteLine(stopWatch.ElapsedMilliseconds);
        }
    }
}
