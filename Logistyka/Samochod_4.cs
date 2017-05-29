using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistyka
    /*Wytyczne(4):
     * Zamień pola w klasie Samochod na właściwości.
     * Zdefiniuj enumerację o nazwie SilnikTyp oraz wartościach Diesel i Benzyna.
     * Dodaj do klasy Samochod właściwość o nazwie Typ, która będzie korzystać z enumeracji i mieć domyślną wartość Benzyna.
     * Dodaj do klasy Samochod kolejny konstruktor, w którym będzie podawany również typ silnika, a wartość pozostałych właściwości będzie ustawiana poprzez
     * odwołanie do konstruktora definiowanego w poprzednim zadaniu.*/
{
    class Samochod
        {
            private string nazwa { get; set; }
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
            ~Samochod() //Domyślny destruktor dla klasy Samochód.
            {
                Console.WriteLine("Obiekt {0} klasy Samochód został pomyślnie usunięty.", GetHashCode());
                Console.ReadLine();
            }

            public double wyliczKosztDojazdu(int odleglosc) //Metoda zwracająca koszt dojazdu.
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