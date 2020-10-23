using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_1_programowanie_obiektowe
{
    class Trapez : Oblicz
    {
        private float dlugosc;
        private float wysokosc;
        private float szerokosc;

        /// <summary>
        /// Tworzy klase z parametrami. Posiada funkcje do obliczania pola trapez
        /// </summary>
        /// <param name="eDlugosc">
        /// Podaj krawedz trapeza pod nazwą a (Zmienna typu float)
        /// </param>
        /// <param name="eWysokosc">
        /// Podaj wysokosc trapeza h (Zmienna typu float)
        /// </param>
        /// <param name="eSzerokosc">
        /// Podaj szerokosc b trapezu (Zmienna typu float)
        /// </param> 

        public Trapez(float eDlugosc, float eSzerokosc, float eWysokosc):base("Trapez")
        {
            Wysokosc = eWysokosc;
            Dlugosc = eDlugosc;
            Szerokosc = eSzerokosc;
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
        /// Pole trapeza 1/2 * (a + b) * h
        /// </summary>
        public override float ObliczPole()
        {
            float pole = 1 / 2 * (dlugosc + szerokosc) * wysokosc;
            return pole;
        }

        /// <summary>
        /// w sumie to samo co na górze tylko że czytelniejsze
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + $" ma dlugosc {dlugosc}, szerokosc {szerokosc} i wyskosc {wysokosc} jego pole wynosi {1 / 2 * (dlugosc + szerokosc) * wysokosc}";
        }
    }
}
