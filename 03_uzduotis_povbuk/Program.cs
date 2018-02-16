using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_uzduotis_povbuk
{
    class Kontaktas
    {
        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }
        public string TelNumeris { get; private set; }
        public Kontaktas(string Vardas, string Pavarde, string TelNumeris)
        {
            this.Vardas = Vardas;
            this.Pavarde = Pavarde;
            this.TelNumeris = TelNumeris;
        }

        public void Apibudinti()
        {
            Console.WriteLine("|{0,-22}|{1,-9}|", (Vardas + " " + Pavarde), TelNumeris);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> VyriskuVarduSar = new List<string> { "Petras", "Jonas", "Algis", "Povilas", "Ignas", "Domas", "Tomas", "Ignas", "Mykolas", "Linas" };
            List<string> MoteriskuVarduSar = new List<string> { "Nijole", "Irena", "Aldona", "Lina", "Angele", "Monika", "Agne", "Laura", "Raminta", "Egle" };
            List<string> VyriskuPavardziuSar = new List<string> { "Petraitis", "Jonaitis", "Algirdaitis", "Povilaitis", "Kubilius", "Dominaitis", "Agnietis", "Laurynaitis", "Ramunaitis", "Eglincius" };
            List<string> MoteriskuPavardziuSar = new List<string> { "Petraitiene", "Venckute", "Karaliunaite", "Bagdonaviciene", "Cepuliene", "Kubiliene", "Paulauskiene", "Adamkiene", "Grybauskaite", "Jusyte" };

            List<Kontaktas> KontaktuSar = new List<Kontaktas>();
            Random rng = new Random();

            for (int i = 0; i < 100; i++)
            {
                Kontaktas kont1 = new Kontaktas(VyriskuVarduSar[rng.Next(VyriskuVarduSar.Count - 1)], VyriskuPavardziuSar[rng.Next(VyriskuPavardziuSar.Count - 1)], ("86" + Convert.ToString(rng.Next(1000000, 9999999))));
                Kontaktas kont2 = new Kontaktas(MoteriskuVarduSar[rng.Next(MoteriskuVarduSar.Count - 1)], MoteriskuPavardziuSar[rng.Next(MoteriskuPavardziuSar.Count - 1)], ("86" + Convert.ToString(rng.Next(1000000, 9999999))));
                KontaktuSar.Add(kont1);
                KontaktuSar.Add(kont2);
            }

            Console.WriteLine("{0,-9} {1,-9} {2,10}", "Vardas:", "Pavarde:", "TelNumeris:");
            Console.WriteLine();
            foreach (var kontaktas in KontaktuSar)
            {
                kontaktas.Apibudinti();
            }
        }
    }
}
