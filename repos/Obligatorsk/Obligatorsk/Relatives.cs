using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorsk
{
    class Relatives
    {
        static public List<Person> Persons = new List<Person>()
        {
            new Person(1, "Sverre",null,2005 ),
            new Person(2, "Ingrid", null, 2004),
            new Person(3, "Haakon", null, 1973),
            new Person(4, "Mette", null, 1973),
            new Person(5, "Marius", "Borg Høiby", 1997),
            new Person(6, "Harald", null, 1937),
            new Person(7, "Sonja", null, 1937),
            new Person(8, "Olav", null, 1903, 1991),
        };
        static public Person GetPerson(string name)
        {
            foreach (Person person in Persons)
            {
                if (person.firstName == name)
                {
                    return person;
                }
            }
            return null;
        }
        public static void SetRelatives()
        {
            GetPerson("Sverre").father = GetPerson("Haakon");
            GetPerson("Sverre").mother = GetPerson("Mette");
            GetPerson("Ingrid").father = GetPerson("Haakon");
            GetPerson("Ingrid").mother = GetPerson("Mette");
            GetPerson("Marius").mother = GetPerson("Mette");
            GetPerson("Haakon").father = GetPerson("Harald");
            GetPerson("Haakon").mother = GetPerson("Sonja");
            GetPerson("Harald").father = GetPerson("Olav");
        }
        

    }
}
