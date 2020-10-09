using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_1_programowanie_obiektowe
{
    class Kwadrat : Oblicz
    {
        private float dlugosc;


        /// <summary>
        /// Tworzy klase z parametrami. Posiada funkcje do obliczania pola kwadratu
        /// </summary>
        /// <param name="eDlugosc">
        /// Podaj krawedz kwadratu pod nazwą a (Zmienna typu float)
        /// </param>


        public Kwadrat(float eDlugosc)
        {

            Dlugosc = eDlugosc;
        }

        public float Dlugosc
        {
            get
            {
                return dlugosc;
            }
            private set
            {
                if (Figury2D.Metoda.Sprawdz(value))
                {
                    dlugosc = value;
                }
                else
                {
                    dlugosc = 0;
                }
            }
        }



        /// <summary>
        /// Pole kwadratu a^2
        /// </summary>
        override public float ObliczPole()
        {
            float pole = dlugosc * dlugosc;
            return pole;
        }
    }
}
