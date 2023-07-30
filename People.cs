using System.Collections.Generic;

namespace JsonPeoplePet
{
    internal class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public List<Pet> Pets { get; set; }

        public People(int id, string name, int age, string adress, string phone, List<Pet> pets)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Adress = adress;
            this.Phone = phone;
            this.Pets = pets;
        }
    }
}
