using System;
using System.Collections;

// 09 - Operator Overloading
// Vektor operator overloading
public class Vektor
{
    private readonly ArrayList elemanlar;
    private static readonly Random rnd = new Random();

    // kurucu metot
    public Vektor()
    {
        elemanlar = new ArrayList();
        for (int i = 0; i < 10; i++)
        {
            elemanlar.Add(rnd.Next(0, 21));
        }
    }

    private Vektor(bool bos)
    {
        elemanlar = new ArrayList();
    }

    private int DegerAt(int index)
    {
        return elemanlar[index] is int sayi ? sayi : 0;
    }

    public static Vektor operator +(Vektor a, Vektor b)
    {
        Vektor sonuc = new Vektor(true);
        for (int i = 0; i < 10; i++)
        {
            sonuc.elemanlar.Add(a.DegerAt(i) + b.DegerAt(i));
        }
        return sonuc;
    }

    public static Vektor operator *(Vektor a, Vektor b)
    {
        Vektor sonuc = new Vektor(true);
        for (int i = 0; i < 10; i++)
        {
            sonuc.elemanlar.Add(a.DegerAt(i) * b.DegerAt(i));
        }
        return sonuc;
    }

    public static bool operator ==(Vektor a, Vektor b)
    {
        if (ReferenceEquals(a, b)) return true;
        if (a is null || b is null) return false;

        int toplamA = 0;
        int toplamB = 0;

        for (int i = 0; i < 10; i++)
        {
            toplamA += a.DegerAt(i);
            toplamB += b.DegerAt(i);
        }

        return toplamA == toplamB;
    }

    public static bool operator !=(Vektor a, Vektor b)
    {
        return !(a == b);
    }

    public override bool Equals(object? obj)
    {
        if (obj is Vektor diger)
        {
            return this == diger;
        }
        return false;
    }

    public override int GetHashCode()
    {
        int toplam = 0;
        for (int i = 0; i < 10; i++)
        {
            toplam += DegerAt(i);
        }
        return toplam.GetHashCode();
    }

    public void yazdir()
    {
        Console.Write("vektor: ");
        for (int i = 0; i < elemanlar.Count; i++)
        {
            Console.Write(elemanlar[i] + " ");
        }
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        Vektor v1 = new Vektor();
        Vektor v2 = new Vektor();
        Vektor v3 = new Vektor();

        // Çarpma işlemini test etme
        v3 = v1 * v2;

        v1.yazdir();
        v2.yazdir();
        v3.yazdir();

        // Toplama ve karşılaştırmayı test etme
        Vektor v4 = v1 + v2;
        v4.yazdir();
        Console.WriteLine("v1 == v2: " + (v1 == v2));
    }
}
