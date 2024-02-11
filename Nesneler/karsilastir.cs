using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesneler
{
    internal class karsilastir
    {
        public void ToplamiKontrolEt()
        {
            Console.WriteLine("lütfen 1. sayıyı griiniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen 2. sayıyı griiniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 + sayi2 > 50)
            {
                Console.WriteLine("Toplam 50 den büyük");
            } else if (sayi1 + sayi2 < 50)
            {
                Console.WriteLine("Toplam 50 den küçük");
            }else
            {
                Console.WriteLine("50 ye eşit");
            }
            
           
        }
    }  
}
