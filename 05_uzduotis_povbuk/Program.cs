using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_uzduotis_povbuk
{
    static class Konstantos
    {
        public const double PuodukoKaina = 5; // puoduko kaina
        public const double TusinukoKaina = 3;
        public const double ZenkliukoKaina = 2;
    }
    class Imone
    {
        public string Pavadinimas { get; private set; }
        public int Biudzetas { get; private set; }
        public int DarbuotojuSk { get; private set; }
        public List<Darbuotojas> DarbuotojuSarasas = new List<Darbuotojas>();

        public Imone(string Pavadinimas, int Biudzetas, int DarbuotojuSk)
        {
            this.Pavadinimas = Pavadinimas;
            this.Biudzetas = Biudzetas;
            this.DarbuotojuSk = DarbuotojuSk; // darbuotoju skaicius lygus darbuotoju saraso dydziui
            DarbuotojuSarasas = GeneruotiDarbuotojuSar(DarbuotojuSk);
        }

        public static List<Darbuotojas> GeneruotiDarbuotojuSar(int kiekDarbuotoju)
        {
            List<Darbuotojas> DarbuotojuSar = new List<Darbuotojas>();
            string[] VarduMas = { "Povilas", "Andrius", "Rokas", "Linas", "Valdas", "Kestutis", "Ramunas", "Vytautas" };
            string[] MiestuMas = { "Vilnius", "Kaunas", "Klaipeda", "Siauliai", "Panevezys" };

            Random rng = new Random();
            for (int i = 0; i < kiekDarbuotoju; i++) // generuojam random dydzio darbuotoju sarasa
            {
                Darbuotojas d = new Darbuotojas(VarduMas[rng.Next(VarduMas.Length)], MiestuMas[rng.Next(MiestuMas.Length)], rng.Next(11111, 99999));
                DarbuotojuSar.Add(d);
            }
            return DarbuotojuSar;
        }

        public void SpausdintiDarbuotojuAdresuSar()
        {
            foreach (var darbuotojas in DarbuotojuSarasas)
            {
                Console.WriteLine("  {0,-10}{1,-10}",darbuotojas.Miestas, darbuotojas.Pasto_kodas);
            }
        }
    }

    class Darbuotojas
    {
        public string Vardas_Pavarde { get; private set; }
        public string Miestas { get; private set; }
        public int Pasto_kodas { get; private set; }
        public Darbuotojas(string Vardas_Pavarde, string Miestas, int Pasto_kodas)
        {
            this.Vardas_Pavarde = Vardas_Pavarde;
            this.Miestas = Miestas;
            this.Pasto_kodas = Pasto_kodas;
        }
    }

    class Program
    {


        public delegate bool IsChecker(int biudzetas, int darbuotojuSkaicius);
        static bool isPuodukas(int biudzetas, int darbuotojai)
        {
            if (darbuotojai * Konstantos.PuodukoKaina <= biudzetas)
            {
                return true;
            }
            else
                return false;
        }
        static bool isTusinukas(int biudzetas, int darbuotojai)
        {
            if (darbuotojai * Konstantos.TusinukoKaina <= biudzetas)
            {
                return true;
            }
            else
                return false;
        }
        static bool isZenkliukas(int biudzetas, int darbuotojai)
        {
            if (darbuotojai * Konstantos.ZenkliukoKaina <= biudzetas)
            {
                return true;
            }
            else
                return false;
        }

        static void Main(string[] args)
        {
            //----------------------------------------------------------
            Imone imone1 = new Imone("KCS", 100, 5);
            Imone imone2 = new Imone("Gelezinkeliai", 30, 5);
            Imone imone3 = new Imone("PC Mega", 15, 4);
            Imone imone4 = new Imone("Kioskas", 4, 2);
            Imone imone5 = new Imone("UAG tinginiai", 1, 3);
            List<Imone> ImoniuSar = new List<Imone>() { imone1, imone2, imone3, imone4, imone5 };

            IsChecker CheckPuodukas = isPuodukas;
            IsChecker CheckTusinukas = isTusinukas;
            IsChecker CheckZenkliukas = isZenkliukas;

            foreach (var imone in ImoniuSar)
            {
                if (CheckPuodukas(imone.Biudzetas, imone.DarbuotojuSk))
                {
                    Console.WriteLine(imone.Pavadinimas + " sius puodukus:");
                    imone.SpausdintiDarbuotojuAdresuSar();
                }
                else if (CheckTusinukas(imone.Biudzetas, imone.DarbuotojuSk))
                {
                    Console.WriteLine(imone.Pavadinimas + " sius tusinukus:");
                    imone.SpausdintiDarbuotojuAdresuSar();
                }
                else if (CheckZenkliukas(imone.Biudzetas, imone.DarbuotojuSk))
                {
                    Console.WriteLine(imone.Pavadinimas + " sius zenkliukus:");
                    imone.SpausdintiDarbuotojuAdresuSar();
                }
                else
                {
                    Console.WriteLine(imone.Pavadinimas + " neuztenka pinigu dovanoms");
                }
            }


        }
    }

}

