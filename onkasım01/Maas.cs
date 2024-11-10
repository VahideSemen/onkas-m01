using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onkasım01
{
    public abstract class Maas //soyutlanmış metat türetemiyoruz.
    {
        public int katsayi = 1000;
        public int damgaVergisi = 2;

        public abstract void yuzde();
        public abstract void vergi();

        public int hesapla()
        {
            return katsayi * damgaVergisi;
        }
    }
}
