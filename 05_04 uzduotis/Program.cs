using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_04_uzduotis
{
    class Program
    {
        public delegate void Didziosiomis(string tekstas);
        public delegate TResult Func<T, TResult>(T zodis);
        public static string PaverciaDidziosiomisRaidemis(string tekstas)
        {
            return tekstas.ToUpper();
        }
        static void Main(string[] args)
        {
            List<string> Zodziai = new List<string>();
            Console.Write("Iveskite teksta: " );
            string text = Console.ReadLine();
            Zodziai.Add(text);
            Zodziai.Add("bla bla bla");
            Func<string, string> conv = PaverciaDidziosiomisRaidemis;
            List<string> zemi = Zodziai.ConvertAll(x => conv(x));
            foreach (var zod in zemi)
            {
                Console.WriteLine(zod);
            }
        }
    }
}
