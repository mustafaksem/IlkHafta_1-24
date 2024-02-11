// See https://aka.ms/new-console-template for more information
using Class3;


// CLASS 3

// Constructor ( yapı kurucu ) : Class örneği alınırken ilk çalışan ve çalışmak için çağğırılmasına ihtiyaç duyulmayan fonksiyonardır.

// Bu fonksiyonlar class ile aynı isimde olmak zorundadır.
// Bu fonksiyonlarda geri dönüş değeri yazılmaz, hatta void bile yazılmaz.
// Property 'ler tanımlanır ancak direkt değer vermek yerine constr. üzerinden değer gönderimi yapılabilir.

//Sinema sin = new Sinema("Salon 1", 40);
//sin.BiletSat(true);
//sin.BiletSat(false);
//sin.BiletSat(true);
//Console.WriteLine(sin.BakiyeKontrolEt);
//Console.WriteLine(sin.BosKoltukKontrolEt);

// Soru 1 : Kullanıcı tarafından ürün adı ve ürün fiyatının girmesi sağlanacak ürün fiyatı 0 girilene kadar bu işlem devam edecek. Kullanıcının girdiği tüm ürünleri ekrana yazan class yapısı kullanarak oluşturunuz.
// elma : 10 - Armut : 30 - Ayva : 20

//Urunler list = new Urunler();
//list.UrunlerListele();

// Soru 2 :  Kullanıcı tarafından girilen iki sayı arasındaki asal sayıların ortalamasını alan asal sayıları ve ortalamasını ekrana yazan uygulamayı ekrana yazdırınız. Asal sayıları listeleme ve ortalamayı yazdırma iki ayrı fonksiyon olsun.

//Console.Write("İlk sayıyı girin: ");
//int ilkSayi = Convert.ToInt32(Console.ReadLine());

//Console.Write("İkinci sayıyı girin: ");
//int ikinciSayi = Convert.ToInt32(Console.ReadLine());
//AsalOrtalama ao = new AsalOrtalama();

//Console.Write("Girilen iki sayı arasındaki asal sayılar");
//ao.AsalSayiListesi(ilkSayi,ikinciSayi);

//Console.Write("Girilen iki sayı arasındaki asal sayıların ortalaması");
//ao.OrtalamaYazdir(ilkSayi,ikinciSayi);


// soru 3 :  Kullanıcı tarafından girilen bir sayınıın faktöriyelini hesapayan constructor üzerinde hesaplayıp ekrana yazan uygulama



// kullanıcı tarafından girilen iki sayının toplamını constructor üzerinde hesaplayıp ekrana yazdıran uygulama
Console.Write("İlk sayıyı girin: ");
int girilenSayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci sayıyı girin: ");
int girilenSayi2 = Convert.ToInt32(Console.ReadLine());

Toplama toplam =new Toplama(girilenSayi1, girilenSayi2);