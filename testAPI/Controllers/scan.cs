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
    [Route("[controller]")]
    public class scan : Controller
    {

        [HttpGet]
        public Scan Get()
        {
            AllData  allData = StaticMethods.AllData;
            return StaticMethods.AllData.Scan;
        }
    }
}
