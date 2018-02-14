using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_02_uzduotis
{
    public interface Idarbuotojas
    {
        string vardas { get; set; }
        int numeris { get; set; }
    }

    class Darbuotojas : Idarbuotojas
    {
        public string vardas { get; set; }
        public int numeris { get; set; }

        public Darbuotojas()
        {

        }
        public Darbuotojas(string vardas, int numeris)
        {
            this.vardas = vardas;
            this.numeris = numeris;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int kiekDarbuotoju = 0;
            int index = 0;

            Console.Write("Enter number of employees: ");
            kiekDarbuotoju = Convert.ToInt32(Console.ReadLine());
            int darbuotojoNumeris = kiekDarbuotoju;
            while (index != kiekDarbuotoju)
            {
                Darbuotojas d = new Darbuotojas();
                Console.Write("Enter the name of the new employee: ");
                d.vardas = Console.ReadLine();
                d.numeris = darbuotojoNumeris--;
                Console.WriteLine("The employee information:");
                Console.WriteLine("Employee number: " + d.numeris);
                Console.WriteLine("Employee name: " + d.vardas);
                index++;
            }
            Console.WriteLine("\nIvedimas baigtas");
            Console.ReadKey();
        }
    }
}
