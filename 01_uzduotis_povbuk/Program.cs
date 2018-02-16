using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_uzduotis_povbuk
{
    class Mokykla
    {
        public int KlasesSkaicius { get; private set; }
        public char KlasesRaide { get; private set; }
        public int MokiniuSkaicius { get; private set; }
        public int MokymosiPradziosMetai { get; private set; }

        public Mokykla(int KlasesSkaicius, char KlasesRaide, int MokiniuSkaicius, int MokymosiPradziosMetai)
        {
            this.KlasesSkaicius = KlasesSkaicius;
            this.KlasesRaide = KlasesRaide;
            this.MokiniuSkaicius = MokiniuSkaicius;
            this.MokymosiPradziosMetai = MokymosiPradziosMetai;
        }

        public int KiekMetuMokosi()
        {
            return (DateTime.Now.Year - MokymosiPradziosMetai);
        }
    }

    class Klase : Mokykla
    {
        public List<string> MokiniuVarduSar;
        public int[] MokiniuVidurkiuMas;

        public Klase(int KlasesSkaicius, char KlasesRaide, int MokiniuSkaicius, int MokymosiPradziosMetai, List<string> vardai, int[] vidurkiai) : base(KlasesSkaicius, KlasesRaide, MokiniuSkaicius, MokymosiPradziosMetai)
        {
            MokiniuVarduSar = vardai;
            MokiniuVidurkiuMas = vidurkiai;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // DUOMENU IVEDIMAS-----------------------------------------------------------------------------------------------------------------------
            List<string> varduSar = new List<string>() { "Povilas", "Andrius", "Augustinas", "Lukas", "Dziugas", "Alma", "Simona", "Julija", "Indre" };
            int[] vidurkiuMas = new int[varduSar.Count];

            Random rng = new Random();
            for (int i = 0; i < vidurkiuMas.Length; i++)
            {
                vidurkiuMas[i] = rng.Next(0, 11);
            }
            Klase klase1 = new Klase(12, 'c', 25, 2008, varduSar, vidurkiuMas);
            // ---------------------------------------------------------------------------------------------------------------------------------------
            // DUOMENU ISVEDIMAS ---------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("{0}{1} klaseje yra {2} mokiniai, kurie mokosi nuo {3}", klase1.KlasesSkaicius, klase1.KlasesRaide, klase1.MokiniuSkaicius, klase1.MokymosiPradziosMetai);
            for (int i = 0; i < klase1.MokiniuVarduSar.Count; i++)
            {
                Console.WriteLine("{0} {1,-11} {2,-3}", i + 1, klase1.MokiniuVarduSar[i], klase1.MokiniuVidurkiuMas[i]);
            }
            //----------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
