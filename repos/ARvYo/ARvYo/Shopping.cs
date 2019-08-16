using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARvYo
{
     public class Shopping
     { 
            public string name;
            public int money;
            public string item;
            public int CashInRegister;
        public void PrintShopping()
        {
            Console.WriteLine("name  - " + name);
            Console.WriteLine("money  - " + money);
            Console.WriteLine("item  - " + item);
        }
        public void PrintShopping2()
        {
            Console.WriteLine("name - " + name);
        }
     }
    public class Customer : Shopping
     {
        public void spend()
        {
            Console.WriteLine("Kjøpt!");
                base.money -= 10;
        }
     }
    public class Worker : Shopping
    {
        public void Receive()
        {
            Console.WriteLine("Solgt!");
            base.CashInRegister += 10;
        }
    }
}
