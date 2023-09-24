using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayıTahmini_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int zaman = 5;
        private void btn_tahmin_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi;
            sayi=rastgele.Next(1,10);

            int metin = Convert.ToInt32(txt_tahmin.Text);
            if (sayi==metin)
            {
                MessageBox.Show("Tebrikler sayıyı doğru tahmin ettiniz :)");
            }
            else
            {
                MessageBox.Show("Bilemediniz Tekrar deneyin doğru sayı:"+sayi);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_tahmin.Enabled = false;
            txt_tahmin.Enabled = false;
        }

        private void btn_baslat_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label2.Text = zaman.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman--;
            label2.Text = zaman.ToString();
            if (zaman==0)
            {
                timer1.Enabled = false;

                btn_tahmin.Enabled = true;
                txt_tahmin.Enabled = true;

            }
        }
    }
}
