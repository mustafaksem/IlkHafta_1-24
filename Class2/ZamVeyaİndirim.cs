//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace Class2
//{
//    public class ZamVeyaİndirim
//    {
//        public void Maas()
//        {
//            try
//            {
//                Console.Write("Lütfen maaş değerini girin: ");
//                double maas = Convert.ToDouble(Console.ReadLine());

//                Console.Write("Lütfen zam veya indirim oranını girin (%): ");
//                double yuzdeOrani = Convert.ToDouble(Console.ReadLine());

//                Console.WriteLine("Yapmak istediğiniz işlemi seçin (1 Zam - 2 indirim):");
//                int indirimMiZamMi = Convert.ToInt32(Console.ReadLine());

//                if (indirimMiZamMi == 1)
//                {
//                    double zamMiktari = maas * (yuzdeOrani / 100);
//                    double yeniMaas = maas + zamMiktari;
//                    Console.WriteLine("Yeni maaş : " + yeniMaas);
//                }
//                else if (indirimMiZamMi == 2)
//                {
//                    double indirimMiktari = maas * (yuzdeOrani / 100);
//                    double yeniMaas = maas - indirimMiktari;
//                    Console.WriteLine("Yeni maaş : " + yeniMaas);
//                }
//                else
//                {
//                    Console.WriteLine("Geçersiz seçim. Lütfen 1 veya 2 girin.");
//                    Maas();
//                }
//            }
//            catch (Exception)
//            {
//                Console.WriteLine("HATA. Lütfen belirtilen değerlerden giriniz.");
//                Maas();
//            }

            
            
//        }
            

//    }
//}
