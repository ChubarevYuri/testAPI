using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using testAPI.Objects;

namespace testAPI.Controllers
{
    [ApiController]
    [Route("/scan")]
    public class Scan : Controller
    {

        [HttpGet]
        public Objects.Scan Get()
        {
            return StaticMethods.AllData.Scan;
        }
    }
}
