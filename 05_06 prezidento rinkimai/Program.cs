using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_06_prezidento_rinkimai
{
    class Program
    {
        static int UnikaliuRaidziuPaieska(char[] raides)
        {
            int unikaliosr = 0;
            for(int i = 0; i < raides.Length; i++)
            {
                int flag = 0;
                for(int j = i+1; j < raides.Length; j++)
                {
                    if(raides[i] == raides[j])
                    {
                        flag++;
                    }
                }
                if(flag == 0)
                {
                    unikaliosr++;
                }
            }
            return unikaliosr;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite visus kandidatus");
            string kandidatai = Console.ReadLine();
            string[] kandidatai_mas = kandidatai.Split(' ').ToArray();
            int index = 0;
            int max = 0;
            int i = 0;
            foreach (var kand in kandidatai_mas)
            {
                kand.ToLower();
                char[] raides = kand.ToCharArray();
                int raidziu_kiekis = UnikaliuRaidziuPaieska(raides);
                if(max < raidziu_kiekis)
                {
                    max = raidziu_kiekis;
                    index = i;
                }
                i++;
            }
            Console.WriteLine("Laimetojas: " + kandidatai_mas[index]);


        }
    }
}
