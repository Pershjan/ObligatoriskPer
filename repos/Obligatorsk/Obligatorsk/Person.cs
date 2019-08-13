using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorsk
{
    public class Person
    {
        public int id;
        public string firstName;
        public int age;
        public string lastName;
        public int birthDate;
        public string mother;
        public string father;
        public string deathDate;
        public Person(int _id, string _firstName, int _age, string _lastName, int _birthDate, string _father, string _mother, string _deathDate = null)
        {
            id = _id;
            firstName = _firstName;
            age = _age;
            lastName = _lastName;
            birthDate = _birthDate;
            mother = _mother;
            father = _father;
            deathDate = _deathDate;
        }
        public void DeathDate()
        {
            if (deathDate != null)
            {
                Console.WriteLine("Dødsår: " + deathDate);
            }

        }

    }
}
