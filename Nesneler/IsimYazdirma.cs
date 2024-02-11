namespace Nesneler
{
    public class IsimYazdirma
    {
        public string isim;
        public int  sayi;
        public void Yaz()
        {
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine(isim);
               
            }
        }

    }  
}
