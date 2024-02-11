

namespace Class2
{
    internal class ListeleriKarsilastir
    {
        public void İkiListe()
        {
            List<int> liste1 = new List<int>();
            List<int> liste2 = new List<int>();
            Random rastgele = new Random();

            // Listelere rastgele sayılar ekleme
            for (int i = 0; i < 10; i++)
            {
                liste1.Add(rastgele.Next(1, 101));
                liste2.Add(rastgele.Next(1, 101));
            }

            // İlk liste elemanlarını yazdırma
            Console.WriteLine("Liste 1:");
            foreach (var sayi in liste1)
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();

            // İkinci liste elemanlarını ters sıralı olarak yazdırma
            Console.WriteLine("Liste 2 (Ters Sıralı):");
            for (int i = liste2.Count - 1; i >= 0; i--)
            {
                Console.Write(liste2[i] + " ");
            }
            Console.WriteLine();

            // Puanlama işlemi
            int puanListe1 = 0;
            int puanListe2 = 0;
            for (int i = 0; i < 10; i++)
            {
                if (liste1[i] > liste2[i])
                {
                    puanListe1++;
                }
                else if (liste2[i] > liste1[i])
                {
                    puanListe2++;
                }
            }

            // Sonucu yazdırma
            if (puanListe1 > puanListe2)
            {
                Console.WriteLine("İlk liste, ikinci liste üzerinde üstün.");
            }
            else if (puanListe2 > puanListe1)
            {
                Console.WriteLine("İkinci liste, ilk liste üzerinde üstün.");
            }
            else
            {
                Console.WriteLine("İki liste eşit.");
            }
        }
    }
}
