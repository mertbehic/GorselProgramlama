using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayitahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayi = Convert.ToInt32(textBox1.Text);
            int basamak = 0;
            
            while(sayi>0)
            {
                basamak = sayi % 10;
                sayi = sayi / 10;
                listBox1.Items.Add(basamak);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayi = Convert.ToInt32(textBox1.Text);
            int basamak = 0;
            int toplam = 0;
            while (sayi > 0)
            {
                basamak = sayi % 10;
                sayi = sayi / 10;
                toplam += basamak;
            }
            listBox1.Items.Add("Basamak Toplamı:" + toplam);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string kelime = textBox2.Text;
            for (int i = 0;i<kelime.Length;i++)
            {
              

                listBox1.Items.Add(kelime[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string kelime = textBox2.Text;
            int toplam = 0;
            for (int i = 0; i < kelime.Length; i++)
            {
               

                toplam++;

            }
            listBox1.Items.Add("Karakter Uzunluğu:"+toplam);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] kullanicisayisi = new int[6];
            kullanicisayisi[0] = Convert.ToInt32(textBox3.Text);
            kullanicisayisi[1] = Convert.ToInt32(textBox4.Text);
            kullanicisayisi[2] = Convert.ToInt32(textBox5.Text);
            kullanicisayisi[3] = Convert.ToInt32(textBox6.Text);
            kullanicisayisi[4] = Convert.ToInt32(textBox7.Text);
      
            Random rnd = new Random();
            int[] rastgele = new int[6];
            for (int i = 0; i < 6; i++)
  
                rastgele[i] = rnd.Next(1, 50);
            label7.Text = rastgele[0].ToString();
            label8.Text = rastgele[1].ToString();
            label9.Text = rastgele[2].ToString();
            label10.Text = rastgele[3].ToString();
            label11.Text = rastgele[4].ToString();
           
            int toplam = 0;
            for (int i=0;i<6;i++)
               
            {
                for (int j=0;j<6;j++)
                {
                    if (rastgele[i] == kullanicisayisi[j])
                        toplam++;
                }
                label3.Text = ("Aynı Tahmin Sayısı:" + toplam);
               

            }




        }
    }
}
