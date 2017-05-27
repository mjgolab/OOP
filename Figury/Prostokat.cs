using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
    /* Wytyczne:
     * Utwórz projekt biblioteki .NET o nazwie Figury, posiadajacej klasę o nazwie Prostokat w przestrzeni nazw Figury.
     * W klasie Prostokat zdefiniuj pola o nazwach bok1 i bok2, oraz metody (funkcje) pole i obwod. Napisz stosowny kod implementacji metod.
     * Dodaj do klasy Prostokat konstruktor (pobranie wartości boku1 i boku2) oraz destruktor.*/
{
    class Prostokat
    {
        private int bok1, bok2;
        private int obwód, pole;

        public Prostokat(int bok1, int bok2) //Konstruktor z parametrami dla klasy Prostokat.
        {
            this.bok1 = bok1;
            this.bok2 = bok2;
            Console.WriteLine("Został utworzony nowy obiekt!");
        }
        ~Prostokat() //Domyślny destruktor dla klasy Prostokat.
        {
            Console.WriteLine("Obiekt {0} został pomyślnie usunięty.", GetHashCode());
            Console.ReadLine();
        }

        public int Obwód() //Publiczna metoda obliczająca obwód dla obiektu klasy Prostokat.
        {
            obwód = 2 * bok1 + 2 * bok2;
            return obwód;
        }
        public int Pole() //Publiczna metoda obliczająca pole dla obiektu klasy Prostokat.
        {
            pole = bok1 * bok2;
            return pole;
        }
        public string PobierzInformacje() //Własna metoda zwracająca informacje o danym obiekcie klasy Prostokat i jego wartościach.
        {
            return string.Format("Obiekt posiada boki o wymiarach {0} i {1}. Jego obwód wynosi {2}. Jego pole wynosi {3}.", bok1, bok2, obwód, pole);
        }

    }
}
