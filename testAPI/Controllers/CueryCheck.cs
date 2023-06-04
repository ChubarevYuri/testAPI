using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace testAPI.Controllers
{
    [ApiController]
    [Route("query/check")]
    public class QueryCheck : Controller
    {
        [HttpGet]
        public Query Get()
        {
            return new Query(StaticMethods.AllData.Files.ToArray());
        }

        public class Query
        {

            public Query(Objects.File[] files)
            {
                const string correctname = "query_";
                Total = 0;
                Correct = 0;
                Errors = 0;
                List<QueryFile> filesList = new List<QueryFile>();
                foreach(Objects.File file in files)
                {
                    if(file.Name != null)
                    {
                        if(file.Name.Length >= correctname.Length)
                        {
                            if (file.Name.ToLower().Substring(0, correctname.Length) == correctname)
                            {
                                Total++;
                                if (file.Result) { Correct++; }
                                else
                                {
                                    Errors++;
                                    filesList.Add(new QueryFile(file));
                                }
                            }
                        }
                    }
                    Names = filesList.ToArray();
                }
            }

            [JsonPropertyName("total")]
            public int Total { get; set; }
            [JsonPropertyName("correct")]
            public int Correct { get; set; }
            [JsonPropertyName("errors")]
            public int Errors { get; set; }
            [JsonPropertyName("filenames")]
            public QueryFile[] Names { get; set; }
        }

        public class QueryFile
        {
            public QueryFile(Objects.File file)
            {
                Name = file.Name;
            }

            [JsonPropertyName("filename")]
            public string Name { get; set; }
        }
    }
}
