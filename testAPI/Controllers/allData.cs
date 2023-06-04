using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text;
using System.Collections;
using testAPI.Objects;

namespace testAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class allData : ControllerBase
    {
        [HttpGet]
        public AllData Get()
        {

            return StaticMethods.AllData;
        }
    }
}
