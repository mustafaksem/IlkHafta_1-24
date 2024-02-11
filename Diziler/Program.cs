// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// DİZİLER (Array)

// Diziler birden fazla değer alabilen değişkenlerdir.
// Aynı türdeki  verileri tek bir isim altında saklamayı sağlayan değişkenlerdir.
// Tanımlama yaparken önce dizinin tipi belirlenir. ( string, int, bool, double...)
// Tip belirlendikten sonra dizinin ismi (değişken adı) ve kaç eleman olacağı söylenir.

// Örnek1 : 10 elemanlı tamsayı rakamların olduğu bir dizi

//int[] sayiar = new int[10];

// Örnek2 : 10 elemanlı metinsel ifadelerin olduğu bir dizi

//string[] ogrenciler = new string[10];

// Dizinin elmanlarına değer atama
// NOT :  Dizilerde ilk eleman 0 index/indis ile başlar.

//ogrenciler[0] = "Ali";
//ogrenciler[0] = "Mustafa";
//ogrenciler[9] = "Ayşe";

// Dizinin lemanlarına tanımlama yaparken değer atama

//int[] sayilar2 = {11, 24, 3, 4, 5, 6, 7, 8, 9, 10 };

// Diziyi ekrana yazdırma

//Console.WriteLine(ogrenciler[0]);

//int[] sayilar3 = new int[5];
//sayilar3[0] = 1;
//sayilar3[2] = 1;
//sayilar3[0] = 1;

// Soru1: 10 elamanlı tam sayı dizisi oluşturunuz ve tüm elemanları alt alta yazdırınız

//int[] sayilar = {1,2,3,4,5,6,7,8,9,10 };

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(sayilar[i]);
//}

// Soru1: Rastgele 10 elamanlı tam sayı dizisi oluşturunuz ve tüm elemanları alt alta yazdırınız

//int[] sayilar1 = new int[10];

//for (int i = 0; i < sayilar1.Length; i++)
//{
//    Random rndm = new Random();
//    sayilar1[i] = rndm.Next(1, 15);
//    Console.WriteLine(sayilar1[i]);
//}

// Diziler içerisinde kullanılan yontemler.

// Bir dizinin eleman sayısını bulmak               sayilar.Length

// Diziyi temizlemek  
// Array.Clear(sayilar1, 1, 3 );                    sayilar1 dizisinde 1 nolu indexten başlayıp 3 adet içeriği temizle, boşalt, null yap

// Dizi elemanlarını terse çevirmek                 Array.Reverse(sayilar1);

// Dizi içerisidneki elemanları sıralamak           Array.Sort(sayilar1);

// Dizinin içerisinde elaman aramak                 Array.IndexOf(sayilar1, 3) 
// bir dizide değer olarak bir elman aranıyorsa eğer bulursa o elemanın dizideki sırasını (imdex nosunu) verir
// eğer bulamazsa -1 değerini verir.


// Soru2 :  20 elemanlı rastgele sayılardan oluşan bir dizi oluştutunuz ve küçükten büyüğe sıralayarak elemanları yadırınız.

//int[] sayilar1 = new int[20];

//for (int i = 0; i < sayilar1.Length; i++)
//{
//    Random rndm = new Random();
//    sayilar1[i] = rndm.Next(1, 100);  
//}
//Array.Sort(sayilar1);
//Array.Reverse(sayilar1);
//for (int i = 0; i < sayilar1.Length; i++)
//{
//    Console.WriteLine(sayilar1[i]);
//}

// aynı diziye sonradan tersine sırala, eleman sayısını bul, 3 rakamı varsa nerede sor ve 1 den başla 3 tane sil. 
//Console.WriteLine("Eleman sayısı : " +sayilar1.Length);
//Console.WriteLine("Dizide 3 rakamı varsa nerede? " + Array.IndexOf(sayilar1, 3));
//Array.Clear(sayilar1, 1, 3);
//for (int i = 0; i < sayilar1.Length; i++)
//{
//    Console.WriteLine(sayilar1[i]);
//}

// Soru3 : 10 elemanlı rastgele sayılardan oluşan bir dizide kullanıcının gireceği bir sayıyı arayan ve kaçıncı sırada olduğunu söyleyen uygulama

//int[] sayilar1 = new int[10];

//for (int i = 0; i < sayilar1.Length; i++)
//{
//    Random rndm = new Random();
//    sayilar1[i] = rndm.Next(1, 10);
//}

//Console.Write("Aranacak Sayıyı Girin: ");

//int arananSayi = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < sayilar1.Length; i++)
//{
//    Console.Write(sayilar1[i] + " - ");
//}
//int index = Array.IndexOf(sayilar1, arananSayi) ;
//if (index == -1)
//{
//    Console.WriteLine($" Aranan sayı ({arananSayi} sayısı) dizide bulunamadı.");
//}else
//{
//    Console.WriteLine($"{arananSayi} sayısı dizide {index+1}. sıradadır. ");
//}


// Soru4 : 20 elemanlı rastgele sayılardan oluşan -10,10 aralığında sayılardan oluşan bir dizide kaç sayının pozitif, negatif ve 0 olduğunu 
// kullanıcıya veren uygulama

//int[] sayilar1 = new int[10];

//for (int i = 0; i < sayilar1.Length; i++)
//{
//    Random rndm = new Random();
//    sayilar1[i] = rndm.Next(1, 10);
//}

//Console.Write("Aranacak Sayıyı Girin: ");

//int arananSayi = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < sayilar1.Length; i++)
//{
//    Console.Write(sayilar1[i] + " - ");
//}
//int index = Array.IndexOf(sayilar1, arananSayi);
//if (index == -1)
//{
//    Console.WriteLine($" Aranan sayı ({arananSayi} sayısı) dizide bulunamadı.");
//}
//else
//{
//    Console.WriteLine($"{arananSayi} sayısı dizide {index + 1}. sıradadır. ");
//}


int[] sayilar = new int[20];

for (int i = 0; i < sayilar.Length; i++)
{
    Random rndm = new Random();
    sayilar[i] = rndm.Next(-10, 11);
}

Console.WriteLine("Dizi Elemanları:");
for (int i = 0; i < sayilar.Length; i++)
{
    Console.WriteLine(sayilar[i]);
}

int pozitif = 0;
int negatif = 0;
int sifir = 0;

for (int i = 0; i < sayilar.Length; i++)
{
    if (sayilar[i] > 0)
    {
        pozitif++;
    }
    else if (sayilar[i] < 0)
    {
        negatif++;
    }
    else
    {
        sifir++;
    }

}

Console.WriteLine( "Pozitif sayı adeti : "+ pozitif);
Console.WriteLine( "negatif sayı adeti : "+ negatif);
Console.WriteLine( "sıfır sayı adeti : "+ sifir);