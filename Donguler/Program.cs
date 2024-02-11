// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization.Formatters;



// Döngüler 

// Amaç bir işin birden fazla kez yapılması durumunda tek bir yerden kontrol edilebilmesidir.
// Döngüde başlangıç, bitiş ve artış miktarı olmak üzere 3 adet veri bulunur.
// Sonsuz döngü kavramı vardır ancak bir yerde durmalıdır.
// Döngüyü durdurmak için break komutu kullanılır.
// Döngüde bir sonraki adıma atlamak için continue komutu kullanılır.
// Döngüler for ve while döngüsü olmak üzere ikiye ayrılır. Temelde aynı iş için kullnaıllır.
// For için başlangıç, bitiş ve artış miktarı gerekir.
// while için bir koşul olana kadar çalış planı vardır.

// for döngüsü

//for (int i = 0; i < 10; i++)           i burada bir değişken ( sayaç)
//                                       en başta i nin sayısal başlangıç değeri verilir. örnekte 0 
//{         yazdırdı ama yanlış??        sonrasında i <10 demek i nin 100 den küçük olana kadar döngünün dönmesini sağlar.
//                                       i++ demek i nin birer birer artacağını söyler bu da döngünün nasıl döneceğini belirler.
//}


// 1 den başlayıp 10 kadar 1 er 1er artan döngü

//for (int i = 1; i < 10; i++)
//{
//    Console.WriteLine(i);
//}

// 7 den başlayıp 20 ye kadar ikişer artan döngü

//for (int i = 7;i < 20; i+=2)
//{
//    Console.WriteLine(i+ " adımı");
//}

// 1 - Mustafa 3 -5 19- Mustafa yazdır

//for (int i = 1; i < 20; i += 2)
//{
//    Console.WriteLine(i + " - Mustafa");
//}

// break ve continue 

//for (int i = 0; i < 10; i++)
//{
//    if (i > 0)
//    {
//        continue;               // bu kısıma geldiğinde aşağıdaki kodlar okunmaz bir sonrakinden döngü devam eder.
//    }
//    if (i ==5)
//    {
//        break;                  // bu kısıma geldiğinde döngü tamamen durur. Sonraki adımlar çalışmaz.
//    }
//}


// ekrana 1 den 50 ye kadar çift sayıları yaz ama 10 un katları yazılmasın

//for (int i = 0;i <= 50; i+=2)
//{

//    if ((i % 10) == 0)
//    {
//        continue;
//    }
//    Console.WriteLine(i);
//}

// 0 dan başlayıp Kulanıcıdan aldığımız bir sayıya kadar tek sayıları ekrana yaz
// 0 dan başlayıp Kulanıcıdan aldığımız bir sayıya kadar çift sayıları ekrana yaz

//Console.Write("Bir sayı girin: ");
//int sayi = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("0'dan {0}'a kadar olan tek sayılar:", sayi);

//for (int i = 1; i < sayi; i += 2)
//{
//    Console.WriteLine(i);
//}

//Console.Write("Bir sayı girin: ");
//int sayi1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"0'dan {sayi1}'a kadar olan çift sayılar:", sayi1);

//for (int i = 0; i < sayi; i += 2)
//{
//    Console.WriteLine(i);
//}

// Mod işlemi (kalan) hesaplama
// Bir sayının başka bir sayıya bölümünden kalanı bulmak için kullanılır.
// Çoğunlukla çift sayı tespitinde kullanılır.

// örnek : 33 sayısının 5 modu = 33 / 5 kalan 3 tür mod alma ile direkt bulunabilr.

//int sayi = 33;
//int kalan = sayi % 5;   //sonuç = 3 olacaktır.

//int kontrol = sayi % 2;
//if (kontrol == 0)
//{
//    // çift sayı
//}

// 1 den başlayıp kullanıcının girdiği sayı dahil olmak üzere toplayan ve sonucun 10 ile bölümünden kalanı bulan kod

//Console.Write("Bir sayı girin: ");
//int sayi = Convert.ToInt32(Console.ReadLine());
//int toplam = 0;

//for (int i = 1; i <= sayi; i++)
//{

//    toplam = toplam + i;
//}

//int kalan = toplam % 10;

//Console.WriteLine("1'den girilen sayıya kadar olan sayıların toplamının 10'a bölümünden kalan: " + kalan );

//Sonsuz for döngüsü
//for (; ; )                    sonsuz for döngüsünü bir değeri beklemek ve o değer gelince durdurmak için yada devam ettirmek için
//{                             dinleme modu gibi düşünebilirsiniz. genellikle while ile yapılır.

//}


// İç içe for döngüsü

//for (int i = 1;i <= 5; i++)
//{
//    for (int j = 1; j <= 3; j++) 
//    {
//        Console.WriteLine(i + "," + j);
//    }
//}

// çarpım tablosunu döngü kullanarak ekrana yazınız

//for (int i = 1; i <= 10; i++)
//{
//    for (int j = 1; j <= 10; j++)
//    {
//        Console.WriteLine(i + "*" +j +  "=" + (i * j));              
//    }
//    Console.WriteLine();
//}

// Aşağıdaki kuralı for döngüsü kullanarak yazdırınız.
// 50, 48, 46 ........0

//for (int i = 50; i >= 0; i -= 2)
//{
//    Console.WriteLine(i);
//}

// 10 dan geriye doğru 0 a kadar olan asyıları for döngüsü kullanarak yanyana yazınız

string toplam =" " ;
for (int i = 10; i > 0; i--)
{
    toplam +=Convert.ToUInt32(i);
}
Console.Write(toplam);
Console.WriteLine();    // nasıl sonra dışarı çıkıp yazdırıabildik sor yarın

int sayilar = 0;
for (int j = 10; j > 0; j--)
{
    sayilar = j;
}
Console.Write(sayilar);     // yada bu neden çalışmadı 