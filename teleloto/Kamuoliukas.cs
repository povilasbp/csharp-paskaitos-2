using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teleloto
{
    class Kamuoliukas
    {
        public int Skaicius { get; set; }
        public string Spalva { get; set; }

        public Kamuoliukas() { }
        public Kamuoliukas(int skaicius, string spalva)
        {
            Skaicius = skaicius;
            Spalva = spalva;
        }



        public void GeneruotiAtskirasSpalvas(List<Kamuoliukas> SpalvosKamuoliukuSarasas, int spalvosIndex)
        {
            int kiek = 0;
            bool yra_pasikartojanciu = false;
            string[] SpalvuMasyvas = { "melyna", "juoda", "raudona", "geltona", "zalia" };
            var randomObj = new Random();

            Kamuoliukas k = new Kamuoliukas(randomObj.Next(1, 76), SpalvuMasyvas[spalvosIndex]);
            SpalvosKamuoliukuSarasas.Add(k);

            while (kiek != 4)
            {
                Kamuoliukas k1 = new Kamuoliukas(randomObj.Next(1, 76), SpalvuMasyvas[spalvosIndex]);
                for (int i = 0; i < SpalvosKamuoliukuSarasas.Count; i++)
                {
                    if (k1.Skaicius == SpalvosKamuoliukuSarasas[i].Skaicius)
                    {
                        yra_pasikartojanciu = true;
                    }
                   
                }
                if (yra_pasikartojanciu == false)
                {
                    SpalvosKamuoliukuSarasas.Add(k1);
                }
                kiek++;
            }
        }


    }
}
