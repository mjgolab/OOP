using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    abstract class Figura //Klasa bazowa, abstrakcyjna o nazwie Figura. Jest to klasa bazowa dla klasy pochodnej Prostokąt, która po niej dziedziczy dwie metody wirtualne.
    {
        public virtual void Pole() //Wirtualna metoda klasy abstrakcyjnej. Tutaj pusta - brak ciała metody. Metody wirtualne muszą mieć modyfikator dostępu public!
        {

        }

        public virtual void Obwód() //Wirtualna metoda klasy abstrakcyjnej. Tutaj pusta - brak ciała metody. Metody wirtualne muszą mieć modyfikator dostępu public!
        {

        }
    }
}
