using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_01_uzduotis_d
{
    class Program
    {
        public delegate int MathOperations(int a, int b);
        static int Add(int a, int b)
        {
            int result = (a + b);
            Console.WriteLine(result);
            return result;
        }

        static int Substract(int a, int b)
        {
            int result = (a - b);
            Console.WriteLine(result);
            return result;
        }

        static int KelimasLaipsniu(int a, int b)
        {
            return (int)(Math.Pow(a, b));
        }



        static void Main(string[] args)
        {
            MathOperations mathematicaloperations = Add;
            int result = mathematicaloperations(2, 5);
            //Console.WriteLine(result);

            mathematicaloperations += Substract;
            int rezultatas = mathematicaloperations(2, 5);
            //Console.WriteLine(rezultatas);
        }
    }
}
