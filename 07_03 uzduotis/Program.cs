using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            int skaicius = 0;
            Func<int,int> funkcija1 = (x) => x + 1;
            Console.WriteLine(funkcija1.Invoke(skaicius));

            // 2
            int a = 4;
            int b = 2;
            Func<int,int,int> funkcija2 = (x,y) => x * y;
            Console.WriteLine(funkcija2.Invoke(a,b));

            // 3
            string tekstas = "hello world!";
            Action kazkas = () => Console.WriteLine(tekstas);
            kazkas.Invoke();

            // 4
            int s1 = 3;
            int s2 = 5;
            Func<int, int, int> funkcija4 = (x,y) => x + y;
            Console.WriteLine(funkcija4.Invoke(s1, s2));


        }
    }
}
