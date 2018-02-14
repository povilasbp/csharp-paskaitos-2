using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// koldunai uzd1
namespace _04_02_uzduotis
{
    class PersivalgymoException : Exception
    {
        public int kiekis;
        public PersivalgymoException(int kiekis)
        {
            this.kiekis = kiekis;
        }
    }

    class Zaidejas
    {
        public string Vardas { get; private set; }
        public int KiekSuvalge;
        public double valgymo_greitis;
        public bool ar_persivalge;
        public Zaidejas(string vardas, int kieksuvalge)
        {
            Vardas = vardas;
            KiekSuvalge = kieksuvalge;
        }
        public void Valgymo_greicio_skaiciavimas()
        {
            Random rng = new Random();
            int daliklis = rng.Next(120);
            if(daliklis != 0)
            {
                valgymo_greitis = KiekSuvalge / daliklis;
            }
            else
            {
                throw new DivideByZeroException();
            }
        }
    }

    class Program
    {
        static List<Zaidejas> zaidejai = new List<Zaidejas>();
        static void Patikrina_ar_apsivalge()
        {

            foreach (var zaidejass in zaidejai)
            {
                try
                {
                    if (zaidejass.KiekSuvalge > 9)
                    {
                        throw new PersivalgymoException(zaidejass.KiekSuvalge);
                    }
                }
                catch (PersivalgymoException ex)
                {
                    zaidejass.ar_persivalge = true;
                    Console.WriteLine("Persivalge " + zaidejass.KiekSuvalge + " " + zaidejass.Vardas);
                }
            }
        }

        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("C:/Users/Povilas/Desktop/Kaunas Coding School/csharp paskaitos 2/Antra dalis/04_02 uzduotis/bin/Debug/duom.txt");
            try
            {
                string elementai = reader.ReadToEnd();
                string[] eilutes = elementai.Split('\n');
                foreach (var el in eilutes)
                {
                    string[] temp = el.Split(' ');
                    Zaidejas zaid = new Zaidejas(temp.First(), Convert.ToInt32(temp.Last()));
                    zaidejai.Add(zaid);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Patikrina_ar_apsivalge();
                int max = int.MinValue;
                Zaidejas laimetojas = new Zaidejas(null, 0);
                foreach (var zaid in zaidejai)
                {
                    if(zaid.KiekSuvalge > max && !zaid.ar_persivalge)
                    {
                        laimetojas = zaid;
                        max = zaid.KiekSuvalge;
                    }
                }
                Console.WriteLine("Laimejo: {0}", laimetojas.Vardas);
                Console.ReadKey();
            }

            //string visiDuomenys = reader.ReadToEnd();
            //string[] eiluteDuomenu = visiDuomenys.Split('\n').ToArray();
            //List<Zaidejas> ZaidejuSarasas = new List<Zaidejas>();
            //foreach (var eilute in eiluteDuomenu)
            //{
            //    string[] tempKintamasis = eilute.Split(' ');
            //    Zaidejas z = new Zaidejas(tempKintamasis.First(), Convert.ToInt32(tempKintamasis.Last()));
            //    ZaidejuSarasas.Add(z);

            //    foreach (var zaidejas in ZaidejuSarasas)
            //    {
            //        Console.WriteLine(zaidejas.Vardas + " " + zaidejas.KiekSuvalge);
            //    }
            //}




        }
    }
}
