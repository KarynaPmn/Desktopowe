using System.Collections.Generic;

namespace Formularz
{
    internal class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
        public List<Person> People { get; set; }

        public Person(string name, string gender, string description)
        {
            Name = name;
            Gender = gender;
            Description = description;
        }

        public Person() 
        {
            People = new List<Person>();
        }
    }
}
