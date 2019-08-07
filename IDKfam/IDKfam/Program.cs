using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDKfam
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.FirstName = "Sverre Magnus";
            person.LastName = "Slettleif";
            person.BirthYear = "2005";

            person.ShowPerson();
        }
    }
}
