using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCS5
{
    class animols
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

        public class Dog : animols
        {
            public int spotCount;

            public void Bark()
            {
                Console.WriteLine("Woof!");
                base.happiness += 0.1f;
            }

        }
        public class Cat : animols
        {
            public int cuteness;

            public void Meow()
            {
                Console.WriteLine("Meow");
                base.happiness -= 0.1f;
            }

        }
    }
}
