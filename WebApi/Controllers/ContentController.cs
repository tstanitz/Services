using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Shared;
using Shared.Domain;

namespace WebApi.Controllers
{
    public class ContentController : Controller
    {
        [HttpGet]
        [Route("/api/v1/content")]
        public IActionResult GetContent()
        {
            var contentJson = ContentProvider.GetJson();
            var photoSets = JsonConvert.DeserializeObject<PhotoSetsDataResult>(contentJson);
            photoSets.ServerName = nameof(ContentController);
            return Json(photoSets);
        }
    }
}
