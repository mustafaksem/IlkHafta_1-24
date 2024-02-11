// See https://aka.ms/new-console-template for more information
using System.Collections;
// METODLAR (METHODS)

// Amacı istenilen yerde belirtilen kod parçalarının istenildiği kadar çalıştırılmasını sağlamak.

// AVANTAJLARI :
// Aynı kodu defalarca yazmaya gerek kalmayacaktır.
// Zamandan tasarruf sağlayacaktır.
// Kod yazarken hata yapmayı azaltacaktır.
// Kodun okunması kolaylaşacaktır.

// Tanımlama 

// 1. Erişim türü : Programın diğer bölümlerinden bu metoda erişim olup olmayacağının belirlendiği yerdir.
// public : Programın her yerinden erişim isteniyorsa kullanılır.
// static : Ana metod denilen Main kısmından erişim sağlanması isteniyorsa kullnaılır.
// private : Herhangi bir erişim türü belirlenmezse bu devreye girer. Yalnızca yazıldığı sınıfın içinde kullanılır.

// 2. Dönüş tipi : Dönüş tipinde geriye bir değer dönmezse bu bir metod, geriye bir değer dönerse fonksiyon olur. geriye dönüş int, str, bool vs.
//                  (anahtar kelime: return(fonks), void (metod))

// 3. Metod ismi : Değişken oluşturma kuralları dahilinde bir isim verilir.

// 4. Parametre listesi : Zorunlu değildir. Metod kısmına iletilecek bir bilgi yada bilgileri temzil eder.


// ÖRNEK1 : 

// Ekrana merhaba yazan metod

using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;

void MerhabaYaz()
{
    Console.WriteLine("Merhaba");
}

//***NOT*** : Metod tanımlamak çalıştırmak anlamına gelmez. Tanımlandıktan sonra ayrıca çağrılması gerekir.

// Çağırma işlemi 

MerhabaYaz();

// NOT 2 : Bir metod aynı yerde istenildiği kadar çağrılabilir. Ancak aynı isimle ve aynı parametre ile bir metod daha tanımlanamaz.

// Örnek 2: Kullanıcının girdiği sayının 5 katını ekrana yazan metod

//void BesKatiniHesapla ()
//{
//    int sayi = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine(sayi * 5);
//}
//BesKatiniHesapla();
//BesKatiniHesapla();

// Soru1 : Kullanıcıdan adını ve soyadını alıp ad ve soyadı arasında boşluk bırakarak ekrana yazan metod

//void AdSoyadYazdır()
//{
//    Console.Write("adınızı giriniz : ");
//    string ad=Console.ReadLine();
//    Console.Write("Soyadınızı giriniz : ");
//    string soyAd = Console.ReadLine();
//    Console.WriteLine(ad + " " + soyAd);
//}
//AdSoyadYazdır();

// Soru2 :  kullnıcı tarafından girilen 3 sayının ort hesaplayan ve ekrana ayzdıran metodu yazınız

//void UcSayininOrtalamasi()
//{
//    Console.Write("1. sayıyı giriniz : ");  
//    int sayi1 = Convert.ToInt32(Console.ReadLine());
//    Console.Write("2. sayıyı giriniz : ");
//    int sayi2 = Convert.ToInt32(Console.ReadLine());
//    Console.Write("3. sayıyı giriniz : ");
//     int sayi3 = Convert.ToInt32(Console.ReadLine()); 
//     Console.WriteLine("Sayıların ortalaması : " + (sayi1+sayi2+sayi3)/3);
//}
//UcSayininOrtalamasi();

// Soru 3 :  Kullanıcı 0 girene kadar girilen sayıların toplamını ekrana yazan methodu yazınız.

//void ToplamHesapla()
//{
//    int toplam = 0;
//    while (true)
//    {
//        try
//        {
//            Console.Write("Lütfen toplanasını istediğniz sayıları giriniz (0 işlemi sonlandırır) :");
//            int girilenSayi = Convert.ToInt32(Console.ReadLine());
//            toplam += girilenSayi;

//            if (girilenSayi == 0)
//                break;
//        }
//        catch (Exception)
//        {
//            Console.WriteLine("Şu ana kadar ki toplamlar : " + toplam);
//            Console.WriteLine( "Hatalı giriş yaptınız. Lütfen belirtilen değerlerden giriniz : ");
//        }
//    }
//    Console.WriteLine("girilen sayıların toplamı : " + toplam);

//}
//ToplamHesapla();

// Soru4 : Kullanıcı çift sayı girene kadar çalışan bir metod yazınız. ( not:  while yada for kullanılmayacak tek sayı girdiğinde ekrana girdiği 
//  sayı yazılacak çift sayı girsiğinde tammalandı yazacak ve tekrar sormayacak, tek sayı girdiği müddetçe tekrar sorulacak)

//void SayiCiftTek()
//{
//    try
//    {
//        int sayi = Convert.ToInt32(Console.ReadLine());
//        if (sayi % 2 == 0)
//        {
//            Console.WriteLine("Tamamlandı.");
//        }
//        else
//        {
//            Console.WriteLine("Tek sayı girdiniz tekrar deneyiniz.");
//            SayiCiftTek();
//        }
//    }
//    catch (Exception)
//    {

//        Console.WriteLine( "hatalı veri girdiniz.");
//    }
//}
//SayiCiftTek();


// Soru5 : Kullanıcı tarafından girilen bir sayının asal sayı olup olmadığını gösteren metodu yazınız.

//void AsalMi()
//{
//    int i =0;
//    int sayi=Convert.ToInt32(Console.ReadLine());
//   for (i = 2; i < sayi; i++)
//    {
//        if (sayi%i==0)
//        {
//            Console.WriteLine("sayı asal değildir.");
//        }else
//            Console.WriteLine("sayi asaldır.");
//    }
//}
//AsalMi();

//void AsalSayi()
//{
//    int sayi = Convert.ToInt32(Console.ReadLine());
//    bool asalMi = true;
//    for (int i = 2; i < sayi-1; i++)
//    {
//        if(sayi%i == 0)
//        {
//            asalMi = false;
//            break;
//        }
//    }
//    if (asalMi==true)
//    {
//        Console.WriteLine("girdiğiniz sayı asaldır");
//    }else { Console.WriteLine("girdiğiniz sayı asal değildir."); }
//}
//AsalSayi();

// Kulanıcı tarafından girilen iki sayının üssel hesaplamasını metod kullanarak yapınız.
// (2-3) : 2*2*2=8)

void UsHesabi()
{
    Console.Write("Taban sayısını giriniz :");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.Write("üs sayısını giriniz :");
    int sayi1 = Convert.ToInt32(Console.ReadLine());

    int ushesabi = 1;
    for (int i = 0; i < sayi1; i++)
    {
        ushesabi *= sayi;
    }
    Console.WriteLine(" sonuç : "+ushesabi);
}
UsHesabi();

