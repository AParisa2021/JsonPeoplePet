using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace JsonPeoplePet
{
    internal class Serialize
    {
        public static void SerializePeopleToJson(List<People> people, string filePath)
        {
            string json = JsonConvert.SerializeObject(people, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
