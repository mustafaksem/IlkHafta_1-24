// See https://aka.ms/new-console-template for more information


// FONKSİYONLAR

// Yapılan işin sonunda kullanıcıya değer dönüşü olur (return ile)
// Fonksiyon tanımlanırken metod kısmındaki void yerine dönüş yapılan nesnenin türü yazılır.
// metod içerisindeki tüm kurallar burada da geçerlidir.

// ÖRNEK : Kullanıcı tarafından girien iki sayının toplamını kullanıcıya veren ( dönüş yapan, döndüren) uygulama

//int Topla()
//{
//Console.Write("Lütfen 1. sayıyı giriniz");
//int sayi1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Lütfen 2. sayıyı giriniz");
//int sayi2 = Convert.ToInt32(Console.ReadLine());
//int toplam = sayi1 + sayi2;
//    return toplam;
//}
//int a= Topla();
//Console.WriteLine(a);           // ekrana sonuç vermek için 1. yol

//Console.WriteLine(Topla());     // ekrana sonuç vermek için 2. yol

//  Soru 1 :  kullanıcı tarafından girilen 10 adet sayının toplamını kullanıcıya veren fx yazınız.

//int OnSayiTopla()
//{
//    int toplam = 0;
//    for (int i = 1; i < 11; i++)
//    {
//        Console.Write($"Lütfen {i}. sayıyı giriniz : ");
//        int sayi = Convert.ToInt32(Console.ReadLine());
//        toplam += sayi;
//    }
//    return toplam;
//}
//Console.WriteLine("sonuç : " + OnSayiTopla());

// fonksiyon ve metodlarda parametreler

// Parametre fonk. içerisinde kullanılmak üzere dışarıdan gönderilen bilgilerdir.
// Parametre tanım türü ve değişken adı belirkenir.
// Değişken adı bildiğimiz değişken kurallarına göre oluşturulmalıdır.

// ÖRNEK: Kullanıcı tarafından girien iki sayının toplamını kullanıcıya veren ( dönüş yapan, döndüren) uygulama

//int Topla2(int sayi1,int sayi2)
//{
//    return sayi1 + sayi2;
//}
//Console.Write("Lütfen 1. sayıyı giriniz");
//int x1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Lütfen 2. sayıyı giriniz");
//int x2 = Convert.ToInt32(Console.ReadLine());
//Topla2(x1, x2);

// Soru3 :  Dışarıdan 3 adet int türünde parametre alan ve bu sayıları kullanıcıdan alan ortalamsını ehsaplayan fx yazınız.

//double Ortalama(int sayi1, int sayi2, int sayi3)
//{
//    return (sayi1 + sayi2 + sayi3 )/ 3;
//}
//Console.Write("Lütfen 1. sayıyı giriniz : ");
//int x1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Lütfen 2. sayıyı giriniz : ");
//int x2 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Lütfen 3. sayıyı giriniz : ");
//int x3 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Sonuç : " + Ortalama(x1, x2, x3));

// Soru 4 : Parametre olarak 2 tam sayı alan ve bu sayılar arasındali asal sayıları ekrana yazdıran metodu yada fx yazınız.

using System.Collections;

//Console.Write("Başlangıç sayısını girin: ");
//int baslangic = Convert.ToInt32(Console.ReadLine());

//Console.Write("Bitiş sayısını girin: ");
//int bitis = Convert.ToInt32(Console.ReadLine());

//string AsalSayilarListesi(int sayi1, int sayi2)
//{
//    string sayilar = "";
//    int kucukSayi = sayi1;
//    int buyukSayi = sayi2;
//    if (sayi1> sayi2)
//    {
//         kucukSayi = sayi2;
//         buyukSayi = sayi1;
//    }
//    else if (sayi1== sayi2)
//    {
//        return "iki sayı birbirine eşit olduğundan devam edilemiyor.";
//    }
//    for (int i = kucukSayi; i < buyukSayi; i++)
//    {
//        if (AsalSayiMi(i)== true) 
//        {
//            sayilar += i + " - ";
//        }
//    }
//    return sayilar;
//}
//Console.WriteLine(baslangic+ " ve "+ bitis+ " arasındaki asal sayılar : " + AsalSayilarListesi(baslangic, bitis));

//bool AsalSayiMi(int sayi)
//{
//    if (sayi== 2) 
//    {
//        return true;
//    }
//    else 
//    {
//        for (int i = 3; i < sayi; i++)
//        {
//            if (sayi % i == 0)
//            {
//                return false;
//            }
//        }
//    }
//    return true;
//}


// Soru 5 : Kullanıcı tarafından girilen beş sayıdan en büyüğü kullanıcıya veren metod, fonksiyon yazınız.

//void EnbüyükSayi()
//{
//    int[] sayilar = new int[5];
//    for (int i = 0; i < 5; i++)
//    {
//        Console.Write( "lütfen " + (i+1)+ ". sayıyı giriniz : ");
//        sayilar[i] = Convert.ToInt32(Console.ReadLine());
//    }
//    Array.Sort(sayilar);
//    Console.WriteLine(sayilar[4]);
//}
//EnbüyükSayi();

// Soru 6 : Kullanıcı tarafından girilen iki sayı arasındaki tüm sayıları toplayan fx yada metod yazınız.

//Console.Write("Başlangıç sayısını girin: ");
//int baslangic = Convert.ToInt32(Console.ReadLine());

//Console.Write("Bitiş sayısını girin: ");
//int bitis = Convert.ToInt32(Console.ReadLine());

//int SayiarListesi(int sayi1, int sayi2)
//{

//    int kucukSayi = sayi1;
//    int buyukSayi = sayi2;
//    if (sayi1 > sayi2)
//    {
//        kucukSayi = sayi2;
//        buyukSayi = sayi1;
//    }
//    else if (sayi1 == sayi2)
//    {
//        Console.WriteLine(" HATA: İki sayı birbirine eşit ");
//    }
//    int toplam = 0;
//    for (int i = kucukSayi; i < buyukSayi; i++)
//    {
//        Console.Write( i  + " + ");
//        toplam += i;
//    }
//    return toplam;
//}
//Console.WriteLine("= " + SayiarListesi(baslangic, bitis));

// Soru 7 : Kullanıcı tarafından girien iki sayı arasıdnaki tek sayıların ve çift sayılaarın ayrı ayrı toplamlarını veren , iki sayıyı
// da aynı girilmesi durumunda bu bilgileri tekrar isteyen fonks. yada metodu yazınız.


void    TekCİftSAyilar()
{
    int tekToplamlar = 0;
    int ciftToplamlar = 0;
    int sayi1=Convert.ToInt32(Console.ReadLine() );
    int sayi2=Convert.ToInt32(Console.ReadLine() );
    if (sayi1 == sayi2)
    {
        TekCİftSAyilar();
    }
    else if (sayi1 > sayi2)
    {
        for (int i = sayi2 + 1; i < sayi1; i++)
        {
            if (i % 2 == 0)
            {
                ciftToplamlar += i;
            }
            else
            {
                tekToplamlar += i;
            }
        }
    }
    else if (sayi2 > sayi1)
    {
        for (int i = sayi1 + 1; i < sayi2; i++)
        {
            if (i % 2 == 0)
            {
                ciftToplamlar += i;
            }
            else
            {
                tekToplamlar += i;
            }
        }
    }
    Console.WriteLine("Tek sayıların toplamı : " + tekToplamlar);
    Console.WriteLine("çift sayıların toplamı : " + ciftToplamlar);


}
TekCİftSAyilar();