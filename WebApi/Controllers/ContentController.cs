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
        [Route("/api/v1/content/{id}")]
        public async Task<IActionResult> GetContent(int id)
        {
            var contentJson = await ContentProvider.GetCapitalJsonAsync(id);
            var photoSets = JsonConvert.DeserializeObject<PhotoSetsDataResult>(contentJson);
            photoSets.ActionName = $"MVC - {nameof(GetContent)}";
            return Json(photoSets);
        }
    }
}
