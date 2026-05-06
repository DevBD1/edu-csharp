using System;

public class Yazici
{
    private string marka = string.Empty;
    private int maxMurekkep;
    private int guncelMurekkep;
    public int MaxMurekkep
        {
            get { return maxMurekkep; }
            set 
            { 
                if (value < 500)
                    maxMurekkep = 500;
                else
                    maxMurekkep = value;
            }
        }
    public Yazici(string marka, int maxMurekkep)
    {
        this.marka = marka;
        MaxMurekkep = maxMurekkep;
        this.guncelMurekkep = 0;
    }
    public void kartusDoldur(int miktar)
    {
        if (miktar + guncelMurekkep > maxMurekkep)
        {
            guncelMurekkep = maxMurekkep;
            Console.WriteLine("Kartuş tam doldu!");
        }
        else
        {
            guncelMurekkep += miktar;
        }
    }
    public void belgeYazdir(int sayfa)
    {
        int gerekenMurekkep = sayfa * 5;

        if (guncelMurekkep >= gerekenMurekkep)
        {
            guncelMurekkep -= gerekenMurekkep;
            Console.WriteLine("Belgeler yazdırıldı.");
        }
        else
        {
            Console.WriteLine("Mürekkep yetersiz!");
        }
    }
    public void bilgiGoster()
        {
            Console.WriteLine($"Marka: {marka}\nMürekkep Durumu: {guncelMurekkep} / {maxMurekkep}");
        }
    public static void Main()
    {
            Yazici benimYazicim = new Yazici("Epson Zartzurt", 400);
            
            benimYazicim.bilgiGoster();

            Console.WriteLine("600 birim kartuş ekleniyor.");
            benimYazicim.kartusDoldur(600); 
            benimYazicim.bilgiGoster();

            Console.WriteLine("20 sayfa yazdırılıyor.");
            benimYazicim.belgeYazdir(20);
            benimYazicim.bilgiGoster();

            Console.WriteLine("100 sayfa yazdırılmaya çalışılıyor.");
            benimYazicim.belgeYazdir(100);
    }
}
