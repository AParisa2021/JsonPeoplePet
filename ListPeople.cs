using System.Collections.Generic;

namespace JsonPeoplePet
{
    internal class ListPeople
    {
        public static List<People> PeopleWithPets()
        {
            List<People> people = new List<People>
        {
            new People(1, "Pari Sa", 22, "Sonnenberg. 55, 12557 Hamburg", "0123/7784", new List<Pet>
            {
                new Pet("Fido", "Hund"),
                new Pet("Luna", "Fisch"),
                new Pet("Frido", "Elefant")
            }),
            new People(2, "Chris Miller", 26, "Winterberg. 2, 7780 Triberg", "5789/78521", new List<Pet>
            {
                new Pet("Freddi", "Hund"),
                new Pet("Mimi", "Katze"),
                new Pet("Nemo", "Papagei"),
            }),
            new People(3, "Mathias Mustermann", 19, "Musterstr. 2, 7780 Köln", "0123/6584", new List<Pet>
            {
                new Pet("Bobo", "Vogel"),
                new Pet("Kiki", "Katze")

            })
        };

            return people;
        }
    }
}
