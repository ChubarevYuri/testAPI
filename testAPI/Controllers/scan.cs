using Microsoft.AspNetCore.Mvc;

namespace testAPI.Controllers
{
    [ApiController]
    [Route("scan")]
    public class Scan : Controller
    {

        [HttpGet]
        public Objects.Scan Get()
        {
            return StaticMethods.AllData.Scan;
        }
    }
}
