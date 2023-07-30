using System;
using System.Collections.Generic;

namespace JsonPeoplePet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<People> people = ListPeople.PeopleWithPets();

            string filePath = "people_with_pets.json";

            // Aufruf der Methode, um verschachtelte JSON-Datei zu erstellen
            Serialize.SerializePeopleToJson(people, filePath);

            Console.WriteLine("JSON-Datei wurde erstellt: " + filePath);

            // Deserialisieren und Ausgeben der Personen aus der JSON-Datei
            List<People> deserializedPeople = Deserialize.DeserializePeopleFromJson(filePath);
            Console.WriteLine("Deserialisierte Personen mit Haustieren: \n");
            foreach (var person in deserializedPeople)
            {
                Console.WriteLine("Id: " + person.Id);
                Console.WriteLine("Name: " + person.Name);
                Console.WriteLine("Alter: " + person.Age);
                Console.WriteLine("Adresse: " + person.Adress);
                Console.WriteLine("Telefon: " + person.Phone);
                Console.WriteLine("\n Haustiere: { ");
                foreach (var pet in person.Pets)
                {
                    Console.WriteLine("- Name: " + pet.Name + " " + " Tier: " + pet.Animal);
                }
                Console.WriteLine(" } \n");
            }

            Console.ReadKey();
        }
    }
}
