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

            /*Samochod Lamborghini_Benzyna = new Samochod("Lamborghini", 4, 5.5);
            Console.WriteLine(Lamborghini_Benzyna.PobierzInformacje());
            Console.WriteLine("Koszt dojazdu dla odległości 120km wynosi {0}zł.", Lamborghini_Benzyna.wyliczKosztDojazdu(120));
            Console.ReadLine();

            Samochod Lamborghini_Diesel = new Samochod("Lamborghini", SilnikTyp.Diesel, 4, 5.5);
            Console.WriteLine(Lamborghini_Diesel.PobierzInformacje());
            Console.WriteLine("Koszt dojazdu dla odległości 120km wynosi {0}zł.", Lamborghini_Diesel.wyliczKosztDojazdu(120));
            Console.ReadLine();*/

            Samochod Audi = new Samochod("Audi", SilnikTyp.Diesel, 4, 5.5);
            Console.WriteLine(Audi.PobierzInformacje());
            Console.WriteLine("Koszt dojazdu dla odległości 120km wynosi {0}zł.", Audi.wyliczKosztDojazdu(120));
            Console.ReadLine();

        }
    }
}