using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCS4
{

    class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                ShowHelpText();
            }
            string kebab = string.Empty;
        }

        private static void ShowHelpText()
        {
            Console.WriteLine("PassordGenerator");
            Console.WriteLine("  Options: ");
            Console.WriteLine("  - l = lower case letter");
            Console.WriteLine("  - L = upper case letter");
            Console.WriteLine("  - d = digit");
            Console.WriteLine("  - s = special character (!\"#¤%&/(){}[]");
            Console.WriteLine("Example: PassordGenerator 14 Llssdd");
            Console.WriteLine("         Min. 1 lower case");
            Console.WriteLine("         Min. 1 upper case");
            Console.WriteLine("         Min. 2 special character");
            Console.WriteLine("         Min. 2 digits");
        }
    }
}
