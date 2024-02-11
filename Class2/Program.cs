// See https://aka.ms/new-console-template for more information


// Class yapısı 
// önce class (iskelet) oluşturuyoruz
// sonrasında class'tan bir nesne alıyoruz

// Class içeriside iskeleti oluştururken;
// Property
// Fonksiyonlar


// Soru 1 : Kullanıcı bir maaş değeri girsin sonrasında maaş için bir yüzde oranı girsin Ardından 1 yada 2 diye bir değer girsin 1 girerse zam, 2 girerse 
// maaşta indirim.En son kişinin maaşını hesaplayınız. Bu soru için class yapısı oluşturunuz.

using Class2;
using System.Collections;

//ZamVeyaİndirim zamİndirim = new ZamVeyaİndirim();
//zamİndirim.Maas();

// Soru 2 : Kullanıcı bir maaş değeri girsin sonrasında maaş için bir yüzde oranı girsin Ardından 1 yada 2 diye bir değer girsin 1 girerse zam, 2 girerse 
// maaşta indirim.En son kişinin maaşını hesaplayınız. Kullnaıcı oranı 0 girene kadar bu işlem devam etsin. Bu soruyu class ve property tanımlamadan oluşturunuz.

//try
//{
//    Console.Write("Lütfen maaş değerini girin: ");
//    double maas = Convert.ToDouble(Console.ReadLine());
//    while (true)
//    {


//        Console.Write("Lütfen zam veya indirim oranını girin (%): ");
//        double oran = Convert.ToDouble(Console.ReadLine());

//        Console.WriteLine("Yapmak istediğiniz işlemi seçin (1 Zam - 2 indirim):");
//        int secim = Convert.ToInt32(Console.ReadLine());

//        if (oran == 0)
//            break;
//        else
//        {
//            MaastaZamİndirim zamİndirim = new MaastaZamİndirim();
//            Console.WriteLine(zamİndirim.MaasIslemi(maas, oran, secim));
//        }
//    }   
//}
//catch (Exception)
//{


//    Console.WriteLine("HATA");
//}

// Soru : Kullanıcının 0 girene kadar girdiği sayıları küçükten büyüğe sıralanmış halini , en büyüğü ve en küçük sayıları veren class yapısını oluşturunuz.


//SayiIslemleri sayiIslemleri = new SayiIslemleri();

//sayiIslemleri.SayilariIsle();

// doru 3 : 10 elamanlı iki ayrı listeye 1-100 arası rastgele sayılar eklenir bu iki listeden hangisinin bribirine üstün olduğunu bulunuz
// ( üstünlük ; 0. elemanlar karşılaştırılır kiminki büyükse 1 puan alır. Bu şekilde 10 eleman karşılaştırılır.) kim daha üstünse ekrana yazdır.


ListeleriKarsilastir sayi = new ListeleriKarsilastir();
ArrayList liste1 = new ArrayList();
ArrayList liste2 = new ArrayList();
sayi.İkiListe();




