using System.Threading.Tasks;
using Grpc.Core;
using GrpcDefinition;
using static GrpcDefinition.ContentServer;
using Shared;
using System.Collections.Generic;

namespace GrpcServer
{
    public class ContentServerImpl : ContentServerBase
    {

        public async override Task<PhotoSetsDataResult> GetContent(Request request, ServerCallContext context)
        {
            var contentJson = await ContentProvider.GetCapitalJsonAsync();

            var photoSetsDataResult = PhotoSetsDataResult.Parser.ParseJson(contentJson);

            photoSetsDataResult.ActionName = $"GRPC - {nameof(GetContent)}";

            return photoSetsDataResult;
        }

        public override Task<Response> UploadImage(SendImage request, ServerCallContext context)
        {
            return Task.FromResult(new Response()
            {
                Length = request.Data.ToByteArray().Length
            });
        }

        public async override Task<Response> UploadImageStream(IAsyncStreamReader<SendImage> requestStream, ServerCallContext context)
        {
            var length = 0;
            while (await requestStream.MoveNext())
            {
                length += requestStream.Current.Data.Length;
            }
            return new Response()
            {
                Length = length
            };
        }
    }
}
