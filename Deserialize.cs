using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;


namespace JsonPeoplePet
{
    internal class Deserialize
    {
        // Methode zum Deserialisieren von Personen aus einer JSON-Datei
        public static List<People> DeserializePeopleFromJson(string filePath)
        {
            string json = File.ReadAllText(filePath);
            List<People> deserializedPeople = JsonConvert.DeserializeObject<List<People>>(json);
            return deserializedPeople;
        }
    }
}

