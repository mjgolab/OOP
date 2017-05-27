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
            Prostokat A = new Prostokat(5,3);
            A.Obwód();
            A.Pole();
            Console.WriteLine(A.PobierzInformacje());
           
            Console.ReadLine();
        }
    }
}
