using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Prostokat prostokąt = new Prostokat(5, 3);
            prostokąt.Pole();
            prostokąt.Obwód();
            Console.ReadLine();

            Prostokat kwadrat = new Prostokat(4);
            kwadrat.Pole();
            kwadrat.Obwód();
            Console.ReadLine();*/

            Prostokat kwadrat_na_5 = new Prostokat(5); //Tworzymy obiekt klasy Prostokąt za pomocą konstruktora klasy dla "kwadratu" z długością boku 5.
            kwadrat_na_5.Pole(); //Wywołujemy metodę dla obiektu, aby zostało obliczone jego pole.
            Console.ReadLine();
        }
    }
}
