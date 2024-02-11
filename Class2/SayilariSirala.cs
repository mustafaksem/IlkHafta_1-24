//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Class2
//{
//    internal class SayilariSirala
//    {
//        public void Sayilar()
//        {
//            ArrayList sayilar = new ArrayList();

//            while (true)
//            {
//                Console.Write("Lütfen bir sayı girin (0 işlemden çıkış yapar) : ");
//                int sayi = Convert.ToInt32(Console.ReadLine());

//                if (sayi == 0)
//                    break;

//                sayilar.Add(sayi);
//            }
//            sayilar.Sort(); 
//            Console.WriteLine("Sıralanmış Sayılar:");
//            foreach (int sayi in sayilar)
//            {
//                Console.Write(sayi + " ");
//            }
//                Console.WriteLine("En büyük "+ sayilar[0]);
//                Console.WriteLine("En küçük "+ sayilar[sayilar.Count - 1]);

//            }
//        }
//    }
//}   
