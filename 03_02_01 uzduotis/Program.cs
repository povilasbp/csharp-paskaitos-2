using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _03_02_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("C:/Users/Povilas/Desktop/Kaunas Coding School/csharp paskaitos 2/Antra dalis/03_02_01 uzduotis/bin/Debug/sarasas.txt");
            string viskas = reader.ReadToEnd();
            reader.Close();
            string[] eilute = viskas.Split(';').ToArray();
            Dictionary<string, List<int>> pazymiai = new Dictionary<string, List<int>>();
            
            foreach (var eil in eilute)
            {
                List<string> temporary = eil.Split(' ').ToList();
                string vardas = temporary.First();
               // temporary.Remove(vardas);
                List<int> skaiciai = new List<int>();
                int i = 0;
                foreach (var kazkas in temporary)
                {
                    if(i != 0)
                    {
                        skaiciai.Add(Convert.ToInt32(kazkas));
                    }
                    i++;
                }
                pazymiai.Add(vardas, skaiciai);
            }
            int kiek_sukti = pazymiai.Count;
           for(int i = 0; i < kiek_sukti; i++)
            {
                double maxval = int.MinValue;
                string index = null;

                foreach (var nesamone in pazymiai)
                {
                    if(maxval <= nesamone.Value.Average())
                    {
                        index = nesamone.Key;
                        maxval = nesamone.Value.Average();
                    }
                }
                Console.WriteLine("{0} {1:0.00}", index, pazymiai[index].Average());
                pazymiai.Remove(index);
            }


            foreach (var nesamone in pazymiai)
            {
                nesamone.Value.Max();
                Console.WriteLine("{0}: {1:0.00}", nesamone.Key, nesamone.Value.Average());
            }
          
        }
    }
}
