using System;

// 06 - Copy Constructors Overloading

public class SekilAlan
{
    private double[] veri;
    private String tip = string.Empty;
    private double alan;
    private double hacim;
    private double cevre;
    private double yuzeyAlani;
    public SekilAlan(params double[] degerler)
    {
        veri = degerler.Length > 0 ? degerler : new double[] {0};
        if (degerler.Length == 0) {
            tip = "bos";
        } else if (degerler.Length == 1)
        {
            tip = "daire";
        } else if (degerler.Length == 2)
        {
            tip = "dortgen";
        } else if (degerler.Length > 2)
        {
            tip = "tanimsiz";
        }
    }
    public void alanHesapla()
    {
        if (tip == "bos" || tip == "tanimsiz")
        {
            alan = 0;
        } else if (tip == "daire")
        {
            double r = veri[0];
            alan = 2 * (Math.PI * (r * r));
        } else if (tip == "dortgen")
        {
            alan = 2 * (veri[0]+veri[1]);
        }
    }
    public void hacimHesapla()
    {
        if (tip == "bos" || tip == "tanimsiz")
        {
            hacim = 0;
        }
        else if (tip == "kup")
        {
            hacim = veri[0] * veri[0] * veri[0];
        }
        else if (tip == "silindir")
        {
            hacim = Math.PI * veri[0] * veri[0] * veri[1];
        }
    }
    public void cevreHesapla()
    {
        if (tip == "bos" || tip == "tanimsiz")
        {
            cevre = 0;
        }
        else if (tip == "daire")
        {
            cevre = 2 * Math.PI * veri[0];
        }
        else if (tip == "dortgen")
        {
            cevre = 2 * (veri[0] + veri[1]);
        }
        else if (tip == "kup")
        {
            cevre = 12 * veri[0];
        }
        else if (tip == "silindir")
        {
            cevre = 2 * Math.PI * veri[0];
        }
    }
    public void yuzeyAlaniHesapla()
    {
        if (tip == "bos" || tip == "tanimsiz")
        {
            yuzeyAlani = 0;
        }
        else if (tip == "kup")
        {
            yuzeyAlani = 6 * veri[0] * veri[0];
        }
        else if (tip == "silindir")
        {
            yuzeyAlani = 2 * Math.PI * veri[0] * (veri[0] + veri[1]);
        }
    }
    public void yazdir()
    {
        Console.WriteLine("Tip: " + tip);
        Console.WriteLine("Veri: " + string.Join(", ", veri));
        Console.WriteLine("Alan: " + alan);
        Console.WriteLine("Hacim: " + hacim);
        Console.WriteLine("Cevre: " + cevre);
        Console.WriteLine("Yuzey Alani: " + yuzeyAlani);
    }
    public static void Main()
    {
        SekilAlan s1 = new SekilAlan(2.5);
        s1.alanHesapla();
        s1.hacimHesapla();
        s1.cevreHesapla();
        s1.yuzeyAlaniHesapla();
        s1.yazdir();
    }
}
