using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kortu_programa
{
    class Korta
    {
        public string Simbolis { get; private set; }
        public int Skaicius { get; private set; }
        public char Raide { get; private set; }
        public string skaiciukas { get; private set; }

        private void Is_string_i_char()
        {
            switch (Simbolis)
            {
                case "kryzius":
                    Raide = 'K';
                    break;
                case "sirdis":
                    Raide = 'R';
                    break;
                case "vynas":
                    Raide = 'V';
                    break;
                case "bugnai":
                    Raide = 'B';
                    break;
                default:
                    break;
            }
        }
        private void Is_int_i_char()
        {
            switch (Skaicius)
            {
                case 1:
                    skaiciukas = "A";
                    break;
                case 11:
                    skaiciukas = "J";
                    break;
                case 12:
                    skaiciukas = "K";
                    break;
                case 13:
                    skaiciukas = "Q";
                    break;
                default:
                    skaiciukas = Skaicius.ToString();
                    break;
            }
        }



        public Korta(string simbolis, int skaicius)
        {
            Simbolis = simbolis;
            Skaicius = skaicius;
            Is_string_i_char();
            Is_int_i_char();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Korta k1 = new Korta("Kryzius", 2);
            //Console.WriteLine(k1.Simbolis + " " + k1.Skaicius);

            var atsitiktinisObj = new Random();
            string[] visi_simboliai = { "kryzius", "sirdis", "vynas", "bugnai" };
            List<Korta> Kalade = new List<Korta>();
            int i = 0;
            while (i < 52)
            {
                Korta kortele = new Korta(visi_simboliai[atsitiktinisObj.Next(4)], atsitiktinisObj.Next(1, 14));
                int flag = 0;
                foreach (var koort in Kalade)
                {
                    if (koort.Skaicius == kortele.Skaicius && koort.Simbolis == kortele.Simbolis)
                    {
                        flag++;
                    }
                }

                if (flag == 0)
                {
                    Kalade.Add(kortele);
                    i++;
                }
            }


            foreach (var kortele in Kalade)
            {
                Console.WriteLine(kortele.Raide + " " + kortele.Skaicius + " " + kortele.skaiciukas);
            }







        }
    }
}
