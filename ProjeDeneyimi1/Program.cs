using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace ProjeDeneyimi1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //// Değişkenler

            //// VErileri temsil etmesi için kullanılan yapılardır.
            //// Veriinin yapısına göre farklı çeşitleri bulunmaktadır.
            //// Değişkenler isimlendirilirken büyük küçük harfe duyarlı olduğu unutulmamalıdır.
            //// elma <> Elma  : aynısı değildir.
            //// Değişken isimlendirilirken boşluk ve türkçe karakter kullanılmaz.

            //// string           : Metin türündeki verileri saklar. ( "mustafa")
            //// int(integer)     ; tamsayıları saklar. (3)
            //// float            : virgüllü (ondalıklı rasyonel) sayıları saklar . ( 0,5)
            //// bool ( boolean)  : true false değerini saklar ( doğru yanlış / ever hayır)

            //string degisken1 = "Mustafa KÖSEM";
            //degisken1 = "Mustafa KÖSEM 2";
            //degisken1 = "Mustafa";

            //double degisken2 = 3.14;
            //int degisken3 = 28;

            //Console.WriteLine(degisken3);
            //Console.WriteLine(degisken2);
            //Console.WriteLine(degisken1);


            //string meyveler = "maymun";
            //string sebzeler = "doğanlar";
            //string sokak = "armut";
            //string sehir = "Yazılım";
            //string ders = "izmir";

            //int yasim = 1071;
            //int mezuniyetTarihim = 28;
            //int deneysel = 100;
            //int rastegeleSayı = 3;
            //int tukendim = 7;

            //Console.WriteLine(meyveler);
            //Console.WriteLine(sebzeler);
            //Console.WriteLine(sokak);
            //Console.WriteLine(sehir);
            //Console.WriteLine(ders);

            //Console.WriteLine(yasim);
            //Console.WriteLine(mezuniyetTarihim);
            //Console.WriteLine(deneysel);
            //Console.WriteLine(rastegeleSayı);
            //Console.WriteLine(tukendim);

            ////OPERATÖRLER
            //// Matematiksel Operatörler

            //int sayi1 = 20;
            //int sayi2 = 40;
            //int toplam = yasim + mezuniyetTarihim + deneysel + rastegeleSayı + tukendim;
            //Console.WriteLine("5'li değişkenimizde toplam sonucumuz :" +  toplam);

            //int fark = sayi2 - sayi1;
            //Console.WriteLine("çıkartma işlemi sonucu   :" +fark);
            //int carpim = sayi2 * sayi1;
            //Console.WriteLine("çarpma işlemi sonucu     :"+carpim);

            //Console.WriteLine("bölme işlemi sonucu      :" +sayi2/ sayi1);

            //// Bir öğrenci bilgi sitemi hazırlıyoruz. Bu projede olabilecek değişkenleri tanımlayınız. 
            ////Not: En az 40 adet değişken atnımlama ve değerini verme.

            //string adsoyad = "Mustafa Kösem";
            //int yas; // Değişken tanımlama yapıldı.
            //int arabaSayisi;
            //yas = 20; // Değişkene değer verildi.
            //yas = 30; // değişkene yeni değer verdim.( bir önceki değer güncellendi.)

            //string ahmetinHalasi = "B";
            //string ahmetinhalasi = "B";  //iki değişken aynı değildir büük küçük harfe duyarlı
            //// Notasyon : düzen

            //Console.WriteLine();
            //string ad = "Ali";
            //string kaldigiDers = "Felsefe";
            //string sevdigiDers = "Beden";
            //string soyad = "VELİ";
            //string enSevdigiArk = "Deniz";
            //string enSevmedigiArk = "Hüseyin";
            //string nedenBitmez = "Neden Bitsin ki?";
            //string sorularaCevapVermelisin = "yoo";
            //string hangiHastaliklariGecirdi = "şeker,klap ne ararsan";
            //string denemeSayisi = "35";
            //int BiyolojiNotu = 5;
            //int yasi = 25;
            //int arkadasSayisi = 3;
            //int favoriDersNotu = 50;
            //int sevmedigiDersNotu = 50;
            //int kacıncıSinif = 3;
            //int okulNo = 1596;
            //int gecerNotKac = 50;
            //int felsefeNotu = 50;
            //bool okulBiterMi = false;
            //bool arabasiVarMi = false;
            //bool sevdigi = true;
            //bool eviVarMi= false;
            //bool arkadasiVarMi = true;
            //bool dubleTostseverMi = true;
            //bool hastalikGecmisiVarmi = true;
            //double fizikNotu = 15.5;
            //double kacParasiVar = 35465.57;  // virgüllü sayıları tutar
            //double krediNotu = 2.5;
            //double bankayaBorcu = 3.3;
            //double donemKrediNotu = 3.3;
            //char sevdigininBasharfi = 'D';  // tek bir karakter alır cahr ve tek karakter ile tanımlanır
            //char ilkAski = 'E';



            //int toplamasi = BiyolojiNotu + felsefeNotu;                  
            //double toplamasi1 = fizikNotu + kacParasiVar;
            //string toplamasi2 = ad + " " + soyad; //Matematiksel toplama değildir. string birleştirmedir.



            //Console.WriteLine();
            //Console.WriteLine("İşlem sonuçları :");
            //Console.WriteLine("biyoloji ve felesefe not toplamı :" + toplamasi);
            //Console.WriteLine(toplamasi1);
            //Console.WriteLine(toplamasi2);
            //Console.WriteLine();


            //                            // Verilerde Dönüşüm

            //                            // Tüm veri türleri string veri türüne dönüştürülebilir.
            //                            // Değiştirilecek veri türü uygun değilse hata alınır. ( program çalışma aşamasında)

            //int sayi3 = 20;
            //string sayi3Yazi = Convert.ToString(sayi3);// sayi3Yazi


            //                            // double veri türünü string veri türüne dönüştürme
            //double pi = 3.14;
            //string piYazi = Convert.ToString(pi);  // pi = "3.14"  


            //                            // integer vei türünü double veri türüne dönüştürme
            //int sayi4 = 20;
            //double sayi5 = Convert.ToDouble(sayi4);

            //                            //deneme 
            //                            //string deneme = "Mustafa";
            //                            //int deneme2 = Convert.ToInt32(deneme); // burada program hata alır.

            //string deneme3 = "456";
            //int deneme4 = Convert.ToInt32(deneme3); // burada program çalışır


            //                //int > string
            //                // double > string 
            //                // bool > string 
            //                //char > string

            //                // tüm verileri dönüştürüp sonrasına aralarına bir boşluk  koyarak birleştirip yazdırıyoruz.

            //string arkadasSayisi1 = Convert.ToString(arkadasSayisi);
            //string fizikNotu1 = Convert.ToString(fizikNotu);
            //string okulBiterMi1 = Convert.ToString(okulBiterMi);
            //string ilkAski1 = Convert.ToString(ilkAski);
            //string strdonusumtoplama = arkadasSayisi1 + " " + fizikNotu1+ " " + okulBiterMi1+ " "+ ilkAski1;
            //Console.WriteLine(strdonusumtoplama);
            //string yasi1 = Convert.ToString(yasi);
            //string krediNotu1 = Convert.ToString (krediNotu);
            //string arabasiVarMi1 = Convert.ToString(arabasiVarMi);
            //string sevdigininBasharfi1 = Convert.ToString(sevdigininBasharfi);
            //string strdsmtplama = "yaş :"+yasi1 + " Kredi notu:" + krediNotu1 + " Arabası var mı:" + arabasiVarMi1 + " üzdü :" + sevdigininBasharfi1;
            //Console.WriteLine(strdsmtplama);

            //int denemeSayisi1 = Convert.ToInt32 (denemeSayisi);
            //int sevdigi1 = Convert.ToInt32(sevdigi);
            //int bankayaBorcu1 = Convert.ToInt32(bankayaBorcu);
            //int sevdigininBasharfi2 = Convert.ToInt32(sevdigininBasharfi);
            //int inttoplama = denemeSayisi1 + sevdigi1 + bankayaBorcu1 + sevdigininBasharfi2;
            //Console.WriteLine(inttoplama);
            //Console.WriteLine();

            //                        // Kullanıcıdan Bilgi/ Veri alma

            //                        // Kullanıcıdan aldığımız bilgi string veri türündedir.


            //                        // kullanıd-cıdan yaşını iste doğum yılını versin.

            //Console.Write("lütfen yaşınızı giriniz: ");
            //string yas1 = Console.ReadLine();
            //int yashesabı = 2024 - Convert.ToInt32(yas1);
            //Console.WriteLine( "Doğum yılınız: " + yashesabı);


            //// ALGORİTMA : Bir soru yada sorun için çözüm basamaklarının yazı yada şekil ile anlatıldığı işlem basamakları.

            //// kullanıcı tarafından girien iki sayının toplamını sonuç olarak ekrana ayzınız.

            //Console.WriteLine("lütfen iki adet sayı giriniz:");
            //string sayi6= Console.ReadLine();
            //string sayi7 = Console.ReadLine();
            //double toplami = Convert.ToDouble(sayi6)+ Convert.ToDouble(sayi7);
            //Console.WriteLine( "Girdiğiniz sayıların toplam sonucu :" +toplami);

            //// kullaıcı trafından girilen 3 sayının toplamının 2 katı 

            //Console.WriteLine("lütfen üç adet sayı giriniz:");
            //double sayi1 = Convert.ToDouble (Console.ReadLine());
            //string sayi2 = Console.ReadLine();
            //string sayi3 = Console.ReadLine();
            //Console.WriteLine(( sayi1 + Convert.ToDouble(sayi2) + Convert.ToDouble(sayi3))*2);

            // Koşullu ifadeler ( if - else - else if )

            // if eğer anlammına gelir. Burada kooşul yazılır .kosşul doğru olura içi çalışır.

            //if (true)         //if ile koşul belirtilir. Parantez içine koşul yazılır.
            //{ 
            //eğer koşul doğru olurs süslü parantez içindeki kodlar çalışır.           
            //}

            // koşul yazılırken eşittir demek için == kullanılır.

            //int sayi1 = 20;
            //if (sayi1 == 10) 
            //{
            //    Console.WriteLine( "Koşul 1 oldu ");
            //}

            //if (sayi1 == 20)
            //{
            //    Console.WriteLine("Koşul 2 oldu ");
            //}

            //// 5 adet kullanıcıdan syı alınız ve her birini bir sayıya eşit mi diye kontrol ediniz.

            //double sayi1 = Convert.ToDouble(Console.ReadLine());
            //double sayi2 = Convert.ToDouble(Console.ReadLine());
            //double sayi3 = Convert.ToDouble(Console.ReadLine());
            //double sayi4 = Convert.ToDouble(Console.ReadLine());
            //double sayi5 = Convert.ToDouble(Console.ReadLine());


            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("ilk iki sayı girdiğniz sayıdan daha büyük oldu");
            //}

            //if (sayi1 == sayi3) 
            //{
            //    Console.WriteLine("ilk girdiğniz sayı ile üçüncü sayı eşit.");
            //}

            //if(sayi1 < sayi4) { Console.WriteLine("ilk sayı dördüncü girdiğniz sayıdan daha büyük oldu"); }
            //if (sayi5==5){ Console.WriteLine("beşinci girilen sayı 5'e eşittir"); }

            // else if / else yöntemi

            //int sayi1 = 10;
            //if (sayi1 == 5) 
            //{
            //    Console.WriteLine( "if kısmında sonuç bulundu.");
            //}else if (sayi1 == 7)
            //{
            //    Console.WriteLine("else if kısmında sonuç bulundu");
            //}else 
            //{ 
            //    Console.WriteLine("else kısmında sonuç bulundu"); 
            //}

            //not : if yapısı yazılırken, if zorunludur else if/ else terche bağlıdır.

            // KARŞILASTIRMA OPERATÖRLERİ
            //  ==  : eşit mi 
            //  !=  : eşit değil


            //// soru : Kullanıcıdan aldığınız iki sayıyı karşılaştıtıp sonucları ekrana yaz
            //double sayi1 = Convert.ToDouble(Console.ReadLine());
            //double sayi2 = Convert.ToDouble(Console.ReadLine());
            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("Sayı 1, Sayı 2 den büyük.");
            //}
            //else if (sayi1 == sayi2)
            //{
            //    Console.WriteLine("Sayı 1, Sayı 2ye eşit");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 1, Sayı 2 den küçük");
            //}

            ////kullanıcı taradından girilen  3sayıdan en büyüğü ekrana yazır
            //Console.Write("lütfen birinci sayıyı giriniz:");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("lütfen ikinci sayıyı giriniz:");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("lütfen üçüncü sayıyı giriniz:");
            //double sayi3 = Convert.ToDouble(Console.ReadLine());

            //double enBuyuk = sayi1;
            //if ( sayi2 > enBuyuk) 
            //{
            //    enBuyuk = sayi2;
            //}if (sayi3> enBuyuk) 
            //{
            //    enBuyuk = sayi3;
            //}
            //Console.WriteLine("Girdiğiniz sayılar içinde en büyük olan :" + Convert.ToDouble(enBuyuk));

            //kullanıcıdan aldığımız 3 sayının toplamını 20 ile karşılaştırınız.
            Console.Write("lütfen birinci sayıyı giriniz:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("lütfen ikinci sayıyı giriniz:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("lütfen üçüncü sayıyı giriniz:");
            double sayi3 = Convert.ToDouble(Console.ReadLine());

            double toplam = sayi1+ sayi2 + sayi3;

            if (toplam > 20) 
            {
                Console.WriteLine("Girdiğiniz 3 sayının toplamı 20'den büyük");
            }
            else if (toplam< 20 ) 
            {
                Console.WriteLine("Girdiğiniz 3 sayının toplamı 20'den küçük");
             }
            else
            {
                Console.WriteLine("Girdiğiniz 3 sayının toplamı 20'ye eşit ");
            }



        }
    }
}
