using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    internal class Sinema
    {
        int toplamKoltukSayisi;
        int bosKoltukSayisi;
        double bakiye;
        string salonNumarasi;
        const int tamBilet = 95; // const bir değişkeni sabit tutmak için kullanılır.
        const int indiriliBilet = 80;
        
        // const tanımlıyoruz
        public Sinema(string salonAdi, int koltukSayisi) 
        {
            toplamKoltukSayisi = koltukSayisi;
            salonNumarasi = salonAdi;
            bosKoltukSayisi = koltukSayisi;
            bakiye = 0;
        } 
        // Bir class fonks/metodu yazıyoruz 
        public void BiletSat(bool indirimliMi)
        {
            bosKoltukSayisi--;
            if (indirimliMi== true)
            {
                bakiye += indiriliBilet;
            }
            else
            {
                bakiye -= tamBilet;
            }
        }

        public void BiletIptal(bool indirimliMi)
        {
            bosKoltukSayisi++;
            if (indirimliMi== true)
            {
                bakiye-=indiriliBilet;
            }
            else
            {
                bakiye -= tamBilet;
            }
        }
        public int BosKoltukKontrolEt()
        {
            return bosKoltukSayisi;
        }
        public double BakiyeKontrolEt()
        {
            return bakiye;
        }
    
    }
}
