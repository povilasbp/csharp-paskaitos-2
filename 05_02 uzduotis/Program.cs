using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02_uzduotis
{
    class Program
    {
        public delegate void LoginimasIvykis(string message);

        public static void KonsoleRasymas(string message)
        {
            Console.WriteLine(message);
        }

        public static void RasymasIFaila(string message)
        {
            string data = null;
            try
            {
                StreamReader reader = new StreamReader("log.txt");
                data = reader.ReadToEnd();
                reader.Close();
                StreamWriter writer = new StreamWriter("log.txt");
                writer.WriteLine(data + message);
                writer.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Ivyko klaida, sukurtas naujas failas tinka? y/n");
                char raide = Console.ReadKey().KeyChar;
                if(raide == 'y' || raide == 'Y')
                {
                    StreamWriter writer = new StreamWriter("log.txt");
                    writer.WriteLine(data + message);
                    writer.Close();
                }
                else if (raide == 'n' || raide == 'N')
                {
                    Console.WriteLine("Naujas failas nesukurtas");
                }
            }
            
        }
        static void Main(string[] args)
        {
            LoginimasIvykis log = KonsoleRasymas;
            log += RasymasIFaila;
            log("laaabas");

        }
    }
}
