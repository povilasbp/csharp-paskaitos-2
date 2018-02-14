using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace _02_03_uzduotis
{
    class Program
    {
        [STAThread] // standartinis threadas naudojamas su formom
        static void Main(string[] args)
        {
            string path = null;
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
            }

            StreamReader reader = new StreamReader(path);
            string text = reader.ReadToEnd();
            string[] string_masyvas = text.Split(' ').ToArray();
            reader.Close();
            StreamWriter writer = new StreamWriter("C:/Users/Povilas/Desktop/Kaunas Coding School/csharp paskaitos 2/Antra dalis/02_03 uzduotis/bin/Debug/out/out.txt");
            foreach (string zodis in string_masyvas)
            {
                writer.WriteLine(zodis);
            }
            writer.Close();
            //for (int i = 0; i < string_masyvas.Length; i++)
            //{
            //    Console.WriteLine(string_masyvas[i]);
            //}
        }
    }
}
