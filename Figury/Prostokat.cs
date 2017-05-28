using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
    /* Wytyczne(3):
     * Utwórz projekt biblioteki .NET o nazwie Figury, posiadajacej klasę o nazwie Prostokat w przestrzeni nazw Figury.
     * W klasie Prostokat zdefiniuj pola o nazwach bok1 i bok2, oraz metody (funkcje) pole i obwod. Napisz stosowny kod implementacji metod.
     * Dodaj do klasy Prostokat konstruktor (pobranie wartości boku1 i boku2) oraz destruktor.*/
{
    class Prostokat
    {
        private double bok1, bok2;

        public Prostokat(double bok1, double bok2) //Konstruktor klasy Prostokąt.
        {
            this.bok1 = bok1;
            this.bok2 = bok2;
        }
        ~Prostokat() //Destruktor dla klasy Prostokąt.
        {
            Console.WriteLine("Obiekt {0} klasy Prostokąt został pomyślnie usunięty.", GetHashCode());
            Console.ReadLine();
        }

        public void Pole() //Metoda wyliczająca pole prostokąta dla konkretnego obiektu klasy.
        {
            double pole;
            pole = bok1 * bok2;
            Console.WriteLine("Pole prostokąta wynosi {0}.", pole);
        }

        public void Obwód() //Metoda wyliczająca obwód prostokąta dla konkretnego obiektu klasy.
        {
            double obwód;
            obwód = 2 * bok1 + 2 * bok2;
            Console.WriteLine("Obwód prostokąta wynosi {0}.", obwód);
        }
    }
}