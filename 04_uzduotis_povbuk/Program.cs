using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_uzduotis_povbuk
{
    class VaikasException : Exception
    {
        public int amzius;
        public VaikasException(int amzius)
        {
            this.amzius = amzius;
        }
    }
    class PensininkasException : Exception
    {
        public int amzius;
        public PensininkasException(int amzius)
        {
            this.amzius = amzius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Duomenys faile atrodo taip:
            // 25 30 52 59 65 48 22 16 4 2 84
            StreamReader reader = new StreamReader("duom.txt");
            string visiDuom = reader.ReadToEnd();
            List<string> ZmoniuAmziuSar = visiDuom.Split(' ').ToList();

            // DUOMENU ISVEDIMAS ----------------------------------------------------------------
            Console.WriteLine("Duomenys sarase: ");
            foreach (var amzius in ZmoniuAmziuSar)
            {
                Console.Write("{0,-3}", amzius);
            }
            Console.WriteLine();
            foreach (var amzius in ZmoniuAmziuSar)
            {
                Console.Write("{0,-3}", ZmoniuAmziuSar.IndexOf(amzius));
            }
            Console.WriteLine("\n");
            // SKAICIAVIMAS----------------------------------------------------------------------
            int indeksas = 0; // indeksas, kad zinoti kuris asmuo sarase

            Console.WriteLine("{0,-18}{1,-9}{2}", "Indeksas sarase:", "Amzius:", "Tipas:");
            foreach (var amzius in ZmoniuAmziuSar)
            {
                try
                {
                    if (Convert.ToInt32(amzius) < 18)
                    {
                        throw new VaikasException(Convert.ToInt32(amzius));
                    }
                    else if (Convert.ToInt32(amzius) > 60)
                    {
                        throw new PensininkasException(Convert.ToInt32(amzius));
                    }
                }
                catch (VaikasException)
                {
                    Console.WriteLine("{0,9}{1,13}{2,11}", indeksas, amzius, "Vaikas");
                }
                catch (PensininkasException)
                {
                    Console.WriteLine("{0,9}{1,13}{2,16}", indeksas, amzius, "Pensininkas");
                }
                finally
                {
                    indeksas++;
                }
            }
            //----------------------------------------------------------------------------------
            Console.ReadKey();
        }
    }
}
