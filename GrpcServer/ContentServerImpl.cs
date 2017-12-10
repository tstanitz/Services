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
        public override Task<PhotoSetsDataResult> GetContent_v1(Request request, ServerCallContext context)
        {
            var contentJson = ContentProvider.GetJson();

            var photoSets = JsonConvert.DeserializeObject<Shared.Domain.PhotoSetsDataResult>(contentJson);
            PhotoSetsDataResult photoSetsDataResult = GetPhotoSetsDataResult(photoSets);

            return Task.FromResult(photoSetsDataResult);
        }

        private static PhotoSetsDataResult GetPhotoSetsDataResult(Shared.Domain.PhotoSetsDataResult photoSets)
        {
            var photoSetsDataResult = new PhotoSetsDataResult
            {
                ServerName = nameof(ContentServerImpl)
            };

            foreach (var photoSet in photoSets.PhotoSets.PhotoSet)
            {
                PhotoSetsData photoSetsData = new PhotoSetsData();
                PhotoSetData photoSetData = new PhotoSetData
                {
                    Id = photoSet.Id,
                    Primary = photoSet.Primary,
                    DateCreate = photoSet.Date_Create,
                    DateUpdate = photoSet.Date_Update
                };
                photoSetData.Title = new ContentData
                {
                    Content = photoSet.Title._Content
                };
                photoSetData.Description= new ContentData
                {
                    Content = photoSet.Description._Content
                };
                photoSetsData.PhotoSet.Add(photoSetData);
                photoSetsDataResult.PhotoSets.Add(photoSetsData);
            }

            return photoSetsDataResult;
        }
    }
}
