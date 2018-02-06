using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teleloto
{
    public partial class Form1 : Form
    {
        int[] melyni = new int[5];
        int[] juodi = new int[5];
        int[] raudoni = new int[5];
        int[] geltoni = new int[5];
        int[] zali = new int[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGeneruoti_Click(object sender, EventArgs e)
        {
            melyni = Atrenka_kamuoliukus(1, 15);
            juodi = Atrenka_kamuoliukus(15, 30);
            raudoni = Atrenka_kamuoliukus(30, 76);
            geltoni = Atrenka_kamuoliukus(1, 76);
            zali = Atrenka_kamuoliukus(1, 76);

            M1.Text = Convert.ToString(melyni[0]);
            M2.Text = Convert.ToString(melyni[1]);
            M3.Text = Convert.ToString(melyni[2]);
            M4.Text = Convert.ToString(melyni[3]);
            M5.Text = Convert.ToString(melyni[4]);

            J1.Text = Convert.ToString(juodi[0]);
            J2.Text = Convert.ToString(juodi[1]);
            J3.Text = Convert.ToString(juodi[2]);
            J4.Text = Convert.ToString(juodi[3]);
            J5.Text = Convert.ToString(juodi[4]);

            R1.Text = Convert.ToString(raudoni[0]);
            R2.Text = Convert.ToString(raudoni[1]);
            R3.Text = Convert.ToString(raudoni[2]);
            R4.Text = Convert.ToString(raudoni[3]);
            R5.Text = Convert.ToString(raudoni[4]);

            G1.Text = Convert.ToString(geltoni[0]);
            G2.Text = Convert.ToString(geltoni[1]);
            G3.Text = Convert.ToString(geltoni[2]);
            G4.Text = Convert.ToString(geltoni[3]);
            G5.Text = Convert.ToString(geltoni[4]);

            Z1.Text = Convert.ToString(zali[0]);
            Z2.Text = Convert.ToString(zali[1]);
            Z3.Text = Convert.ToString(zali[2]);
            Z4.Text = Convert.ToString(zali[3]);
            Z5.Text = Convert.ToString(zali[4]);

        }

        /// <summary>
        /// Suranda 5 unikalius kamuoliukus tam tikruose reziuose
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int[] Atrenka_kamuoliukus(int a, int b)
        {
            int[] temporary = new int[5];
            Random rng = new Random();

            int i = 0;
            while (i < 5)
            {
                int temp = rng.Next(a, b);
                int flag = 0;

                foreach (var t in temporary)
                {
                    if (t == temp)
                        flag++;
                }
                if (flag == 0)
                {
                    temporary[i] = temp;
                    i++;
                }
            }

            return temporary;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonZaisti_Click(object sender, EventArgs e)
        {
            List<int> kamuoliukai = new List<int>();
            Random rng = new Random();

            int i = 0;

            while (i < 50)
            {
                int temp = rng.Next(1, 76);
                int flag = 0;
                foreach (var k in kamuoliukai)
                {
                    if (k == temp)
                    {
                        flag++;
                    }
                }
                if (flag == 0)
                {
                    kamuoliukai.Add(temp);
                    i++;

                    string jjjj = textBoxAtsakymas.Text;
                    jjjj += " " + temp.ToString();
                    textBoxAtsakymas.Text = jjjj;
                    SuIntegravimas(temp);
                    //buttonZaisti.Enabled = false;
                }
            }
        }

        private void SuIntegravimas(int istrauktas_kamuoliukas)
        {
            if (istrauktas_kamuoliukas < 16)
            {
                if (melyni[0] == istrauktas_kamuoliukas)
                {
                    M1.BackColor = Color.Green;
                }
                else if (melyni[1] == istrauktas_kamuoliukas)
                {
                    M2.BackColor = Color.Green;
                }
                else if (melyni[2] == istrauktas_kamuoliukas)
                {
                    M3.BackColor = Color.Green;
                }
                else if (melyni[3] == istrauktas_kamuoliukas)
                {
                    M4.BackColor = Color.Green;
                }
                else if (melyni[4] == istrauktas_kamuoliukas)
                {
                    M5.BackColor = Color.Green;
                }
            }
            else if (istrauktas_kamuoliukas > 15 && istrauktas_kamuoliukas < 31)
            {
                if (juodi[0] == istrauktas_kamuoliukas)
                {
                    J1.BackColor = Color.Green;
                }
                else if (juodi[1] == istrauktas_kamuoliukas)
                {
                    J2.BackColor = Color.Green;
                }
                else if (juodi[2] == istrauktas_kamuoliukas)
                {
                    J3.BackColor = Color.Green;
                }
                else if (juodi[3] == istrauktas_kamuoliukas)
                {
                    J4.BackColor = Color.Green;
                }
                else if (juodi[4] == istrauktas_kamuoliukas)
                {
                    J5.BackColor = Color.Green;
                }
            }
            else if (istrauktas_kamuoliukas > 30 && istrauktas_kamuoliukas < 46)
            {
                if (raudoni[0] == istrauktas_kamuoliukas)
                {
                    R1.BackColor = Color.Green;
                }
                else if (raudoni[1] == istrauktas_kamuoliukas)
                {
                    R2.BackColor = Color.Green;
                }
                else if (raudoni[2] == istrauktas_kamuoliukas)
                {
                    R3.BackColor = Color.Green;
                }
                else if (raudoni[3] == istrauktas_kamuoliukas)
                {
                    R4.BackColor = Color.Green;
                }
                else if (raudoni[4] == istrauktas_kamuoliukas)
                {
                    R5.BackColor = Color.Green;
                }
            }
            else if (istrauktas_kamuoliukas > 45 && istrauktas_kamuoliukas < 61)
            {
                if (geltoni[0] == istrauktas_kamuoliukas)
                {
                    G1.BackColor = Color.Green;
                }
                else if (geltoni[1] == istrauktas_kamuoliukas)
                {
                    G2.BackColor = Color.Green;
                }
                else if (geltoni[2] == istrauktas_kamuoliukas)
                {
                    G3.BackColor = Color.Green;
                }
                else if (geltoni[3] == istrauktas_kamuoliukas)
                {
                    G4.BackColor = Color.Green;
                }
                else if (geltoni[4] == istrauktas_kamuoliukas)
                {
                    G5.BackColor = Color.Green;
                }
            }
            else if (istrauktas_kamuoliukas > 60)
            {
                if (zali[0] == istrauktas_kamuoliukas)
                {
                    Z1.BackColor = Color.Green;
                }
                else if (zali[1] == istrauktas_kamuoliukas)
                {
                    Z2.BackColor = Color.Green;
                }
                else if (zali[2] == istrauktas_kamuoliukas)
                {
                    Z3.BackColor = Color.Green;
                }
                else if (zali[3] == istrauktas_kamuoliukas)
                {
                    Z4.BackColor = Color.Green;
                }
                else if (zali[4] == istrauktas_kamuoliukas)
                {
                    Z5.BackColor = Color.Green;
                }
            }
        }
    }
}
