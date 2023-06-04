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
    [Route("/errors")]
    public class Errors : Controller
    {
        [HttpGet]
        public IEnumerable<FileNameWithErrors> Get()
        {
            Objects.AllData  allData = StaticMethods.AllData;
            List<FileNameWithErrors> files = new List<FileNameWithErrors>();
            foreach (Objects.File file in allData.Files)
            {
                if(!file.Result) { files.Add(new FileNameWithErrors(file)); }
            }

            return files.ToArray();
        }

        public class FileNameWithErrors
        {
            public FileNameWithErrors(Objects.File file)
            {
                Name = file.Name;
                Errors = new List<ErrorToList>();
                foreach (Objects.Error error in file.Errors)
                {
                    Errors.Add(new ErrorToList(error));
                }
            }

            [JsonPropertyName("filename")]
            public string Name { get; set; }
            [JsonPropertyName("errors")]
            public List<ErrorToList> Errors { get; set; }
        }

        public class ErrorToList
        {
            public ErrorToList(Objects.Error error)
            {
                Result = error.Text;
            }

            [JsonPropertyName("error")]
            public string Result { get; set; }
        }
    }
}
