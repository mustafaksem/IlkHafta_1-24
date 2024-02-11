using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Class3
{
    public class Urunler
    {
        public void UrunlerListele()
        {
            ArrayList urunAdları = new ArrayList();
            ArrayList urunFiyatları = new ArrayList();
            while (true)
            {              
                Console.Write("Ürün adı giriniz : ");
                string urunAdi = Console.ReadLine();
                urunAdları.Add(urunAdi);

                Console.Write("Ürün fiyatı giriniz (çıkmak için 0 girin): ");
                double urunFiyati = Convert.ToDouble(Console.ReadLine());
                urunFiyatları.Add(urunFiyati);
                if (urunFiyati == 0)
                    break;
            }
            for (int i = 0; i <urunAdları.Count; i++)
            {
                Console.WriteLine(urunAdları[i] + " : " + urunFiyatları[i] );
            }
        }
       
        

    }
}
