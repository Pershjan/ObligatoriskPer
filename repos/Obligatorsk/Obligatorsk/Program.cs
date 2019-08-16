using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorsk
{
    class Program
    {
        static public Person[] Persons = new Person[]
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
        static void Main(string[] args)
        {
            
        //PersonList.Add(new Person(1, "Sverre", 14, "Slettleif", 2005));
        //PersonList.Add(new Person(2, "Ingrid", 15, "Slettleif", 2004));
        //PersonList.Add(new Person(3, "Haakon M", 46, "Slettleif", 1973));
        //PersonList.Add(new Person(4, "Mette", 36, "Slettleif", 1983));
        //PersonList.Add(new Person(5, "Marius", 22, "Slettleif", 1997));
        //PersonList.Add(new Person(6, "Harald", 87, "Slettleif", 1937));
        //PersonList.Add(new Person(7, "Sonja", 77, "Slettleif", 1947));
        //PersonList.Add(new Person(8, "Olav", 97, "Slettleif", 1903));

        var sverre = new Person(1, "Sverre", null, 2005);
        var ingrid = new Person(2, "Ingrid", null, 2004);
        var haakon = new Person(3, "Haakon", null, 1973);
        var mette = new Person(4, "Mette", null, 1973);
        var marius = new Person(5, "Marius", "Borg Høiby", 1997);
        var harald = new Person(6, "Harald", null, 1937);
        var sonja = new Person(7, "Sonja", null, 1937);
        var olav = new Person(8, "Olav", null, 1903, 1991);


            GetPerson("Sverre").father = haakon;
            sverre.mother = mette;
            ingrid.father = haakon;
            ingrid.mother = mette;
            marius.mother = mette;
            haakon.father = harald;
            haakon.mother = sonja;
            harald.father = olav;

            string command;
        bool quitNow = false;
            while (!quitNow)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Kommandoer: /hjelp, /liste /id");
                command = Console.ReadLine();
                switch (command)
                {
                    case "/hjelp":
                        Console.WriteLine("Skriv /liste for å vise liste over personer.");
                        Console.WriteLine("Skriv inn /id etterfulgt av id nummer for å velge en person.");
                        break;
                    case "/liste":
                        foreach (var Person in Persons)
                        {
                            Person.Show();
                        }
                        break;
                    case "/id":
                        Console.WriteLine("id nummer:");
                        string id = Console.ReadLine();
                        int x = Int32.Parse(id);

                        for (var i = 0; i<Persons.Length; i++)
                        {
                            if (Persons[i].id.Equals(x))
                            {
                                Persons[i].Show();
                                var parent = Persons[i];

                                foreach (var p in Persons)
                                {
                                    if (p.father == parent)
                                    {
                                        p.Show();
                                    }
                                }
                            }
                        }
                        //foreach (var Person in PersonList)
                        //{
                        //    if (id == Person.id.ToString())
                        //    {
                        //        Console.WriteLine($"ID: {Person.id}\nEtternavn: {Person.lastName}\nFornavn: {Person.firstName}\nAlder: {Person.age}\nFødselsår: {Person.birthDate}");
                        //        Person.DeathDate();
                        //        Console.WriteLine($"Far: {Person.father}\nMor: {Person.mother}");
                        //    }
                        //}
                        break;
                    case "/slutt":
                        quitNow = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ukjent kommando: " + command);
                        break;
                }
            }
        }
        static public Person GetPerson(string name)
        {
            foreach(Person person in Persons)
            {
                if(person.firstName == name)
                {
                    return person;
                }
            }
            return null;
        }
    }
}
