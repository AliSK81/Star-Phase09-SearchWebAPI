using Microsoft.AspNetCore.Mvc;
using StudentProject;

// https://www.nuget.org/packages/StarAcademy.CodeStar.alisk.SearchEngine

namespace SearchWebAPI.Controllers

{
    [ApiController]
    public class SearchController : Controller
    {
        [HttpGet("[action]")]
        public IActionResult Search([FromQuery] string query)
        {
            var result = SearchEngine.Instance.Search(query);

            if(result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
