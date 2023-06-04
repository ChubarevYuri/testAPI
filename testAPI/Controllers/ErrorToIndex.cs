using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace testAPI.Controllers
{
    [ApiController]
    [Route("errors/{index}")]
    public class ErrorToIndex : Controller
    {
        [HttpGet]
        public Errors.FileNameWithErrors Get(int index)
        {
            Objects.AllData  allData = StaticMethods.AllData;
            List<Errors.FileNameWithErrors> files = new List<Errors.FileNameWithErrors>();
            foreach (Objects.File file in allData.Files)
            {
                if(!file.Result) { files.Add(new Errors.FileNameWithErrors(file)); }
            }
            try
            {
                return files.ToArray()[index];
            }
            catch
            {
                if (files.Count == 0)
                {
                    throw new Exception("Index exception. Array length = 0");
                }
                else if (files.Count == 1)
                {
                    throw new Exception("Index exception. Validate value [0]");
                }
                else
                {
                    throw new Exception("Index exception. Validate value [0.." + (files.Count - 1).ToString() + "]");
                }
            }
        }
    }
}
