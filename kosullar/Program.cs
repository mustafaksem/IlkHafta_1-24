// See https://aka.ms/new-console-template for more information

//// &&  ve : Bu operatör verilen koşulların hepsinin olmasını bekler.

//// || veya : Bu operatör verilen koşullardan herhangi birisinin olmasını bekler.

//int a = 10;
//int b = 20;

//if (a>5 && b <30 )
//{
//    // her iki koşulda sağlandığından bu kısım çalışır.
//}

//if (a==5 || b<20)
//{
//    // iki koşul da sağlanmadığından bu kısım çalışmaz.
//}

//if (a > 5 || b < 20)
//{
//    // İlk koşul sağlar ikinci sağlamaz. veya operatörü bu kısmı çalıştıtıt.
//}

//if (a > 5 && a<30 || b<10 || b>6)
//{
//    // buradaki koşul sağlanır ve bu kısma düşer
//}

// 1den başlayıp 100 e kadar olan sayıların 5 ve 7 ile bölünebilenler dışındakileri toplayınız.

//int toplam = 0;

//for (int i = 1; i < 100; i++)
//{
//    if (i % 5 == 0 && i % 7 == 0)
//    {
//        continue;       
//    }
//    toplam += i;
//}
//Console.WriteLine("toplamı: " + toplam);


// 1 den başlayıp 12 ye kadar olan sayıların 3 ile bölünebilenler haricinde çarpımını hesaplayınız.

//int carpim = 1;

//for (int i = 1; i < 12; i++)
//{
//    if (i % 3 == 0)
//    {
//        continue;
//    }
//    carpim *= i;
//}
//Console.WriteLine("çarpımı: " + carpim);

// Faktöriyel : 5! = 5* 4* 3 * 2*1 =

// kullanıcı tarafından girilen bir sayının faktöriyelini hesaplayan uygulama

//Console.Write("Sayı giriniz: ");
//int sayi = Convert.ToInt32(Console.ReadLine());

//int faktor = 1;
//for (int i = 1; i<=sayi ; i++)
//{
//    faktor *= i;
//}
//Console.WriteLine(faktor);

// Bir sayının asal sayı olup olmadığı kuralı yalnızca 1 e ve kendisine bölünebilen başka hiçbir sayıya bölünemeyen sayıdır. kullanıcının
// girdiği sayının asal olup olmadığını yazınız.

using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;


//Console.Write("Sayı giriniz: ");
//int sayi = Convert.ToInt32(Console.ReadLine());
//if (sayi % 2 == 0 || sayi % 3 == 0 || sayi % 4 == 0 || sayi % 5 == 0 || sayi % 6 == 0 ||
//    sayi % 7 == 0 || sayi % 8 == 0 || sayi % 9 == 0 || sayi % 10 == 0)
//{
//    Console.WriteLine(sayi + " sayi asal sayı değildir.");
//}
//else
//{
//    Console.WriteLine(sayi + " sayi asal sayıdır.");
//}

//Console.Write("Sayı giriniz: ");
//int sayi = Convert.ToInt32(Console.ReadLine());

//int sayac = 0;
//for (int i = 2; i < sayi; i++)
//{


//    if (sayi % i == 0)
//    {
//        sayac += 1;
//        Console.WriteLine("asal değil");
//        break;
//    }
//}
//if (sayac == 0)
//{
//    Console.WriteLine("Asal");
//}


// Kullanıcı tarafından girilen iki sayı arasındaki sayıları ekrana ayzan uygulama

//Console.Write("Başlangıç sayısı:");
//int baslangic = Convert.ToInt32(Console.ReadLine());

//Console.Write("Bitiş sayısı:");
//int bitis = Convert.ToInt32(Console.ReadLine());
//if (bitis > baslangic) 
//{

//for (int i = baslangic; i <= bitis; i++)
//{
//    Console.WriteLine("Girilen aralıktaki sayılar:" + i);
//}
//}else if(bitis == baslangic)
//   {
//    Console.WriteLine("iki sayı eşittir arasında tam sayı değeri yoktur.");
//}
//else
    
//for(int i = baslangic; i >= bitis; i--) 
//{
//    Console.WriteLine("Girilen aralıktaki sayılar:" + i);
//}

// Kullanıcı tarafından girilen 5 sayıdan tek olanların toplamını bulan uygulama



Console.WriteLine("Lütfen 5 sayı girin:");
int toplam = 0;
for (int i = 1; i <= 5; i++)
{
    Console.Write("Sayı: ");
    int sayi = Convert.ToInt32(Console.ReadLine());

    if (sayi % 2 != 0)
    {
        toplam += sayi;
    }
}

Console.WriteLine("Tek sayıların toplamı: " + toplam);











