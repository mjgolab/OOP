using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistyka
{
    abstract class Pojazd //Klasa bazowa, abstrakcyjna o nazwie Pojazd. Jest to klasa bazowa dla klasy pochodnej Samochód, która dziedziczy po niej jedną właściwość i jedną metodę wirtualną.
    {
        protected string nazwa { get; set; } //Właściwość klasy Pojazd.

        public virtual double wyliczKosztDojazdu(int odleglosc) //Wirtualna metoda klasy Pojazd.
        {
            return odleglosc;
        }
    }
}
