using Microsoft.AspNetCore.Mvc;

namespace testAPI.Controllers
{
    [ApiController]
    [Route("/allData")]
    public class AllData : ControllerBase
    {
        [HttpGet]
        public Objects.AllData Get()
        {

            return StaticMethods.AllData;
        }
    }
}
