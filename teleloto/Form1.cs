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
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGeneruoti_Click(object sender, EventArgs e)
        {
            int[] melyni = Atrenka_kamuoliukus(1, 15);
            int[] juodi = Atrenka_kamuoliukus(15, 30);
            int[] raudoni = Atrenka_kamuoliukus(30, 76);
            int[] geltoni = Atrenka_kamuoliukus(1, 76);
            int[] zali = Atrenka_kamuoliukus(1, 76);

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
    }
}
