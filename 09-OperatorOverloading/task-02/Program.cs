using System;

#pragma warning disable CS0169

public class SepetTutari
{
    private decimal tutar;

    public SepetTutari(decimal tutar)
    {
        // TODO
    }

    public static SepetTutari operator +(SepetTutari a, SepetTutari b)
    {
        // TODO
        return new SepetTutari(0);
    }

    public static SepetTutari operator -(SepetTutari a, SepetTutari b)
    {
        // TODO
        return new SepetTutari(0);
    }

    public static bool operator >(SepetTutari a, SepetTutari b)
    {
        // TODO
        return false;
    }

    public static bool operator <(SepetTutari a, SepetTutari b)
    {
        // TODO
        return false;
    }

    public void yazdir()
    {
        // TODO
    }
}

public class Program
{
    public static void Main()
    {
        // TODO: Iki SepetTutari nesnesi olustur
        // TODO: Toplama operatorunu kullan
        // TODO: Cikarma operatorunu kullan
        // TODO: Karsilastirma operatorlerini kullan
        // TODO: Sonuclari yazdir
    }
}

#pragma warning restore CS0169
