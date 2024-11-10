using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onkasım01
{
    public class Personel:Maas , ICrudEylemleri
    {
        public string isim;
        public int numara;
        public string yer;
        public string gorev;
        private int bordro;
        //encapluse kapsüleme
        public int maas
        {
            get { return bordro; }

            set
            {

                if (value < 5000)
                {
                    MessageBox.Show("500 Altında Değer Verilemez");
                }
                else
                {
                    bordro = value;
                }
            } 

        }

        public string bilgiyaz() //geriye veri göndermez void yazılacak eğer void yerine string yazarsak geriye veri gönderir.
        {
            string cumle = "Kişinin Adı" + this.isim + "Görevi" + this.gorev;
            return cumle;
        }

        public void Bul()
        {
            throw new NotImplementedException();
        }

        public void Ekle()
        {
            throw new NotImplementedException();
        }

        public void Guncelleme()
        {
            throw new NotImplementedException();
        }

        public void Sil()
        {
            throw new NotImplementedException();
        }

        public override void vergi()
        {
            int hesap = (maas * 20) / 100;
            MessageBox.Show("Vergi" + hesap);
           
        }

        public override void yuzde() //ezilebilir override metodu kendine göre değiştirebiliriz
        {
            throw new NotImplementedException();
        }
    }
}
