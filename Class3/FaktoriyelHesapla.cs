using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Class3
{
    internal class FaktoriyelHesapla
    {
        int sonuc = 1;

        public FaktoriyelHesapla(int girilenSayi)
        {
            for (int i = 1; i <= sonuc; i++)
                sonuc *= sonuc;
            Console.WriteLine(sonuc);
        }
    

    }
}
