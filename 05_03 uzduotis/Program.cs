using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_03_uzduotis
{
    public class Zmogus
    {
        public string Vardas { get; private set; }
        public int Amzius { get; private set; }

        public Zmogus(string vardas, int amzius)
        {
            Vardas = vardas;
            Amzius = amzius;
        }
    }

    class Program
    {
        public delegate bool IsChecker(int age);
        static bool isChild(int age)
        {
            if (age < 14)
            {
                return true;
            }
            else
                return false;
        }
        static bool isAdult(int age)
        {
            if (age >= 14 && age < 65)
            {
                return true;
            }
            else
                return false;
        }
        static bool isSenior(int age)
        {
            if (age >= 65)
            {
                return true;
            }
            else
                return false;
        }


        static void Main(string[] args)
        {
            List<Zmogus> ZmoniuSarasas = new List<Zmogus>();
            string[] vardai = { "Ona", "Jonas", "Petras", "Janina", "Saule", "Albertas", "Rokas", "Vilma", "Silvija" };
            Random rng = new Random();
            
            for(int i = 0; i < 30; i++)
            {
                Zmogus z = new Zmogus(vardai[rng.Next(0, vardai.Length)], rng.Next(0, 80));
                ZmoniuSarasas.Add(z);
            }
            IsChecker checkC = isChild;
            IsChecker checkA = isAdult;
            IsChecker checkS = isSenior;

            int index = 1;
            foreach (var zmo in ZmoniuSarasas)
            {
                if(checkC(zmo.Amzius))
                {
                    Console.WriteLine(index + " Vaikas: " + zmo.Vardas + " " + zmo.Amzius);
                }
                else if(checkA(zmo.Amzius))
                {
                    Console.WriteLine(index + " Suauges: " + zmo.Vardas + " " + zmo.Amzius);
                }
                else if(checkS(zmo.Amzius))
                {
                    Console.WriteLine(index + " Senolis: " + zmo.Vardas + " " + zmo.Amzius);
                }
                index++;
            }
        }
    }
}
