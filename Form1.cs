using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uzaktan_Egitim2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Toplama(int sayi1,int sayi2) 
        {
            int toplam = sayi1 + sayi2;
            MessageBox.Show("Sayıların Toplamı : " + toplam);
        }

        void Çıkarma(int sayi1, int sayi2)
        {
            int cikan = sayi1 - sayi2;
            MessageBox.Show("Çıkan Sayıların Sonucu : " + cikan);
        }

        void Çarpma(int sayi1, int sayi2)
        {
            int carpim = sayi1 * sayi2;
            MessageBox.Show("Çarpılan sayıların Sonucu : " + carpim);
        }

        void Bölme(int sayi1, int sayi2)
        {
            int bolme = sayi1 / sayi2;
            MessageBox.Show("Bölünen Sayıların Sonucu : " + bolme);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Toplama(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Çıkarma(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Çarpma(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bölme(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text));
        }
    }
}
