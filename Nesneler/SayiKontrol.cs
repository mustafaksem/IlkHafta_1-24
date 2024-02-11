using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesneler
{
    public class SayiKontrol
    {
    
        public void kontol()
        {
            int kullaniciGirisi = Convert.ToInt32(Console.ReadLine());

            if (kullaniciGirisi == 100 )
            {
                Console.WriteLine("başarılı");         
            }else
            {
                Console.WriteLine("tekrar deneyiniz:");
                kontol();
            }
        }
      
    }
}
