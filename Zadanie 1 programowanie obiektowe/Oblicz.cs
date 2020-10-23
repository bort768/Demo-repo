using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_1_programowanie_obiektowe
{
    /// <summary>
    /// Klasa tylko do nadpisywania (żeby zrobić zadanie)
    /// </summary>
    public abstract class Oblicz
    {
        public string Name { get; private set; }

        public Oblicz():this("ksztalt")
        {
                
        }
        public Oblicz(string name)
        {
            Name = name;
        }
        public abstract float ObliczPole();

        public override string ToString()
        {
            return Name;
        }

    }
}