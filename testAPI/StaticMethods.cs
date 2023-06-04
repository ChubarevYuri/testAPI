using System.IO;
using System.Linq;
using System.Text.Json;
using testAPI.Objects;

namespace testAPI
{
    public static class StaticMethods
    {
        /// <summary>
        /// Путь к файлу
        /// </summary>
        public const string PATH = "data — копия.json";

        /// <summary>
        /// Возвращает десериализованный файл
        /// </summary>
        public static AllData AllData
        {
            get
            {
                using (StreamReader r = new StreamReader(PATH))
                {
                    return JsonSerializer.Deserialize<AllData>(r.ReadToEnd());
                }
            }
        }
    }
}
