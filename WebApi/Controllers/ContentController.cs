using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Shared;
using Shared.Domain;

namespace WebApi.Controllers
{
    public class ContentController : Controller
    {
        [HttpGet]
        [Route("/api/content")]
        public IActionResult GetContent()
        {
            var json = ContentProvider.GetJson();
            var photoSets = JsonConvert.DeserializeObject<PhotoSetsDataResult>(json);
            return Json(photoSets);
        }
    }
}
