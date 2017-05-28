using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistyka
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod Audi = new Samochod("Audi", 4, 5.5);
            Console.WriteLine(Audi.PobierzInformacje());
            Console.WriteLine("Koszt dojazdu dla odległości 120 wynosi {0}.", Audi.wyliczKosztDojazdu(120));
            Console.ReadLine();
        }
    }
}
