// See https://aka.ms/new-console-template for more information
using System.Collections;



// Döngüler 3 

// do-while döngüsü : Koşulun doğruluğunu kontrol etmeden 1 kez çalışır sonrasında döngü şartına bakarak devam eder.
// While döngüsüne benzzer ancak while döngüsü koşulun doğruluğunu başta kontrol eder, do while bir kez çalıştıtıp sonra kontrol eder.

// 

//do
//{
//            (her türlü çalışır burası)
//} while (Koşul buraya yazılır);


//int i = 5;
//do
//{
//    Console.WriteLine( i);          // önce burayı çalıştırır 5 yazar sonra while a bakar koşul sağlanmadığı için döngü durur.
//    i++;
//} while (i<4);

// Soru1 : Rakamları(0-9) ekrana do while döngüsü kullanarak yazdırınız.

//int i = 0;
//do
//{
//    Console.Write(i + "-");
//    i++;
//} while (i<10);

// Soru2 : A dan başlayıp Z dahil olmak üzere türk alfabesindeki harfleri ekrana do wwhile ile yazdıınız( ipucu: diziler)

//string[] harf = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", 
//    "T", "U", "Ü", "V", "Y", "Z" };
//int i = 0;
//do
//{
//    Console.Write(harf[i] + " ");
//    i++;
//} while (i < harf.Length);

// Soru 3 : Kullanıcı tarafından girilen 10 sayıdan kaç tanesinin 20 den büyük olduğunu do while döngüsü ile bulunuz.

//int sayac = 1;
//do
//{
//	if (Convert.ToInt32(Console.ReadLine()) >20 )
//	{
//		adet++;
//	}
//	sayac++;
//} while (sayac<=10);
//Console.WriteLine("girilen 10 sayıdan " + adet + "tanesi 20 den büyüktür");

// FOR - EACH DÖNGÜSÜ 

//int[] dizi = {20,30,12,43,24,56,71,23 };

//foreach (int i in dizi)
//{ Console.WriteLine(i); }

// Soru4: foreach döngüsü kullanarak ders 1 , ders 2, ..... ders 10 şeklinde yazdırınız.

//string[] dersler = new string[10];

//for (int i = 1; i <= 10; i++)
//{
//    string dersadi = "ders" + i;
//    dersler[i - 1] = dersadi;
//}

//foreach (string ders in dersler)
//{
//    Console.WriteLine(ders);
//}

// Soru 5 : foreach döngüsü kullanarak notlar dizisindeki verileri 50 ile karşılaştırıp her bir sonucu ekrana yazdırınız.
// örnek : dizideki x elemanı 50 sayıdından büyüktür.

//int[] notlar = { 100, 50, 85, 90, 25, 45, 37, 75};
//foreach (int not in notlar)
//{
//    if (not > 50)
//    {
//        Console.WriteLine("Dizideki " + not + " sayısı 50'den büyüktür.");
//    }
//    else if (not == 50)
//    {
//        Console.WriteLine("Dizideki "+ not+ " sayısı 50'ye eşittir.");
//    }
//    else
//    {
//        Console.WriteLine("Dizideki " +not+ " sayısı 50'den küçüktür.");
//    }
// }

// Soru6 : 20 adet rastgele sayının (1-100) toplamını foreach kullanarak yapınız

//Random rndm = new Random();
//int[] sayilar = new int[20];

//for (int i = 0; i < sayilar.Length; i++)
//{
//    sayilar[i] = rndm.Next(1, 100);
//}

//foreach (int sayi in sayilar)
//{
//    Console.Write($"{sayi} ");
//}

//int toplam = 0;
//foreach (int sayi in sayilar)
//{
//    toplam += sayi;
//}
//Console.WriteLine();
//Console.WriteLine("Toplam : " + toplam);

// Soru7 : Kullanıcı 0 girene kadar girilen 0 girene kadar girirlen tüm sayılaardan tek sayıların ve çift sayılaarın toplamlarını foreach ile 
// hesaplayan uygulama

//ArrayList sayilar = new ArrayList();
//int girilenSayi;

// Console.Write("Sayı girin (0 girerek çıkış yapabilirsiniz): ");
//girilenSayi = Convert.ToInt32(Console.ReadLine());
//do
//{
//    if (girilenSayi != 0)
//    {
//        sayilar.Add(girilenSayi);
//    }

//} while (girilenSayi != 0);
//int girilenSayi = Convert.ToInt32(Console.ReadLine());


ArrayList sayiList = new ArrayList();
Console.WriteLine("Lütfen sayı giriniz : ");

while (true)
{
        int girilenSayi = Convert.ToInt32(Console.ReadLine());
        if (girilenSayi == 0)
            break;
        else
            sayiList.Add(girilenSayi);  
}

int tekToplam = 0;
int ciftToplam = 0;

foreach (int sayi in sayiList)
{
    if (sayi % 2 == 0) 
    {
        ciftToplam += sayi;
    }
    else 
    {
        tekToplam += sayi;
    }
}
Console.WriteLine("Tek sayıların toplamı : "+ tekToplam);
Console.WriteLine("Çift sayıların toplamı : "+ ciftToplam);