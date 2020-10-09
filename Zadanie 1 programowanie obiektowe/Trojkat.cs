using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_1_programowanie_obiektowe
{

    class Trojkat : Oblicz
    {
        private float dlugosc;
        private float wysokosc;

        /// <summary>
        /// Tworzy klase z parametrami. Posiada metode do obliczania pola trapeza
        /// </summary>
        /// <param name="eDlugosc">
        /// Podaj krawedz trójkąt pod nazwą a
        /// </param>
        /// <param name="eWysokosc">
        /// Podaj wysokosc trójkąt
        /// </param>
        public Trojkat(float eDlugosc, float eWysokosc)
        {
            Wysokosc = eWysokosc;
            Dlugosc = eDlugosc;
        }

        public float Wysokosc
        {
            get { return wysokosc; }
            private set
            {
                if (Figury2D.Metoda.Sprawdz(value))
                {
                    wysokosc = value;
                }
                else
                {
                    wysokosc = 0;
                }
            }
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
        /// Pole trójkąta 1/2 * a * h
        /// </summary>
        override public float ObliczPole()
        {
            float pole = 1 / 2 * dlugosc * wysokosc;


            return pole;
        }
    }
}
