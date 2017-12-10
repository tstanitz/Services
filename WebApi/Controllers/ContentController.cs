using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Shared;
using Shared.Domain;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    public class ContentController : Controller
    {
        [HttpGet]
        [Route("/api/v1/content")]
        public async Task<IActionResult> GetContent()
        {
            var contentJson = await ContentProvider.GetJsonAsync();
            var photoSets = JsonConvert.DeserializeObject<PhotoSetsDataResult>(contentJson);
            photoSets.ActionName = nameof(GetContent);
            return Json(photoSets);
        }
    }
}
