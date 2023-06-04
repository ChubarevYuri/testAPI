using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using testAPI.Objects;
using System.Text.Json.Serialization;

namespace testAPI.Controllers
{
    [ApiController]
    [Route("/filenames")]
    public class CorrectFileNames : Controller
    {
        [HttpGet]
        public IEnumerable<FileName> Get(bool correct)
        {
            Objects.AllData  allData = StaticMethods.AllData;
            List<FileName> files = new List<FileName>();
            foreach (Objects.File file in allData.Files)
            {
                if(file.Result == correct) { files.Add(new FileName(file)); }
            }

            return files.ToArray();
        }

        public class FileName
        {
            public FileName(string name)
            {
                Name = name;
            }
            public FileName(Objects.File file)
            {
                Name = file.Name;
            }

            [JsonPropertyName("filename")]
            public string Name { get; set; }
        }
    }
}
