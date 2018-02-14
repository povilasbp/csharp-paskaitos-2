using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_02_uzduotis
{
    class Taskas
    {
        public int x { get; private set; }
        public int y { get; private set; }

        public Taskas(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite kiek tasku: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Dictionary<int, Taskas> taskai = new Dictionary<int, Taskas>();
            List<Taskas> taskai2 = new List<Taskas>();
                Random rng = new Random();
            for(int i = 0; i < N; i++)
            {
                int x = rng.Next(-10, 10);
                int y = rng.Next(-10, 10);
                Taskas temp = new Taskas(x, y);
                taskai[i] = temp; 
                taskai2.Add(temp);
            }

            Console.Write("Iveskite centro koordinates: ");
            string centras = Console.ReadLine();
            string[] kk = centras.Split(' ').ToArray();
            int a = Convert.ToInt32(kk[0]);
            int b = Convert.ToInt32(kk[1]);

            Console.Write("Iveskite spinduli: ");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skaiciavimai dictionary");
            for (int i = 0; i < N; i++)
            {
                double d = Math.Sqrt(Math.Pow(taskai[i].x - a, 2) + Math.Pow(taskai[i].y - b, 2));
                if (d <= r)
                {
                    Console.WriteLine("Taskas " + taskai[i].x + " " + taskai[i].y + " yra apskritime");
                }
                else
                    Console.WriteLine("Taskas " + taskai[i].x + " " + taskai[i].y + " nera apskritime");
            }

            Console.WriteLine("Skaiciavimai sarase");
            foreach (Taskas tt in taskai2)
            {
                double d = Math.Sqrt(Math.Pow(tt.x - a, 2) + Math.Pow(tt.y - b, 2));
                if (d <= r)
                {
                    Console.WriteLine("Taskas " + tt.x + " " + tt.y + " yra apskritime");
                }
                else
                    Console.WriteLine("Taskas " + tt.x + " " + tt.y  + " nera apskritime");
            }


        }
    }
}
