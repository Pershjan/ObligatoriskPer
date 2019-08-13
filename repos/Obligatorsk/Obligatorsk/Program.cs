using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorsk
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> PersonList = new List<Person>();
            PersonList.Add(new Person(1, "Sverre", 14, "Slettleif", 2005, "Haakon M(id3)", "Mette(id4)"));
            PersonList.Add(new Person(2, "Ingrid", 15, "Slettleif", 2004, "Haakon M(id3)", "Mette(id4)"));
            PersonList.Add(new Person(3, "Haakon M", 46, "Slettleif", 1973,"Olav(id8)", "Sonja(id7)"));
            PersonList.Add(new Person(4, "Mette", 36, "Slettleif", 1983, "Olav(id8)", "Sonja(id7)"));
            PersonList.Add(new Person(5, "Marius", 22, "Slettleif", 1997, "Olav(id8)", "Ukjent"));
            PersonList.Add(new Person(6, "Harald", 87, "Slettleif", 1937, "Olav(id8)", "Ukjent"));
            PersonList.Add(new Person(7, "Sonja", 77, "Slettleif", 1947, "Ukjent", "Ukjent"));
            PersonList.Add(new Person(8, "Olav", 97, "Slettleif", 1903, "Ukjent", "Ukjent", "2000"));
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
                        foreach (var Person in PersonList)
                        {
                            Console.WriteLine($"ID: {Person.id}\nEtternavn: {Person.lastName}\nFornavn: {Person.firstName}\nAlder: {Person.age}\nFødselsår: {Person.birthDate}");
                            Person.DeathDate();
                            System.Threading.Thread.Sleep(200);
                        }
                        break;
                    case "/id":
                        Console.WriteLine("id nummer:");
                        string id = Console.ReadLine();
                        foreach (var Person in PersonList)
                        {
                            if (id == Person.id.ToString())
                            {
                                Console.WriteLine($"ID: {Person.id}\nEtternavn: {Person.lastName}\nFornavn: {Person.firstName}\nAlder: {Person.age}\nFødselsår: {Person.birthDate}");
                                Person.DeathDate();
                                Console.WriteLine($"Far: {Person.father}\nMor: {Person.mother}");
                            }
                        }
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
    }
}
