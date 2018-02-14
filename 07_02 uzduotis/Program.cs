using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 4;
            Func<int, int> funkcija = (x) => x * x;
            Console.WriteLine(funkcija.Invoke(d));
        }
    }
}
