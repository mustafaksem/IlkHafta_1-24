// See https://aka.ms/new-console-template for more information



// DİNAMİK DİZİLER

// Burada amaç diziyi tanımlarken kapasitesinin yani kaç elemanlı olacağının belirtilmeye gerek duyulmamasıdır.
// Program içerisinde istenilen kadar eleman eklenebilir.
// Normal dizilerde eleman sayıları azaltılıp çoğaltılamaz.
// Dinamik dizilerde tür sınırlaması yoktur.            ****ÖNEMLİ**** Aynı dizi içerisinde str, int yazılabilir.
// Normal dizilere göre daha performanslıdır. Sebebi 10 elamanlı liste için 100 kapasite yapıp önlem almaya gerek yoktur.
// Capacity :   Dinamik dizinin kapasitesini int türünde göstermek için kullanılır.
// Count :      Dinamik dizinin eleman sayısını int türünde göstermek için kullanılır.
// Add :        Dinamik dizinin SONUNA eleman eklemek için kullanılır.
// Insert :     Dinamik dizide istenilen yere eleman eklemek için kullanılır.
// Remove :     Dinamik dizinin içerisidne belirtilen eleman VARSA silmek için kullanılır.
// RemoveAt :   Dinamik dizide girirlen İNDEXTEKİ değeri silmek için kullanılır.
// Sort :       Dinamik dizi içerisindeki elemanları sıralamak için kullanlır.

// Dinamik dizi tanımlama:

using System.Collections;                     // eğer bu kısım gelmediyse CTRl + . + enter

//ArrayList dizi1 = new ArrayList();          // Dinamik dizi tür ve sayı belirtmeden oluşturuldu.
//int kapasite = dizi1.Capacity;              // Oluşturulan dinamik dizinin kapasitesi
//int elemanSayisi = dizi1.Count;             // Dizinin eleman sayısını verir
//dizi1.Add("Mstfa");                         // Dizi içerisine string türünde bir eleman eklendi.
//dizi1.Add(0);                               // Dizi içerisine int türünde bir eleman eklendi.
//dizi1.Add(10.45);                           // Dizi içerisine double türünde bir eleman eklendi.
//dizi1.Add('A');                             // char
//dizi1.Add(true);                            // bool

//dizi1.Insert(1,"Mustafa");                  // dizinin 1. indexsine ( yani 2.elemanına) Msutafa eklendi.  
//dizi1.Remove("Mustafa");                    // Dizinin içerisinde Mustafa değeri varsa siler.
//dizi1.RemoveAt(1);                          // Dizinin 1. indexine yani 2. elemanındaki değer silinir.
//dizi1.Sort();                               // Diziyi sıralar.

// Soru1: Kullanıcı 0 girene kadar girilen tüm sayıları bir dizide saklayıp en sonunda küçükten büyüğe sıralayıp ekrana yazan uyhulama

//ArrayList sayiList = new ArrayList();
//Console.WriteLine("Lütfen sayı giriniz : ");

//while (true)
//{
//    try
//    {
//        int girilenSayi = Convert.ToInt32(Console.ReadLine());
//        if (girilenSayi == 0)
//            break;
//        else
//            sayiList.Add(girilenSayi);
//    }
//    catch (Exception)
//    {
//        Console.WriteLine("Hata: Lütfen geçerli bir değer girin.");
//    }
//}
//sayiList.Sort();
//Console.Write(" foreach ile Sıralanmış Dizi : ");
//foreach (int sayi in sayiList)
//{
//    Console.Write(sayi + "  ");
//}
//Console.WriteLine();
//Console.Write(" for ile Sıralanmış Dizi : ");

//for (int i = 0; i < sayiList.Count; i++)
//{
//    Console.Write(sayiList[i] + "  ");
//}


// Soru2 :  Kullanıcı tarafından girilecek sayıları bir diziye aktaran çift sayı olması durumunda duran elde edilen listeyi ters çeviren 
// ve ekrana yazan uygulamayı yapınız



//ArrayList sayiList = new ArrayList();
//Console.WriteLine("Lütfen sayı giriniz : ");

//while (true)
//{
//    try
//    {
//        int girilenSayi = Convert.ToInt32(Console.ReadLine());
//        if (girilenSayi % 2 == 0)
//            break;
//        else
//            sayiList.Add(girilenSayi);
//    }
//    catch (Exception)
//    {
//        Console.WriteLine("Hata: Lütfen geçerli bir değer girin.");
//    }
//}
//sayiList.Reverse();

//Console.Write(" Sıralanmış Dizi : ");
//foreach (int sayi in sayiList)
//{
//    Console.Write(sayi + "  ");
//}

// Soru3 : 20 adet 1-100 aralığında rastgele sayılardan oluşan bir listede en büyük sayıyı bulan ve ekrana yazdıran uygulama

ArrayList sayiListesi = new ArrayList();
Random random = new Random();

for (int i = 0; i < 20; i++)
{
    int rastgeleSayi = random.Next(1, 101);
    sayiListesi.Add(rastgeleSayi);
}
Console.WriteLine("Oluşturulan Sayılar:");

for (int i = 0; i < sayiListesi.Count; i++)
{
    Console.Write(sayiListesi[i] + " ");
}

Console.WriteLine();
int enBuyukSayi = 0;

foreach (int sayi in sayiListesi)
{
    if (sayi > enBuyukSayi)
    {
        enBuyukSayi = sayi;
    }
}
Console.WriteLine("En büyük sayı : " + enBuyukSayi);



//sayiListesi.Sort();
//Console.WriteLine(sayiListesi.Count - 1);

// DENEME

//ArrayList dizi = new ArrayList();  
//Random rndm = new Random();
//Console.Write("Lütfen kaç elemanlı dizi istediğinizi giriniz : ");
//int diziElemanlari = Convert.ToInt32(Console.ReadLine());

//Console.Write("lütfen rastgele sayıların hangi aralıklarda olmasını istediğinizi giriniz : ");
//int rastgeleAraliiği = Convert.ToInt32(Console.ReadLine());
//int rastgeleAraliiği1 = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < diziElemanlari; i++)
//{
//    int rastgeleSayilar = rndm.Next(rastgeleAraliiği, rastgeleAraliiği1);
//    dizi.Add(rastgeleSayilar);
//}

//foreach (int i in dizi)
//    Console.WriteLine(i);


