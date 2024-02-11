// See https://aka.ms/new-console-template for more information
using System.Numerics;


// Soru1 :Kullanıcıdan aldığımız bir sayı sonrasında
// kullanıcın gireceği ikinci bir komutta
// eğer A girerse sayının 2 katını,
// eğer B girerse sayının 2 eksiği,
// eğer C girerse sayının 2 fazlası,
// eğer D girerse sayının yarısı,
// eğer E girerse sayının 2 katının 2 fazlası,
// eğer F girerse sayının 2 katının 2 eksiği,
// eğer G girerse sayının 2 katının 3 fazlasını kullanıcıya veren uygulama,

//Console.Write("Bir sayı girin: ");
//int sayi = Convert.ToInt32(Console.ReadLine());

//Console.Write("A, B, C, D, E, F ya da G girin: ");
//var sec = Convert.ToString(Console.ReadLine());

//if (sec == "A")                                             // if koşulu yazarken if koşulunun altında tek satır varsa {} olmadan yazılabilir.                                      
//    Console.WriteLine(sayi*2);
//else if (sec == "B")
//{
//    Console.WriteLine(sayi - 2);
//}
//else if (sec == "C")
//{
//    Console.WriteLine(sayi + 2);
//}
//else if (sec == "D")
//{
//    Console.WriteLine(sayi / 2);
//}
//else if (sec == "E")
//{
//    Console.WriteLine((sayi * 2) + 2);
//}
//else if (sec == "F")
//{
//    Console.WriteLine((sayi * 2) - 2);
//}
//else if (sec == "G")
//{
//    Console.WriteLine((sayi * 2) + 3);
//}
//else
//{
//    Console.WriteLine("Geçersiz seçim");
//}


// SWITCH - Case
// Bu ifade if else ifadesi gibi akış denetimini kontrol eden alternatif bir yapıdır.
// Burada amaç if ile yapılacak işlelerin karışık olduğu durumlarda daha sade ve anlaşılır yazılmasıdır.
// switch   : Bu kısıma koşul için gerekli olan değişken girilir. *********değişken ********* girilir
// case     : Durumları kontrol etmek için kullanılır ve karşılaşılacak durumlar girilir.
// break    : Bu komut akışı durdurmayı sağlar.
// default  : Case kısmında belirtilen durumlardan biri yok ise yapılacak işlemler buraya yazılır.

// if - else ile yapılan tüm sorular switch - case ile yapılamaz ama tam tersi mümkün.


//switch (sec)
//{
//    case "A":
//        Console.WriteLine(sayi * 2);
//        break;
//    case "B":
//        Console.WriteLine(sayi - 2);
//        break;
//    case "C":
//        Console.WriteLine(sayi + 2);
//        break;
//    case "D":
//        Console.WriteLine(sayi / 2);
//        break;
//    case "E":
//        Console.WriteLine((sayi * 2) + 2);
//        break;
//    case "F":
//        Console.WriteLine((sayi * 2) - 2);
//        break;
//    case "G":
//        Console.WriteLine((sayi * 2) + 3);
//        break;
//    default
//        : Console.WriteLine("Lütfen belirtilen komutlardan birini giriniz.");
//        break;
//}


// Soru2 : Kullanıcı tarafından girilen bir rakamın haftanın hangi gününe ait olduğunu switch- case ile yapınız
// not : 1 pazartesi


//Console.Write("Bir sayı giriniz : ");
//int sayi = Convert.ToInt32(Console.ReadLine());

//if (sayi >= 8)
//{
//    sayi = sayi % 7;
//}
//switch (sayi)
//{
//    case 1:
//        Console.WriteLine("Pazartesi");
//        break;
//    case 2:
//        Console.WriteLine("Salı");
//        break;
//    case 3:
//        Console.WriteLine("Çarşamba");
//        break;
//    case 4:
//        Console.WriteLine("Perşembe");
//        break;
//    case 5:
//        Console.WriteLine("Cuma");
//        break;
//    case 6:
//        Console.WriteLine("Cumartesi");
//        break;
//    case 7:
//        Console.WriteLine("Pazar");
//        break;
//    default:
//        Console.WriteLine("Lütfen rakam giriniz.");
//        break;
//}

// Soru3 : Kullanıcı tarafından girilen 2 sayı ile ilgili işlemi TOP, ÇAR, ÇIK, BOL komutlarını kullarak hesaplayan uygulamayı switch case ile oluşturabilir misin ?

//Console.Write("Birinci sayıyı giriniz : ");
//double sayi1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("İkinci sayıyı giriniz : ");
//double sayi2 = Convert.ToDouble(Console.ReadLine());

//Console.Write("İşlemi seçin (TOP, ÇAR, ÇIK, BOL): ");
//string islem = Console.ReadLine();

//switch (islem)
//{
//    case "TOP":
//        Console.WriteLine("Sonuç: " + (sayi1 + sayi2));
//        return;
//    case "ÇAR":
//        Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
//        break;
//    case "ÇIK":
//        Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
//        break;
//    case "BOL":
//    case "BÖL":
//        if (sayi2 == 0)
//        {
//            Console.WriteLine("Hatalı işlem");
//        }
//        else
//        {
//            Console.WriteLine("Sonuç: " + (sayi1 / sayi2));
//        }
//        break;
//    default:
//        Console.WriteLine("Geçersiz işlem. Lütfen komutlardan birini giriniz.");
//        break;
//}


// Soru4 :  Kullanıcının girmiş oldüğü ayın hangi mevsime ait olduğunu bulunuz.

//Console.Write("Bir ay giriniz : ");
//var ay = Console.ReadLine();

//switch (ay)
//{
//	case "Aralık":
//	case "Ocak":
//	case "Şubat":
//        Console.WriteLine("Bu ay kış ayıdır.");
//		break;
//    case "mart":
//    case "Nisan":
//    case "Mayıs":
//        Console.WriteLine("Bu ay ilkbahar ayıdır.");
//        break;
//    case "Haziran":
//    case "temmuz":
//    case "ağustos":
//        Console.WriteLine("Bu ay yaz ayıdır.");
//        break;
//    case "eylül":
//    case "ekim":
//    case "kasım":
//        Console.WriteLine("Bu ay sonbahar ayıdır.");
//        break;
//    default:
//        Console.WriteLine("Geçersiz işlem. Lütfen komutlardan birini giriniz.");
//        break;
//}


// Soru5 : Kullanıcı tarafından girilen 1-5 sayı aralığında her bir sayı için ekrana kullanıcının girdiği metni yazan uygulamayı switch case kullanarak yapınız.


Console.Write("1-5 arasında bir sayı girin: ");
int sayi = Convert.ToInt32(Console.ReadLine());

Console.Write("Bir metin girin: ");
string metin = Console.ReadLine();

switch (sayi)
{
    case 1:
        Console.WriteLine(metin);
        break;
    case 2:
        for (int i = 0; i < sayi; i++)
        {
            Console.WriteLine(metin);
        }
        break;
    case 3:
        for (int i = 0; i < sayi; i++)
        {
            Console.WriteLine(metin);
        }
        break;
    case 4:
        for (int i = 0; i < sayi; i++)
        {
            Console.WriteLine(metin);
        }
        break;
    case 5:
        for (int i = 0; i < sayi; i++)
        {
            Console.WriteLine(metin);
        }
        break;
    default:
        Console.WriteLine("geçersiz girdi");
        break;

}    


