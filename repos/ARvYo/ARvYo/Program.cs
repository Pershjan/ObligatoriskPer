using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARvYo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer leif = new Customer();
            leif.name = "leif";
            leif.money = 50;
            leif.item = "bananer";
            leif.PrintShopping();
            leif.spend();
            Console.WriteLine("Leifs ny saldo: " + leif.money);

            Console.ReadKey();

            Worker dame = new Worker();
            dame.name = "Dame";
            dame.CashInRegister = 100;
            dame.PrintShopping2();
            Console.WriteLine("Saldo i register: " + dame.CashInRegister);
            dame.Receive();
            Console.WriteLine("Ny saldo i register: " + dame.CashInRegister);
            Console.ReadKey();

        }
    }
}
