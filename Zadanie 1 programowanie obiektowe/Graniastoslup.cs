using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_1_programowanie_obiektowe
{
    public class Graniastoslup : IObjetosc
    {
        private float wysokoscFigury3D;
        private float szerokoscFigury3D;
        private float dlugoscFigury3D;

        public static string ZobaczWielkosc(Graniastoslup graniastoslup)
        {
            if (graniastoslup.KalkulatorObjetosci() > 400)
                return "Graniastoslup jest duży";
            else if (graniastoslup.KalkulatorObjetosci() > 200)
                return "Graniastoslup jest sredni;";
            else
                return "Graniastoslup jest mały";


        }


        public float WysokoscFigury3D
        {
            get
            {
                return wysokoscFigury3D;
            }
            private set
            {
                if (Figury2D.Metoda.Sprawdz(value))
                {
                    wysokoscFigury3D = value;
                }
                else
                    wysokoscFigury3D = 0;
            }
        }



        public float Dlugosc
        {
            get
            {
                return dlugoscFigury3D;
            }
            private set
            {
                if (Figury2D.Metoda.Sprawdz(value))
                {
                    dlugoscFigury3D = value;
                }
                else
                {
                    dlugoscFigury3D = 0;
                }
            }
        }

        public float Szerokosc
        {
            get
            {
                return szerokoscFigury3D;
            }
            private set
            {
                if (Figury2D.Metoda.Sprawdz(value))
                {
                    szerokoscFigury3D = value;
                }
                else
                {
                    szerokoscFigury3D = 0;
                }
            }
        }


        /// <summary>
        /// Konstruktor do obliczania pola szescianu i prostopadloscianu
        /// </summary>
        /// <param name="eDlugosc">
        /// długosc
        /// </param>
        /// <param name="eSzerokosc">
        /// szerokosc
        /// </param>
        /// <param name="eWysokosc">
        /// wysokosc
        /// </param>
        public Graniastoslup(float eDlugosc, float eSzerokosc, float eWysokosc)
        {

            Dlugosc = eDlugosc;
            Szerokosc = eSzerokosc;
            WysokoscFigury3D = eWysokosc;

        }
        /// <summary>
        /// Oblicza pole szescianu 
        /// </summary>
        /// <returns>
        /// Zwraca pole szescianu
        /// </returns>
        public float ObliczPoleSzescian()
        {
            float pole = 6 * wysokoscFigury3D * wysokoscFigury3D;
            return pole;
        }
        /// <summary>
        /// Oblicza pole prostopadłoscianu
        /// </summary>
        /// <returns>
        /// zwraca pole prostopadłoscianu
        /// </returns>
        public float ObliczPoleProstopadloscianu()
        {
            float pole = 2 * (szerokoscFigury3D * dlugoscFigury3D) +
                2 * (dlugoscFigury3D * wysokoscFigury3D) +
                2 * (szerokoscFigury3D * wysokoscFigury3D);
            return pole;
        }

        public override string ToString()
        {
            return $"Graniastoslup o polu podstawy rownym { szerokoscFigury3D* dlugoscFigury3D} cm^2 i wysokosci {wysokoscFigury3D}";

        }

        /// <summary>
        /// Oblicza objetosc graniastosłupa 
        /// </summary>
        /// <returns>
        /// zwraca objetosc
        /// </returns>
        public float KalkulatorObjetosci()
        {
            return szerokoscFigury3D * dlugoscFigury3D * wysokoscFigury3D;
        }


    }
}
