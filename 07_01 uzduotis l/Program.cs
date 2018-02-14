using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_01_uzduotis_l
{
    class Program
    {
        static List<int> numbers = new List<int>() { 1, 7, 4, 2, 5, 3, 9, 8, 6 };
        // standartinis metodas ieskoti lyginiu skaiciu
        static List<int> RandaLyginius(List<int> skaiciai)
        {
            List<int> lyginiai = new List<int>();
            foreach (var skaicius in skaiciai)
            {
                if(skaicius % 2 == 0)
                {
                    lyginiai.Add(skaicius);
                }
            }
            return lyginiai;
        }
        //--------------------------------------------------------------------


        //public delegate List<int> MyDelegate(List<int>);
        public static bool IsEven(int number)
        {
            return (number % 2 == 0);
        }

        static void Main(string[] args)
        {
            IEnumerable<int> evenNumbers = numbers.Where(IsEven);
            //-----------------------------------------------------------------
            // senas sprendimas, kol nebuvo labda kalbos
            IEnumerable<int> Lyginiai_skaiciai = numbers.Where(delegate (int number) { return (number % 2 == 0); });
            //-----------------------------------------------------------------

            // lambda sprendimas
            IEnumerable<int> even = numbers.Where(x => x % 2 == 0);
            //numbers.Where(x => {Console.WriteLine(x); return true; });
        }
    }
}
