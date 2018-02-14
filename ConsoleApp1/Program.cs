using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IPointas
    {
        int x { get; set; }
        int y { get; set; }

        void Atspausdina();
    }

    public interface iTiese
    {
        int xpradzios { get; set; }
        int ypradzios { get; set; }
        int xpabaigos { get; set; }
        int ypabaigos { get; set; }

        void Ar_taskas_yra_tieseje(int x, int y);
    }

    class Taskas : IPointas
    {
        public int x { get; set; }
        public int y { get; set; }

        public void Atspausdina()
        {
            Console.WriteLine(x + " " + y);
        }

        public Taskas(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Tiese : iTiese
    {
        public int xpradzios { get; set; }
        public int ypradzios { get; set; }
        public int xpabaigos { get; set; }
        public int ypabaigos { get; set; }

        public Tiese(int xpra, int ypra, int xpab, int ypab)
        {
            xpradzios = xpra;
            ypradzios = ypra;
            xpabaigos = xpab;
            ypabaigos = ypab;
        }

        public void Ar_taskas_yra_tieseje(int x, int y)
        {
            double k;
            double b;

            k = (ypradzios - ypabaigos) / (xpradzios - xpabaigos);
            b = ypradzios - k * xpradzios;

            double yy;
            yy = k * x + b;

            if(y == yy)
            {
                Console.WriteLine("Taskas yra tieseje");
            }
            else
                Console.WriteLine("Taskas nera tieseje");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Taskas tasssskas = new Taskas(0,0);
            tasssskas.Atspausdina();
            Tiese t1 = new Tiese(1, 1, -1, -1);
            t1.Ar_taskas_yra_tieseje(tasssskas.x,tasssskas.y);
        }
    }
}
