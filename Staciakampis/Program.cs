using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staciakampis
{
    public interface IStaciakampis
    {
        int a { get; set; }
    }

    class Gretasienis : IStaciakampis
    {
        public int a { get; set; }
    }

    class Kvadratas : IStaciakampis
    {
        public int a { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IStaciakampis> stac = new List<IStaciakampis>();

            Kvadratas kv = new Kvadratas();
            Gretasienis gret = new Gretasienis();

            stac.Add(kv);  // skiriasi tipai, bet prideda prie interfeiso
            stac.Add(gret);
        }
    }
}
