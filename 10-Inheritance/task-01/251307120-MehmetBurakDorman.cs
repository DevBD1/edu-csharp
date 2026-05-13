using System;

public class Personel
{
    public string Ad { get; set; }
    public double Maas { get; set; }

    public Personel(string ad, double maas)
    {
        Ad = ad;
        Maas = maas;
    }

    protected void Yazdir()
    {
        Console.WriteLine($"Personel Adi: {Ad}");
        Console.WriteLine($"Personel Maasi: {Maas}");
    }
}

public class Yazilimci : Personel
{
    public string ProgramlamaDili { get; set; }

    public Yazilimci(string ad, double maas, string programlamaDili) : base(ad, maas)
    {
        ProgramlamaDili = programlamaDili;
    }

    public new void Yazdir()
    {
        base.Yazdir();
        Console.WriteLine($"Programlama Dili: {ProgramlamaDili}");
    }
}

public class Program
{
    public static void Main()
    {
        Yazilimci yazilimci = new Yazilimci("Mehmet Burak Dorman", 110000, "C#");
        yazilimci.Yazdir();
    }
}
