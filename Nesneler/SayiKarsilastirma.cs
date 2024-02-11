using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesneler
{
    public class SayiKarsilastirma
    {
     
        public void SayiKarsilastir()
        {
            Random rndm = new Random();
            int random = rndm.Next(1, 100);        
            Console.WriteLine("Rastgele üretilen sayı : " + random);

            if (random > 50)
            {
                Console.WriteLine("Üretilen sayı 50'den büyük.");
            }
            else if (random < 50)
            {
                Console.WriteLine("Üretilen sayı 50'den küçük.");
            }
            else
            {
                Console.WriteLine("Üretilen sayı 50'ye eşit.");
            }
        }
    }
}
