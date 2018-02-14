using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_03_uzduotis
{
    class Metronome
    {
        public delegate void Tikhandler();
        public event Tikhandler tik;

        public void Start()
        {
            while(true)
            {
                System.Threading.Thread.Sleep(300);
                tik();
            }
        }
    }

    class Klausytojas
    {
        private void Isgirdau()
        {
            Console.WriteLine("Isgirdau");
        }

        public void Subscriber(Metronome m)
        {
            m.tik += new Metronome.Tikhandler(Isgirdau);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Metronome metro = new Metronome();
            Klausytojas klauso = new Klausytojas();
            klauso.Subscriber(metro);
            metro.Start();
        }
    }
}
