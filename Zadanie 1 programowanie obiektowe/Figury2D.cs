using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_1_programowanie_obiektowe
{
    public class Figury2D
    {

        public class Metoda
        {
            /// <summary>
            /// Sprawdza czy liczba jest mniejsza od zera. Funkcja zwraca wratosc true/false
            /// </summary>
            /// <param name="liczba">
            /// Podaj liczbe jako value
            /// </param>
            public static bool Sprawdz(float liczba)
            {
                if (liczba >= 0)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Podana Wartosc " + liczba + " jest mniejsza od zera");
                    return false;
                }


            }
        }

    }
}
