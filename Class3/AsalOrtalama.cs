using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    public class AsalOrtalama
    {
        public bool AsalMi(int sayi)
        {
            if (sayi <= 1)
                return false;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                    return false;
            }
            return true;
        }
       public void AsalSayiListesi(int ilkSayi, int ikinciSayi)
        {
            if (ilkSayi > ikinciSayi)
            {
                int gecici = ilkSayi;
                ilkSayi = ikinciSayi;
                ikinciSayi = gecici;
            }
            Console.WriteLine("Asal Sayılar:");
            for (int i = ilkSayi; i < ikinciSayi; i++)
            {
                if (AsalMi(i))
                    Console.WriteLine(i);
            }
        }
        public void OrtalamaYazdir(int ilkSayi, int ikinciSayi)
        {
            int toplam = 0;
            int adet = 0;

            for (int i = ilkSayi; i <= ikinciSayi; i++)
            {
                if (AsalMi(i))
                {
                    toplam += i;
                    adet++;
                }
            }
            double ortalama = (double)toplam / adet;
            Console.WriteLine("Ortalama :  " +ortalama);
        }
    }
}
