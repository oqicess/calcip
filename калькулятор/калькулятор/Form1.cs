using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор
{
    public partial class Калькулятор : Form
    {
        public Калькулятор()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int IP1 = Convert.ToInt32(textBox1.Text);
            int IP2 = Convert.ToInt32(textBox2.Text);
            int IP3 = Convert.ToInt32(textBox3.Text);
            int IP4 = Convert.ToInt32(textBox4.Text);
            int Mask = Convert.ToInt32(textBox5.Text);
            int N, M, T, q;
            int Host;
            long Host0;

           

            if(IP1 < 256 && IP1 > -1 && IP2 < 256 && IP2 > -1 && IP3 < 256 && IP3 > -1 && IP4 < 256 && IP4 > -1)
            {
                if (Mask < 9 && Mask > 1)
                {
                    N = 32 - Mask;
                    Host = (int)Math.Pow(2, N);
                    M = IP1 / (Host / 16777216);
                    IP1 = (Host / 16777216) * M;
                    T = (Host / 16777216) * (M + 1) - 1;
                    q = 256 - (int)Math.Pow(2, (N - 24));
                    textBox6.Text = (Host).ToString(); // количество хостов
                    textBox7.Text = (IP1+".0.0.0").ToString(); // Адрес сети
                    textBox8.Text = (T+".255.255.255").ToString(); // BroadCast
                    textBox9.Text = (q+".0.0.0").ToString(); // Маска

                }
                if (Mask < 17 && Mask > 8)
                {
                    N = 32 - Mask;
                    Host = (int)Math.Pow(2, N);
                    M = IP2 / (Host / 65536);
                    IP2 = (Host / 65536) * M;
                    T = (Host / 65536) * (M + 1) - 1;
                    q = 256 - (int)Math.Pow(2, (N - 16));
                    textBox6.Text = (Host).ToString(); // количество хостов
                    textBox7.Text = (IP1 + "." + IP2 +".0.0").ToString(); // Адрес сети
                    textBox8.Text = (IP1 + "." + T + ".255.255").ToString(); // BroadCast
                    textBox9.Text = ("255." + q + ".0.0").ToString(); // Маска
                }
                if (Mask < 25 && Mask > 16)
                {
                    N = 32 - Mask;
                    Host = (int)Math.Pow(2, N);
                    M = IP3 / (Host / 256);
                    IP3 = (Host / 256) * M;
                    T = (Host / 256) * (M + 1) - 1;
                    q = 256 - (int)Math.Pow(2, (N - 8));
                    textBox6.Text = (Host).ToString(); // количество хостов
                    textBox7.Text = (IP1 + "." + IP2 + "." + IP3 + ".0").ToString(); // Адрес сети
                    textBox8.Text = (IP1 + "." + IP2 + "." + T + ".255").ToString(); // BroadCast
                    textBox9.Text = ("255." + "255." + q + ".0").ToString(); // Маска
                }
                if (Mask < 32 && Mask > 24)
                {
                    N = 32 - Mask;
                    Host = (int)Math.Pow(2, N);
                    M = IP4 / Host;
                    IP4 = Host * M;
                    T = Host * (M + 1) - 1;
                    q = 256 - (int)Math.Pow(2, N);
                    textBox6.Text = (Host).ToString(); // количество хостов
                    textBox7.Text = (IP1 + "." + IP2 + "." + IP3 + "." + IP4).ToString(); // Адрес сети
                    textBox8.Text = (IP1 + "." + IP2 + "." + IP3 + "." + T).ToString(); // BroadCast
                    textBox9.Text = ("255." + "255." + "255." + q).ToString(); // Маска
                }
                if (Mask == 0)
                {
                    N = 32 - Mask;
                    Host0 = (long)Math.Pow(2, N);
                    textBox6.Text = (Host0).ToString(); // количество хостов
                    textBox7.Text = ("0.0.0.0").ToString(); // Адрес сети
                    textBox8.Text = ("255.255.255.255").ToString(); // BroadCast
                    textBox9.Text = ("0.0.0.0").ToString(); // Маска
                }
                if (Mask == 1)
                {
                    if (IP1 < 128)
                    {
                        N = 32 - Mask;
                        Host0 = (long)Math.Pow(2, N);
                        textBox6.Text = (Host0).ToString(); // количество хостов
                        textBox7.Text = ("0.0.0.0").ToString(); // Адрес сети
                        textBox8.Text = ("127.255.255.255").ToString(); // BroadCast
                        textBox9.Text = ("128.0.0.0").ToString(); // Маска
                    }
                    else {
                    N = 32 - Mask;
                    Host0 = (long)Math.Pow(2, N);
                    textBox6.Text = (Host0).ToString(); // количество хостов
                    textBox7.Text = ("128.0.0.0").ToString(); // Адрес сети
                    textBox8.Text = ("255.255.255.255").ToString(); // BroadCast
                    textBox9.Text = ("128.0.0.0").ToString(); // Маска
                    }
                }
                if (Mask == 32)
                {
                    textBox6.Text = ("N/A").ToString(); // количество хостов
                    textBox7.Text = (IP1 + "." + IP2 + "." + IP3 + "." + IP4).ToString(); // Адрес сети
                    textBox8.Text = ("N/A").ToString(); // BroadCast
                    textBox9.Text = ("255.255.255.255").ToString(); // Маска
                }
            }
            else
            {
                textBox6.Text = ("N/A").ToString(); // количество хостов
                textBox7.Text = ("N/A").ToString(); // Адрес сети
                textBox8.Text = ("N/A").ToString(); // BroadCast
                textBox9.Text = ("N/A").ToString(); // Маска
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
