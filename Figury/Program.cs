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
            Prostokat prostokąt = new Prostokat(5, 3);
            prostokąt.Pole();
            prostokąt.Obwód();
            Console.ReadLine();

            Prostokat kwadrat = new Prostokat(4);
            kwadrat.Pole();
            kwadrat.Obwód();
            Console.ReadLine();
        }
    }
}
