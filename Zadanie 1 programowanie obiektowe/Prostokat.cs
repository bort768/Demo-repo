using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_1_programowanie_obiektowe
{
    class Prostokat : Oblicz
    {
        private float dlugosc;
        private float szerokosc;

        /// <summary>
        /// Tworzy klase z parametrami. Posiada funkcje do obliczania pola trójkąta
        /// </summary>
        /// <param name="eDlugosc">
        /// Podaj krawedz trapeza pod nazwą a (Zmienna typu float)
        /// </param>
        /// <param name="eSzerokosc">
        /// Podaj szerokosc b trapezu (Zmienna typu float)
        /// </param> 

        public Prostokat(float eDlugosc, float eSzerokosc)
        {

            Dlugosc = eDlugosc;
            Szerokosc = eSzerokosc;
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

        public float Szerokosc
        {
            get
            {
                return szerokosc;
            }
            private set
            {
                if (Figury2D.Metoda.Sprawdz(value))
                {
                    szerokosc = value;
                }
                else
                {
                    szerokosc = 0;
                }
            }
        }


        /// <summary>
        /// Pole prostokąta 1/2 * (a + b) * h
        /// </summary>
        override public float ObliczPole()
        {
            float pole = dlugosc * szerokosc;
            return pole;
        }
    }
}
