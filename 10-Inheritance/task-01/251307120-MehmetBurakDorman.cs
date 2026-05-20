using System;

public class Bina
{
    private static int binaSayaci = 0;

    public string turu { get; set; }
    public int daire_sayisi { get; set; }
    public double daire_boyutu { get; set; }
    public double m2fiyat { get; set; }
    public double toplamfiyat { get; set; }
    public string aciklama { get; private set; }

    public Bina(string turu, int daire_sayisi, double daire_boyutu, double m2fiyat)
    {
        binaSayaci++;
        aciklama = $"{binaSayaci}. bina";

        this.turu = turu;
        this.daire_sayisi = daire_sayisi;
        this.daire_boyutu = daire_boyutu;
        this.m2fiyat = m2fiyat;

        Console.WriteLine("ben bina kurucusuyum");
    }

    public void hesap()
    {
        toplamfiyat = daire_sayisi * daire_boyutu * m2fiyat;
    }

    public virtual void yaz()
    {
        Console.WriteLine($"Açıklama: {aciklama}");
        Console.WriteLine($"Türü: {turu}");
        Console.WriteLine($"Daire Sayısı: {daire_sayisi}");
        Console.WriteLine($"Daire Boyutu: {daire_boyutu} m2");
        Console.WriteLine($"Metrekare Fiyatı: {m2fiyat}");
        Console.WriteLine($"Toplam Fiyat: {toplamfiyat}");
    }
}

public class betonBina : Bina
{
    public string binaTuru { get; set; }

    public betonBina(string turu, int daire_sayisi, double daire_boyutu, double m2fiyat, string binaTuru)
        : base(turu, daire_sayisi, daire_boyutu, m2fiyat)
    {
        this.binaTuru = binaTuru;
        Console.WriteLine("beton binayım");
    }

    public override void yaz()
    {
        Console.WriteLine($"Açıklama: {aciklama}");
        Console.WriteLine($"Türü: {turu}");
        Console.WriteLine($"Bina Türü: {binaTuru}");
        Console.WriteLine($"Daire Sayısı: {daire_sayisi}");
        Console.WriteLine($"Daire Boyutu: {daire_boyutu} m2");
        Console.WriteLine($"Metrekare Fiyatı: {m2fiyat}");
        Console.WriteLine($"Toplam Fiyat: {toplamfiyat}");
    }
}

public class Program
{
    public static void Main()
    {
        betonBina bina1 = new betonBina("Konut", 10, 123, 33000, "Betonarme");
        bina1.hesap();
        bina1.yaz();

        Console.WriteLine();

        betonBina bina2 = new betonBina("İşyeri", 6, 82, 38000, "Prefabrik");
        bina2.hesap();
        bina2.yaz();
    }
}
