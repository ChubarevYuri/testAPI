using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace testAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class scan : Controller
    {

        [HttpGet]
        public Scan Get()
        {

            using (StreamReader r = new StreamReader("data.json"))
            {
                string s = r.ReadToEnd();
                AllData? obj = JsonSerializer.Deserialize<AllData>(s);
                return obj.Scan;//Enumerable.Range(1, 1).Select(index => scan).ToArray();
            }
        }
    }
}
