using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_01_uzduotis
{
    public delegate void EventHandler();
    class Program
    {
        public static event EventHandler rodyti;
        public static void Suo()
        {
            Console.WriteLine("Suo");
        }
        public static void Cat()
        {
            Console.WriteLine("Kate");
        }
        public static void Mouse()
        {
            Console.WriteLine("Pele");
        }

        static void Main(string[] args)
        {
            rodyti += new EventHandler(Suo);
            rodyti += new EventHandler(Cat);
            rodyti += new EventHandler(Mouse);

            rodyti.Invoke();

        }
    }
}
