using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onkasım01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel atama = new Personel();
            atama.isim = "Veysel";
            atama.yer = "Muhasebe";
            atama.numara = 105;
            atama.gorev = "Memur";
            atama.bilgiyaz();
            atama.katsayi=2000;
            atama.damgaVergisi = 2;
            atama.hesapla();
            int cocukucret = Gosterge.cocuk;
            int ailyardim = Gosterge.aile;

           
            string cevap = atama.bilgiyaz();
            MessageBox.Show(cevap);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sef yasin = new Sef();
            yasin.isim = "Yakup";
            yasin.gorev = "Şef";
            yasin.maas = 3000;
            MessageBox.Show(yasin.bilgiyaz());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Maas eren = new Maas();
            
        }
    }
}
