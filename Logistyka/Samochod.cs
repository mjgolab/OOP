using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistyka
    /*Wytyczne (3):
     * Utwórz projekt biblioteki .NET o nazwie Logistyka, posiadającej klasę o nazwie Samochod w przestrzeni nazw Logistyka.
     * W klasie zdefiniuj pola: nazwa, cenaLitr i spalanieNaStoKm oraz metodę wyliczKosztDojazdu z parametrem odleglosc, zwracającą koszt dojazdu.
     * Napisz stosowny kod metody (koszt = odleglosc / 100 * spalanieNaSto * cenaLitr). 
     * Dodaj do klasy Samochod stosowny konstruktor (pobranie wartości: nazwa, cenaLitr i spalanieNaStoKm) oraz destruktor.*/
{
    class Samochod
    {
        private string nazwa;
        private int cenaLitr;
        private double spalanieNaStoKm;

        public Samochod(string nazwa, int cenaLitr, double spalanieNaStoKm) //Konstruktor klasy Samochod.
        {
            this.nazwa = nazwa;
            this.cenaLitr = cenaLitr;
            this.spalanieNaStoKm = spalanieNaStoKm;
        }
        ~Samochod()
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
        public string PobierzInformacje() //Własna metoda wyświetlająca informacje o obiekcie klasy Samochod.
        {
            return string.Format("Nazwa samochodu: {0}. Koszt paliwa (cena za litr): {1}zł. Spalanie na 100km: {2}.", nazwa, cenaLitr, spalanieNaStoKm);
        }
        
    }
}
