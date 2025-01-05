using System;

public class person
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public DateTime DogumTarihi { get; set; }

    public person(string ad, string soyad, DateTime dogumTarihi)
    {
        Ad = ad;
        Soyad = soyad;
        DogumTarihi = dogumTarihi;
    }
    public void BilgileriYazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Doğum Tarihi: {DogumTarihi.ToShortDateString()}");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        person ogrenci1 = new person("Gökay", "Özlemiş", new DateTime(2002, 02, 10));
        person ogrenci2 = new person("Anıl", "Barut", new DateTime(2002, 02, 19));

        person ogretmen1 = new person("Batuhan", "Şentürk", new DateTime(1980, 3, 15));
        person ogretmen2 = new person("Burak", "Bayar", new DateTime(1975, 11, 30));

        Console.WriteLine("Öğrenciler:");
        ogrenci1.BilgileriYazdir();
        ogrenci2.BilgileriYazdir();

        Console.WriteLine("\nÖğretmenler:");
        ogretmen1.BilgileriYazdir();
        ogretmen2.BilgileriYazdir();
    }
}
