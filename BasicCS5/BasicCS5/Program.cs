using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BasicCS5
{
    class Program
    {
    }

    class Animal
    {
        public string name;
        public int age;
        public float happiness;

        public void PrintBase()
        {
            Console.WriteLine("name - " + name);
            Console.WriteLine("age - " + age);
            Console.WriteLine("happiness - " + happiness);
        }

        public class Dog : Animal
        {
            public int spotCount;

            public void Bark()
            {
                Console.WriteLine("Woof!");
                base.happiness += 0.1f;
            }

        }
        class Cat : Animal
        {
            public int cuteness;

            public void Meow()
            {
                Console.WriteLine("Meow");
                base.happiness -= 0.1f;
            }

        }
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
