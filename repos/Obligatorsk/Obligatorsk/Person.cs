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
        public string lastName;
        public int birthDate;
        public Person mother;
        public Person father;
        public int deathDate;
        public Person(int _id, string _firstName = null, string _lastName = null, int _birthDate = 0, int _deathDate = 0, Person _father = null, Person _mother = null)
        {
            id = _id;
            firstName = _firstName;
            lastName = _lastName;
            birthDate = _birthDate;
            mother = _mother;
            father = _father;
            deathDate = _deathDate;
        }
        public void Show()
        {
            Console.WriteLine("\n");
            Console.WriteLine("ID: " + id);
            if (firstName != null) Console.WriteLine("Fornavn: " + firstName);
            if (lastName != null)Console.WriteLine("Etternavn: " + lastName);
            if (birthDate != 0) Console.WriteLine("Fødselsår: " + birthDate);
            if (deathDate != 0) Console.WriteLine("Dødsår: " + deathDate);
            if (father != null) Console.WriteLine("Far: " + father.firstName);
            if (mother != null) Console.WriteLine("Mor: " + mother.firstName);
        }

        

    }
}
