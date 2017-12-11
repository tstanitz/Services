using System.Threading.Tasks;
using Grpc.Core;
using GrpcDefinition;
using static GrpcDefinition.ContentServer;
using Shared;
using Newtonsoft.Json;

namespace GrpcServer
{
    public class ContentServerImpl : ContentServerBase
    {

        public async override Task<PhotoSetsDataResult> GetContent_v1(Request request, ServerCallContext context)
        {
            var contentJson = await ContentProvider.GetCapitalJsonAsync();

            var photoSetsDataResult = PhotoSetsDataResult.Parser.ParseJson(contentJson);

            photoSetsDataResult.ActionName = nameof(GetContent_v1);

            return photoSetsDataResult;
        }        
    }
}
