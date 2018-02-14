using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Skaicius
{
    public string skaicius { get; private set; }
    public int kiek { get; private set; }

    public Skaicius()
    {

    }
    public Skaicius(string skaicius, int kiek)
    {
        this.skaicius = skaicius;
        this.kiek = kiek;
    }
}

namespace Beatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            string N;
            Console.Write("Iveskite skaiciu: ");
            N = Console.ReadLine();

            Unikalus(N);

            //foreach (var skaic in SkaiciuSarasas)
            //{
            //    if(skaic.kiek <= 1)
            //    Console.WriteLine(skaic.skaicius + " " + skaic.kiek);
            //}
        }

        public static void Unikalus(string N)
        {
            string vienasSkaicius = new string(N.Where(Char.IsDigit).ToArray()); // N issiskaidom i atskirus skaicius string masyve
            List<Skaicius> SkaiciuSarasas = new List<Skaicius>(); // skaiciu objektu sarasas (skaicius, pasikartojimas)
            //List<string> unikalus = new List<string>();
            int[] kiek = new int[10]; // kiekvieno skaiciaus pasikartojimai 0-9

            for (int i = 0; i < vienasSkaicius.Length; i++)
            {
                switch (vienasSkaicius[i]) // skaiciuojam pasikartojimus, dedam i skaiciu objektu sarasa skaiciu ir pasikartojima
                {
                    case '0':
                        kiek[0]++;
                        Skaicius s0 = new Skaicius(vienasSkaicius[i].ToString(), kiek[0]);
                        SkaiciuSarasas.Add(s0);
                        break;
                    case '1':
                        kiek[1]++;
                        Skaicius s1 = new Skaicius(vienasSkaicius[i].ToString(), kiek[1]);
                        SkaiciuSarasas.Add(s1);
                        break;
                    case '2':
                        kiek[2]++;
                        Skaicius s2 = new Skaicius(vienasSkaicius[i].ToString(), kiek[2]);
                        SkaiciuSarasas.Add(s2);
                        break;
                    case '3':
                        kiek[3]++;
                        Skaicius s3 = new Skaicius(vienasSkaicius[i].ToString(), kiek[3]);
                        SkaiciuSarasas.Add(s3);
                        break;
                    case '4':
                        kiek[4]++;
                        Skaicius s4 = new Skaicius(vienasSkaicius[i].ToString(), kiek[4]);
                        SkaiciuSarasas.Add(s4);
                        break;
                    case '5':
                        kiek[5]++;
                        Skaicius s5 = new Skaicius(vienasSkaicius[i].ToString(), kiek[5]);
                        SkaiciuSarasas.Add(s5);
                        break;
                    case '6':
                        kiek[6]++;
                        Skaicius s6 = new Skaicius(vienasSkaicius[i].ToString(), kiek[6]);
                        SkaiciuSarasas.Add(s6);
                        break;
                    case '7':
                        kiek[7]++;
                        Skaicius s7 = new Skaicius(vienasSkaicius[i].ToString(), kiek[7]);
                        SkaiciuSarasas.Add(s7);
                        break;
                    case '8':
                        kiek[8]++;
                        Skaicius s8 = new Skaicius(vienasSkaicius[i].ToString(), kiek[8]);
                        SkaiciuSarasas.Add(s8);
                        break;
                    case '9':
                        kiek[9]++;
                        Skaicius s9 = new Skaicius(vienasSkaicius[i].ToString(), kiek[9]);
                        SkaiciuSarasas.Add(s9);
                        break;
                    default:
                        break;
                }
            }
            string sarasasStringe = "1 ";

            foreach (var skaic in SkaiciuSarasas) // eina per visus saraso skaicius 
            {
                if(skaic.kiek == 1) // jei pasikartoja tik 1 karta
                sarasasStringe.Insert(sarasasStringe.Length-1, skaic.ToString()); // prideda prie stringo pabaigos skaiciu is saraso
            }
            Console.WriteLine(sarasasStringe[0]+sarasasStringe[1]+sarasasStringe[2]+sarasasStringe[4]);
        }
    }
}
