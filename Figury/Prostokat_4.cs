using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
    /*Wytyczne(4):
     * Zamień pola w klasie Prostokąt na właściwości.
     * Zdefiniuj enumerację o nazwie ProstokatTyp oraz wartościach Kwadrat i Prostokat.
     * Dodaj do klasy Prostokat właściwość o nazwie Typ, która będzie korzystać z enumeracji i mieć domyślną wartość Prostokat.
     * Dodaj do klasy Prostokat stosowny konstruktor dla "kwadratu" (z jednym parametrem), w którym oprócz ustawienia wartości boku ustawiany jest również typ figury.
     * Popraw metody Obwód i Pole, aby brały pod uwagę wartość właściwości Typ i w zależności od niej stosowały odpowiednie wzory na pole i obwód.*/
{
    class Prostokat
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

        public void Pole() //Metoda wyliczająca pole prostokąta lub kwadrata dla konkretnego obiektu klasy.
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

        public void Obwód() //Metoda wyliczająca obwód prostokąta lub kwadrata dla konkretnego obiektu klasy.
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
