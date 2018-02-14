using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_01_uzduotis
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Dictionary<string, int> TelefonuKnygele = new Dictionary<string, int>();
            TelefonuKnygele["Povilas Bukelis"] = 862222222;
            TelefonuKnygele["Policija"] = 112;
            TelefonuKnygele.Add("Greitoji", 03);

            foreach (var tt in TelefonuKnygele)
            {
                Console.WriteLine(tt);
            }

            Console.WriteLine();
            List<int> listukas = new List<int>();

            for(int i = 0; i < 10; i++)
            {
                Random rng = new Random();
                listukas.Add(rng.Next(1, 200));
            }
            int countai = listukas.Count;
            listukas.Insert(countai/2, 10);
            Console.WriteLine(listukas.ElementAt(5));





        }
    }
}
