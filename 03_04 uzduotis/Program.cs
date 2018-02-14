using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_04_uzduotis
{
    class Gyvunas <T>
    {
        public string seima;
        public T vardas;
        public double ugis;
        public T svoris;

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Gyvunas<int> suo = new Gyvunas<int>();
            Gyvunas<string> ozka = new Gyvunas<string>();

            suo.svoris = 10;
            ozka.svoris = 10.ToString();
        }
    }
}
