using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistyka
    /*Wytyczne(5):
     * Dodaj do biblioteki klasę abstrakcyjną o nazwie Pojazd.
     * W klasie zdefiniuj właściwość o nazwie nazwa oraz polimorficzną (czyt. wirtualną) funkcję o nazwie wyliczKosztDojazdu z parametrem odleglosc.
     * Zdefiniuj dla klasy Samochod dziedziczenie po klasie Pojazd.
     * Przeciąż polimorficznie w klasie Samochod funkcję wyliczKosztDojazdu.
     * Popraw korzystanie z dziedziczonej właściwości nazwa.
     * Napisz aplikację, która korzysta z biblioteki Logistyka - tzn. tworzy obiekt klasy Samochod [Audi; Diesel; Spalanie 5,5 na 100km; koszt paliwa 4zł za litr]
     * i wylicza koszt dojazdu dla odległości 120km.*/
{
    class Samochod : Pojazd //Dziedziczenie. Klasa Samochód dziedziczy elementy klasy Pojazd. Klasa Pojazd posiada jedną właściwość i jedną metodę wirtualną.
    {
        private new string nazwa { get; set; }
        private int cenaLitr { get; set; }
        private double spalanieNaStoKm { get; set; }
        private SilnikTyp Typ { get; set; }

        public Samochod(string nazwa, int cenaLitr, double spalanieNaStoKm) //Konstruktor klasy Samochód.
        {
            this.nazwa = nazwa;
            this.cenaLitr = cenaLitr;
            this.spalanieNaStoKm = spalanieNaStoKm;
        }

        public Samochod(string nazwa, SilnikTyp Typ, int cenaLitr, double spalanieNaStoKm)
            :this(nazwa, cenaLitr, spalanieNaStoKm) //Drugi konstruktor klasy Samochód wraz z zdefiniowanym typem silnika.
        {
            this.Typ = Typ;
        }

        ~Samochod() //Domyślny destruktor klasy Samochód.
        {
            Console.WriteLine("Obiekt {0} klasy Samochód został pomyślnie usunięty.", GetHashCode());
            Console.ReadLine();
        }

        public override double wyliczKosztDojazdu(int odleglosc) //Przeciążona (czyt. nadpisana) metoda zwracająca koszt dojazdu.
        {
            double koszt;
            koszt = Convert.ToDouble(odleglosc) / 100 * spalanieNaStoKm * cenaLitr;
            return koszt;
        }

        public string PobierzInformacje() //Własna metoda wyświetlająca informacje o obiekcie klasy Samochód.
        {
            return string.Format("Nazwa samochodu: {0}. Typ silnika: {1}. Koszt paliwa (cena za litr): {2}zł. Spalanie na 100km: {3}.", nazwa, Typ, cenaLitr, spalanieNaStoKm);
        }
    }
}
