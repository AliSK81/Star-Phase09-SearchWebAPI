using Microsoft.AspNetCore.Mvc;
using StudentProject;

namespace SearchWebAPI.Controllers
{
    [ApiController]
    public class StudentController : Controller
    {
        [HttpGet("[action]")]
        public IActionResult Top([FromQuery] int n)
        {
            var result = Processor.Instance.FindTopNStudetns(n);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
