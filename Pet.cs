namespace JsonPeoplePet
{
    internal class Pet
    {
     
            public string Name { get; set; }

            public string Animal { get; set; }

            public Pet(string name, string animal)
            {
                Name = name;
                Animal = animal;
            }
        }    
}
