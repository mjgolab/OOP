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
            Prostokat A1 = new Prostokat(5, 3);
            A1.Pole();
            A1.Obwód();
            Prostokat A2 = new Prostokat(14.52, 2);
            A2.Pole();
            A2.Obwód();
            Console.ReadLine();
        }
    }
}
