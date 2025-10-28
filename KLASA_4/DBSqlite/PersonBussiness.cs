using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class PersonBussiness
    {
        PersonContext Context;
        public PersonBussiness()
        {
            Context = new PersonContext();
        }

        public List<Person> getPersons() 
        { 
            List<Person> persons = new List<Person>();
            var query = this.Context.Osoby;
            foreach (var person in query)
            {
                persons.Add(person);
            }

            return persons;
        }
    }
}
