using System;
using System.Collections;

public class Kisi
{
    public string Name;
    public string Surname;
    public int Age;

    public Kisi(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }
}

class Program
{
    static ArrayList kisiler = new ArrayList();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Yeni kişi eklemek için bilgileri girin (Çıkmak için 'q' tuşuna basın):");
            Console.Write("İsim: ");
            string name = Console.ReadLine();

            // Kullanıcı çıkış isteği mi yaptı kontrol et
            if (name.ToLower() == "q")
                break;

            Console.Write("Soyisim: ");
            string surname = Console.ReadLine();
            Console.Write("Yaş: ");
            int age = Convert.ToInt32(Console.ReadLine());

            kisiler.Add(new Kisi(name, surname, age));
        }

        // Eklenen kişileri ekrana yazdır
        Console.WriteLine("\nGirilen Kişiler:");
        foreach (Kisi kisi in kisiler)
        {
            Console.WriteLine($"İsim: {kisi.Name}, Soyisim: {kisi.Surname}, Yaş: {kisi.Age}");
        }

        while (true)
        {
            Console.WriteLine("Secenekler:");
            Console.WriteLine("1. Kisi Ekle");
            Console.WriteLine("2. Kisi Cikar");
            Console.WriteLine("3. Listeyi Goruntule");
            Console.WriteLine("4. Cikis");
            Console.Write("Seciminizi yapin: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    KisiEkle();
                    break;
                case "2":
                    KisiCikar();
                    break;
                case "3":
                    ListeyiGoruntule();
                    break;
                case "4":
                    Console.WriteLine("Programdan cikiliyor...");
                    return;
                default:
                    Console.WriteLine("Gecersiz secim! Lutfen tekrar deneyin.");
                    break;
            }
        }
    }

    static void KisiEkle()
    {
        Console.WriteLine("Yeni kisi eklemek icin bilgileri girin:");
        Console.Write("Isim: ");
        string name = Console.ReadLine();
        Console.Write("Soyisim: ");
        string surname = Console.ReadLine();
        Console.Write("Yas: ");
        int age;
        while (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Gecersiz yas! Lutfen bir sayi girin.");
            Console.Write("Yas: ");
        }

        kisiler.Add(new Kisi(name, surname, age));
        Console.WriteLine("Kisi basariyla eklendi.");
    }

    static void KisiCikar()
    {
        Console.WriteLine("Cikarmak istediginiz kisinin adini girin:");
        string nameToRemove = Console.ReadLine();

        Kisi kisiToRemove = null;
        foreach (Kisi kisi in kisiler)
        {
            if (kisi.Name.Equals(nameToRemove, StringComparison.OrdinalIgnoreCase))
            {
                kisiToRemove = kisi;
                break;
            }
        }

        if (kisiToRemove == null)
        {
            Console.WriteLine("Belirtilen isimde bir kisi bulunamadi.");
            return;
        }

        kisiler.Remove(kisiToRemove);
        Console.WriteLine($"{nameToRemove} isimli kisi basariyla cikarildi.");
    }

    static void ListeyiGoruntule()
    {
        Console.WriteLine("\nGirilen Kisiler:");
        for (int i = 0; i < kisiler.Count; i++)
        {
            Kisi kisi = (Kisi)kisiler[i];
            Console.WriteLine($"Index: {i}, Isim: {kisi.Name}, Soyisim: {kisi.Surname}, Yas: {kisi.Age}");
        }
    }
}
