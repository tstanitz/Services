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
        [Route("/api/content")]
        public async Task<IActionResult> GetContent()
        {
            var contentJson = await ContentProvider.GetCapitalJsonAsync();
            var photoSets = JsonConvert.DeserializeObject<PhotoSetsDataResult>(contentJson);
            photoSets.ActionName = $"MVC - {nameof(GetContent)}";
            return Json(photoSets);
        }

        [HttpPost]
        [Route("/api/upload")]
        public IActionResult Upload([FromBody]UploadData uploadData)
        {
            return new OkObjectResult(uploadData.Data.Length);
        }
    }
}