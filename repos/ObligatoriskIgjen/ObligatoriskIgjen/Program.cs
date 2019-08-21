using System;
using System.Collections.Generic;

namespace ObligatoriskIgjen
{
    class Program
    {
        static public List<Person> PersonList = new List<Person>();
        static void Main(string[] args)
        {

            var sverre = new Person(1) { Id = 1, FirstName = "Sverre", BirthYear = 2005 };
            var ingrid = new Person(2) { Id = 2, FirstName = "Ingrid", BirthYear = 2004 };
            var haakon = new Person(3) { Id = 3, FirstName = "Haakon", BirthYear = 1973 };
            var mette = new Person(4) { Id = 4, FirstName = "Mette", BirthYear = 1973 };
            var marius = new Person(5) { Id = 5, FirstName = "Marius", LastName = "Borg Høiby", BirthYear = 1997 };
            var harald = new Person(6) { Id = 6, FirstName = "Harald", BirthYear = 1937 };
            var sonja = new Person(7) { Id = 7, FirstName = "Sonja", BirthYear = 1937 };
            var olav = new Person(8) { Id = 8, FirstName = "Olav", BirthYear = 1903 };

            sverre.Father = haakon;
            sverre.Mother = mette;
            ingrid.Father = haakon;
            ingrid.Mother = mette;
            marius.Mother = mette;
            haakon.Father = harald;
            haakon.Mother = sonja;
            harald.Father = olav;

            PersonList.Add(sverre);
            PersonList.Add(ingrid);
            PersonList.Add(haakon);
            PersonList.Add(mette);
            PersonList.Add(marius);
            PersonList.Add(harald);
            PersonList.Add(sonja);
            PersonList.Add(olav);

            string command;
            bool quitNow = false;
            while (!quitNow)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                command = Console.ReadLine();
                switch (command)
                {
                    case "hjelp":
                        Console.WriteLine("liste = liste over alle personer");
                        Console.WriteLine("vis etterfulgt av id nummer viser individuelle");
                        break;
                    case "liste":
                        foreach (Person Person in PersonList)
                        {
                            Person.Show();
                            System.Threading.Thread.Sleep(200);
                        }
                        break;
                    case "vis":
                        Console.WriteLine("id nummer: ");
                        string Id = Console.ReadLine();
                        int x = Int32.Parse(Id);
                        foreach (Person person in PersonList)
                        {
                            if (person.Id == x)
                            {
                                person.Show();
                                foreach (Person kid in PersonList)
                                {
                                    if (kid.Father == person || kid.Mother == person)
                                    {
                                        kid.Show();
                                    }
                                }
                            }
                        }
                        break;
                    case "slutt":
                        quitNow = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ukjent kommando: " + command);
                        break;
                }
                
            }
            
        }
    }
}
