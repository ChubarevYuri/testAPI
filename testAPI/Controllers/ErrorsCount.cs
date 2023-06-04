using Microsoft.AspNetCore.Mvc;

namespace testAPI.Controllers
{
    [ApiController]
    [Route("/errors/count")]
    public class ErrorsCount : Controller
    {
        [HttpGet]
        public int Get()
        {
            return (int)StaticMethods.AllData.Scan.ErrorCount;
        }
    }
}
