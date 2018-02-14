using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> mokiniuDictionary = new Dictionary<string, List<int>>();

            int N = 3;
            List<int> paz = new List<int>();
            paz = RandomPazymiai();

            int M = 5;
            var rng = new Random();
            List<int> pazymiai = new List<int>();
            for (int i = 0; i < M; i++)
            {
                int pazymys = rng.Next(0, 11);
                pazymiai.Add(pazymys);
            }


            mokiniuDictionary["Povilas"] = pazymiai;
            mokiniuDictionary["Petras"] = paz;
            mokiniuDictionary["Jonas"] = RandomPazymiai();


            foreach (var mokinys in mokiniuDictionary)
            {
                Console.WriteLine(mokinys);
            }

        }
        /// <summary>
        /// Sugeneruoja lista random pazymiu
        /// </summary>
        /// <returns></returns>
        public static List<int> RandomPazymiai()
        {
            int M = 5;
            var rng = new Random();
            List<int> pazymiai = new List<int>();
            for (int i = 0; i < M; i++)
            {
                int pazymys = rng.Next(0, 11);
                pazymiai.Add(pazymys);
            }
            return pazymiai;
        }
    }
}
