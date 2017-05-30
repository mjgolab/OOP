using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
    /*Wytyczne(5):
     * Dodaj do biblioteki klasę abstrakcyjną o nazwie Figura.
     * W klasie Figura zdefiniuj dwie polimorficzne (czyt. wirtualne) funkcje o nazwie pole i obwód.
     * Zdefiniuj dla klasy Prostokąt dziedziczenie po klasie Figura.
     * Przeciąż polimorficznie w klasie Prostokąt funkcje pole i obwód.
     * Napisz aplikację, która korzysta z biblioteki Figury - tzn. tworzy obiekt klasy Prostokąt [kwadrat, długość boku to 5] i wylicza pole.*/
{
    class Prostokat : Figura //Dziedziczenie. Klasa Prostokąt dziedziczy elementy klasy Figura. Klasa Figura posiada dwie metody klasy abstrakcyjnej.
    {
        private double bok1 { get; set; }
        private double bok2 { get; set; }
        private ProstokatTyp Typ { get; set; }

        public Prostokat(double bok1, double bok2) //Konstruktor klasy Prostokąt dla obiektów typu prostokąt.
        {
            this.bok1 = bok1;
            this.bok2 = bok2;
        }
        
        public Prostokat(double bok1) //Drugi konstruktor klasy Prostokąt dla obiektów typu kwadrat.
        {
            this.bok1 = bok1;
            Typ = ProstokatTyp.Kwadrat;
        }

        ~Prostokat() //Destruktor klasy Prostokąt.
        {
            Console.WriteLine("Obiekt {0} klasy Prostokąt został pomyślnie usunięty.", GetHashCode());
            Console.ReadLine();
        }

        override public void Pole() //Przeciążona (czyt. nadpisana) [słowo kluczowe: override] metoda wyliczająca pole prostokąta lub kwadrata dla konkretnego obiektu klasy.
        {
            double pole;
            if (Typ == ProstokatTyp.Kwadrat)
            {
                pole = bok1 * bok1;
                Console.WriteLine("Pole kwadratu wynosi {0}.", pole);
            }
            else
            {
                pole = bok1 * bok2;
                Console.WriteLine("Pole prostokąta wynosi {0}.", pole);
            }
        }

        override public void Obwód() //Przeciążona (czyt. nadpisana) [słowo kluczowe: override] metoda wyliczająca obwód prostokąta lub kwadrata dla konkretnego obiektu klasy.
        {
            double obwód;
            if (Typ == ProstokatTyp.Kwadrat)
            {
                obwód = 4 * bok1;
                Console.WriteLine("Obwód kwadratu wynosi {0}.", obwód);
            }
            else
            {
                obwód = 2 * bok1 + 2 * bok2;
                Console.WriteLine("Obwód prostokąta wynosi {0}.", obwód);
            }
        }
    }
}
