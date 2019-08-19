using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorsk
{
    class Program
    {
        static public List<Person> Persons = Relatives.Persons;
        static void Main()
        {
            
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
                        foreach (var Person in Relatives.Persons)
                        {
                            Person.Show();
                        }
                        break;
                    case "/id":
                        Console.WriteLine("id nummer:");
                        string id = Console.ReadLine();
                        int x = Int32.Parse(id);

                        for (var i = 0; i<Persons.Count; i++)
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
