// See https://aka.ms/new-console-template for more information


//  Object Oriented Programming ( neseneye dayalı programlama)

// Teorik olarak tüm programlama dillerine uyarlanabilir.
// Günlük hayatta gördüğümüz nesnelerin programlama dünyasına tsşınmasıdır.
// Sınıf (Class)    :   Bir alem, küme vb. belirli nesnelerin genel ifadesi ( Örn: Hayvanlar, insanlar,9
// Nesne (OBject)   :   Sınıftan türetilen kendi içinde farklılaşan ancak her zaman sınıfın özellikklerini taşıyan varlıklar ( Örn : Maymun nesne Hayvanlar sınıfından)
// Property (Özellik):  Nesnelerin  bir sınıf içindeki özelliği (Örn:ayak sayısı, kulak sayısı, boy uzunluğu vb öz )
// Fonksiyon        :   Bir iş, haraket içeren nesnenin sınıf içindeki aksiyonu

// Bir class tanımlanırken public yapmak her yerden erişilebilirlik sağlayacaktır.

using Nesneler;

//Hayvanlar x = new Hayvanlar();      // Instance almak , örnek almak 

//// Artık x  bizim için class değil bir object yani nesne

//x.ayakSayisi = 5;
//x.hayvanAdi = "xyz";

//Hayvanlar y = new Hayvanlar();
//y.ayakSayisi = 0;
//y.hayvanAdi = "abc";

//// İki tane hayvanlar class'ından türetilen nesne ( x-y )

//int xkalori = x.yemeİcme();
//int ykalori = y.yemeİcme();

// Soru1 :  Yeni bir class oluşturunuz bu classa gelecek 2 sayının toplamını versin.

//ToplamaIslemi ikiSayiToplam = new ToplamaIslemi();

//ikiSayiToplam.sayi1 = 5;
//ikiSayiToplam.sayi2 = 5;
//int sonuc = ikiSayiToplam.Topla();
//Console.WriteLine("Toplam:" + sonuc);

// Soru 2 : kullanıcı tarafından girilen 2 sayının toplamı 

//ToplamaIslemi ikiSayiToplam = new ToplamaIslemi();
//Console.Write("Lütfen toplanacak 1. sayıyı girin : ");
//ikiSayiToplam.sayi1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("lütfen toplanacak 2. sayıyı girin : ");
//ikiSayiToplam.sayi2 = Convert.ToInt32(Console.ReadLine());
//int sonuc = ikiSayiToplam.Topla();
//Console.WriteLine("Toplam:" + sonuc);

// Soru2 : Kullanıcı tarafından girilen ismin girilen sayı kadar ekrana yazıldığı class yapısını oluşturunuz.

//IsimYazdirma yz = new IsimYazdirma();
//Console.Write("Adınızı girin: ");
//yz.isim = Console.ReadLine();
//Console.Write("Kaç kere yazdırmak istediğinizi girin: ");
//yz.sayi= Convert.ToInt32(Console.ReadLine());
//yz.Yaz();

// Soru3 : Rastgele üretilen bir sayının 50 ile karşılaştırılmasını yapan class yapısını oluşturunuz. (1-100 arası)

//SayiKarsilastirma snc = new SayiKarsilastirma();
//snc.SayiKarsilastir();

// Soru 4:  Kullanıcının girdiği  sayı 100 den büyük olması durumunda "başarılı", küçük olması durumunda tekrar soran class yapısını oluştunuz.

//SayiKontrol dene = new SayiKontrol();
//dene.kontol();

// soru 5: iki sayının toplamını 50 ile karşılaştıran class yapısı

karsilastir snc = new   karsilastir();
snc.ToplamiKontrolEt();