using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_02_uzduotis
{
    class Program
    {
        public delegate void ManoDelegatas(string zinute);
        public event ManoDelegatas ManoIvykis;

        public void IvykioApdorojimas(string message) // sugeneruoja ivyki ir ji apdoroja
        {
            if(ManoIvykis != null)
            {
                ManoIvykis(message);
            }
        }

        public static void IvykisIvyko(string zinute) // metodas iskvieciamas ivykio
        {
            Console.WriteLine("Jusu zinute yra: " + zinute);
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            p.ManoIvykis += new ManoDelegatas(IvykisIvyko); // subscribiname metoda => ivykis iskvies si metoda

            // Prasoma duomenu
            Console.WriteLine("Iveskite zinute: ");
            string zinute = Console.ReadLine();
            // Generuojamas ivykis
            p.IvykioApdorojimas(zinute);

        }
    }
}
