using System;

namespace Zadanie_1_programowanie_obiektowe
{
    /// <summary>
    /// Program do obliczania pól róznych figur
    /// 
    /// Trzeba zaiplementować klase trapez i kolo
    /// Szukaj błędów
    /// Klasa Obliczenia jest tylko dla zadania z wykozystaniem override
    /// Można stworzyć dwa menu do figur 2d i 3d  
    /// Na razie program działa srednio
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            // Pętla do wprowadzania zmienny które mają być float'ami/int'ami
            while (true)
            {
                // menu do wysietlania 
                Console.WriteLine("Wybierz figure dla której chcesz obliczyć pole ");
                Console.WriteLine("            Figury 2D                      ");
                Console.WriteLine("1.Kwadrat");
                Console.WriteLine("2.Prostokąt");
                Console.WriteLine("3.trójkąt");
                Console.WriteLine("            Figury 3D                      ");
                Console.WriteLine("4.Szescian");
                Console.WriteLine("5.Prostopadłościan");
                Console.WriteLine("6.Wylosowanie n liczby graniastoslupow");
                Console.WriteLine("9.EXIT");

                try
                {
                    // podana wartosc z klawiatury potrzebna do funkcji NumerMenu
                    Console.Write("Podaj wartość z menu: ");
                    int i = Convert.ToInt32(Console.ReadLine());
                    if (i == 9)
                    {
                        Environment.Exit(0);
                    }
                    float dlugosc = 0;
                    // wprowadzenie dlugosci (a)
                    if (i != 6)
                    {
                        Console.Write("Wprowadz długość: ");
                        dlugosc = Convert.ToInt32(Console.ReadLine());
                    }
                    // Zmienne do nie wywalania błedu z odwołanie do metody NumerMenu
                    float wysokoscFigury3D = 0;
                    float wysokoscFigury2D = 0;
                    float szerokosc = 0;


                    if (i == 4)
                    {
                        wysokoscFigury3D = dlugosc;
                        szerokosc = dlugosc;
                    }


                    // niepotrzebana Ci szerokosc w kawdracie lub trójkacie 
                    if (i == 2  || i == 5 )
                    {
                        //wprowadzenie szerokosci(b)
                        Console.Write("Wprowadz szerokość: ");
                        szerokosc = Convert.ToInt32(Console.ReadLine());
                    }


                    //wprowadzenie wysokosci z if do trójkąta
                    if (i == 3)
                    {
                        Console.Write("Wprowadz wysokość trójkąta: ");
                        wysokoscFigury2D = Convert.ToInt32(Console.ReadLine());
                    }

                    //
                    if (i == 5)
                    {
                        Console.Write("Wprowadz wysokość danej bryły: ");
                        wysokoscFigury3D = Convert.ToInt32(Console.ReadLine());
                    }
                    if (i == 6)
                    {
                        Console.Write("Wprowadz ile ma zostać stowrzone losowych graniastoslupow: ");
                        int ilosc = Convert.ToInt32(Console.ReadLine());
                        Random random = new Random();
                        Graniastoslup[] graniastoslups = new Graniastoslup[ilosc];
                        for (int j = 0; j < ilosc; j++) // chyba ładniej było by użyć foreach
                        {
                            dlugosc = random.Next(1, 20);
                            szerokosc= random.Next(1, 20);
                            wysokoscFigury3D = random.Next(1, 20);

                            graniastoslups[j] = new Graniastoslup(dlugosc, szerokosc, wysokoscFigury3D);
                            Console.WriteLine(graniastoslups[j].ToString());
                            Console.WriteLine(Graniastoslup.ZobaczWielkosc(graniastoslups[j]));
                        }

                    }
                    if (i != 6)
                    {
                        // Metoda switch
                        NumerMenu(i, dlugosc, szerokosc, wysokoscFigury2D, wysokoscFigury3D);
                    }
                    break;
                }

                catch (Exception e)
                {
                    Console.WriteLine("Ups! coś poszło nie tak: " + e.Message);
                    Console.Write("Wcisnij dowolny klawaisz żeby wrócić do wprowadzania danych");
                    Console.ReadLine();
                }


            }


        }

        /// <summary>
        /// Wybiera podaną wartosc
        /// </summary>
        /// <param name="menuNumber">
        /// Podaj wartosc z menu
        /// </param>
        /// <param name="a">
        /// Jest to długość boku 
        /// </param>
        /// <param name="b">
        /// Jest to szerkość boku
        /// </param>
        /// <param name="h">
        /// Jest to wysokosc trójkąta jesli jest (domyślna wartosc powinna być rówan 0)
        /// </param>
        /// <param name="wysokocsFigury3D">
        /// Wysokość figury 3D który domyślnie powinien być ustawiony na 0
        /// </param>
        /// <returns>
        /// Zwraca wyniki pol
        /// </returns>
        static void NumerMenu(int menuNumber, float a, float b, float h, float wysokocsFigury3D)
        {
            //int wynik;


            switch (menuNumber - 1)
            {
                case 0:
                    Kwadrat kwadrat = new Kwadrat(a);
                    //Console.WriteLine("Pole kwadrata wynosi: " + kwadrat.ObliczPole() + " cm^2");
                    Console.WriteLine(kwadrat.ToString());
                    break;
                case 1:
                    Prostokat prostokat = new Prostokat(a, b);
                    //Console.WriteLine("Pole Prostokąta wynosi: " + prostokat.ObliczPole() + " cm^2");
                    Console.WriteLine(prostokat.ToString());
                    break;
                case 2:
                    Trojkat trojkat = new Trojkat(a, h);
                    Console.WriteLine("Pole trójkąt wynosi: " + trojkat.ObliczPole() + " cm^2");
                    Console.WriteLine(trojkat.ToString());
                    break;
                case 3:
                    var klocek = new Graniastoslup(a, b, wysokocsFigury3D);
                    //Console.WriteLine("Pole szescianiu wynosi: " + klocek.ObliczPoleSzescian() + " cm^2");
                    Console.WriteLine(klocek.ToString());
                    Console.WriteLine(Graniastoslup.ZobaczWielkosc(klocek));
                    break;
                case 4:
                    var prostopadloscian = new Graniastoslup(a, b, wysokocsFigury3D);
                   //Console.WriteLine("Pole szescianiu wynosi: "
                   //    + prostopadloscian.ObliczPoleProstopadloscianu() + " cm^2");
                    Console.WriteLine(prostopadloscian.ToString());
                    Console.WriteLine(Graniastoslup.ZobaczWielkosc(prostopadloscian));
                    break;


            }
        }
    }
}
