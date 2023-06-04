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

namespace testAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class allData : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            using (StreamReader r = new StreamReader("data.json"))
            {
                return Enumerable.Range(1,1).Select(index => r.ReadToEnd()).ToArray();
            }
        }
    }
}
