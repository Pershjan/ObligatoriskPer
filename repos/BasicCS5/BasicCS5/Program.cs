using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static BasicCS5.animols;

namespace BasicCS5
{
    class Program
    {
        public static void Main(string[] args)

        {
            Dog spotty = new Dog();
            spotty.name = "Spotty";
            spotty.age = 4;
            spotty.happiness = 7.5f;
            spotty.spotCount = 35;
            spotty.PrintBase();
            spotty.Bark();
            Console.WriteLine("New Happiness: " + spotty.happiness);

            Console.ReadKey();
            Console.WriteLine("---------------------------");

            Cat Heisenberg = new Cat();
            Heisenberg.name = "HeisenBerg";
            Heisenberg.age = 13;
            Heisenberg.happiness = 0.3f;
            Heisenberg.cuteness = 5;
            Heisenberg.PrintBase();
            Heisenberg.Meow();
            Console.WriteLine("New Happiness: " + Heisenberg.happiness);
            Console.ReadKey();
        }
    }
}
