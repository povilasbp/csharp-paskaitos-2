using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_05_skaiciuotuvas
{
    class Program
    {
        public delegate int DelegatasSkaiciuotuvo(string[] uzduotis);
        public static int Suma(string[] uzduotis)
        {
            int a = Convert.ToInt32(uzduotis[0]);
            int b = Convert.ToInt32(uzduotis[2]);
            return (a + b);
        }
        public static int Skirtumas(string[] uzduotis)
        {
            int a = Convert.ToInt32(uzduotis[0]);
            int b = Convert.ToInt32(uzduotis[2]);
            return (a - b);
        }
        public static int Sandauga(string[] uzduotis)
        {
            int a = Convert.ToInt32(uzduotis[0]);
            int b = Convert.ToInt32(uzduotis[2]);
            return (a * b);
        }
        public static int Dalyba(string[] uzduotis)
        {
            int a = Convert.ToInt32(uzduotis[0]);
            int b = Convert.ToInt32(uzduotis[2]);
            return ((int)(a / b));
        }





        static void Main(string[] args)
        {
            Console.WriteLine("Uzduotis: ");
            string uzduotis = Console.ReadLine();
            string[] uzduotisMasyvas = uzduotis.Split(' ').ToArray();
            string veiksmas = uzduotisMasyvas[1];

            DelegatasSkaiciuotuvo delSuma = Suma;
            DelegatasSkaiciuotuvo delSkirtumas = Skirtumas;
            DelegatasSkaiciuotuvo delSandauga = Sandauga;
            DelegatasSkaiciuotuvo delDalyba = Dalyba;

            switch (veiksmas)
            {
                case "+":
                    Console.WriteLine(delSuma(uzduotisMasyvas));
                    break;
                case "-":
                    Console.WriteLine(delSkirtumas(uzduotisMasyvas));
                    break;
                case "*":
                    Console.WriteLine(delSandauga(uzduotisMasyvas));
                    break;
                case "/":
                    Console.WriteLine(delDalyba(uzduotisMasyvas));
                    break;
            }


            //switch (veiksmas)
            //{
            //    case "+":
            //        atsakymas = a + b;
            //        break;
            //    case "-":
            //        atsakymas = a - b;
            //        break;
            //    case "*":
            //        atsakymas = a * b;
            //        break;
            //    case "/":
            //        atsakymas = a / b;
            //        break;
            //    default:
            //        break;
            //}
            //Console.WriteLine("Atsakymas: " + atsakymas);
        }
    }
}
