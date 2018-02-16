using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02_uzduotis_povbuk
{
    public interface IGyvunas
    {
        string Vardas { get; set; }
        int Amzius { get; set; }
        void Apibudinti();
    }

    public class Kate : IGyvunas
    {
        public string Vardas { get; set; }
        public int Amzius { get; set; }
        public string Veisle { get; set; }
        public Kate(string Vardas, int Amzius, string Veisle)
        {
            this.Vardas = Vardas;
            this.Amzius = Amzius;
            this.Veisle = Veisle;
        }
        public void Apibudinti()
        {
            Console.WriteLine("Vardas: {0,-9} Veisle: {1,-9} {2,3}m.", Vardas, Veisle, Amzius);
        }
    }

    public class Suo : IGyvunas
    {
        public string Vardas { get; set; }
        public int Amzius { get; set; }
        public string Veisle { get; set; }
        public int KomanduSk { get; set; } // kiek suo moka komandu
        public Suo(string Vardas, int Amzius, string Veisle, int KomanduSk)
        {
            this.Vardas = Vardas;
            this.Amzius = Amzius;
            this.Veisle = Veisle;
            this.KomanduSk = KomanduSk;
        }
        public void Apibudinti()
        {
            Console.WriteLine("Vardas: {0,-9} Veisle: {1,-9} Komandos: {2,3}  {3,3}m.", Vardas, Veisle, KomanduSk, Amzius);
        }
    }

    public class Vista : IGyvunas
    {
        public string Vardas { get; set; }
        public int Amzius { get; set; }
        public string Veisle { get; set; }
        public int KiausiniuSk { get; set; } // kiek per diena deda kiausiniu
        public Vista(string Vardas, int Amzius, string Veisle, int KiausiniuSk)
        {
            this.Vardas = Vardas;
            this.Amzius = Amzius;
            this.Veisle = Veisle;
            this.KiausiniuSk = KiausiniuSk;
        }
        public void Apibudinti()
        {
            Console.WriteLine("Vardas: {0,-7} Veisle: {1,-9} Kiausiniai: {2,3} {3,3}m.", Vardas, Veisle, KiausiniuSk, Amzius);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kate k1 = new Kate("Murka", 5, "laukine");
            Suo s1 = new Suo("Reksas", 10, "aviganis", 2);
            Vista v1 = new Vista("-", 1, "kaimiska", 2);

            List<IGyvunas> gyvunuSar = new List<IGyvunas>() { k1, s1, v1 };

            foreach (var gyvunas in gyvunuSar)
            {
                gyvunas.Apibudinti();
            }
        }
    }
}
