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

        public Person(int _id)
        {
            Id = _id;
        }

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
