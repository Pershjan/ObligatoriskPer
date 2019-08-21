using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskIgjen
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int BirthYear { get; set; }
        public string LastName { get; set; }
        public int DeathYear { get; set; }
        public Person Mother { get; set; }
        public Person Father { get; set; }

        public Person(int _id/*, string _lastName = null, string _firstName = null, int _birthYear = 0, int _deathYear = 0, Person _mother = null, Person _father = null*/)
        {
            Id = _id;
            //lastName = _lastName;
            //firstName = _firstName;
            //birthYear = _birthYear;
            //deathYear = _deathYear;
            //mother = _mother;
            //father = _father;
        }
    //    public Person()
    //    {
    //        Id;
    //        FirstName;
    //        BirthYear;
    //        LastName;
    //        DeathYear;
    //        Mother;
    //        Father;
    //}
        public void Show()
        {
            Console.WriteLine("\n");
            Console.WriteLine("ID: " + Id);
            if (LastName != null)Console.WriteLine("Etternavn: " + LastName);
            if (FirstName != null)Console.WriteLine("Fornavn: " + FirstName);
            if (BirthYear != 0)Console.WriteLine("Født: " + BirthYear);
            if (Father != null) Console.WriteLine("Far: " + Father.FirstName);
            if (Mother != null) Console.WriteLine("Mor: " + Mother.FirstName);
            if (DeathYear != 0) Console.WriteLine("Død: " + DeathYear);

        }
    }
}
