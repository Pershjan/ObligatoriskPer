using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCS8
{
    //Generics
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Utility.CompareValue(10, 10));
            Console.WriteLine(Utility.CompareTypes("hello", 10));

            Console.ReadKey();
        }
    }

    class Utility
    {
        public static bool CompareValue<T01, T02>(T01 value01, T02 value02)
        {
            return value01.Equals(value02);
        }
        public static bool CompareTypes<T01, T02>(T01 type01, T02 type02)
        {
            return typeof(T01).Equals(typeof(T02));
        }
    }
}
