task-1:
Soru: Nesne Yönelimli Programlamada kalıtım mantığını kavramak amacıyla aşağıdaki isterleri karşılayan C# programını yazınız.


1. Personel Sınıfı (Temel Sınıf - Base Class):


Ad (string) ve Maas (double) isimli özelliklere sahip olmalıdır. Özellikler için Get/Set bloklarını (Property) kullanınız.

Sınıfın kurucu metodu (constructor) dışarıdan ad ve maas parametrelerini alarak bu özelliklere atamalıdır.

Yazdir() isimli protected (korumalı) bir metot tanımlayınız. Bu metot sadece personelin adını ve maaşını (iki parametreyi) ekrana yazdırmalıdır.


2. Yazilimci Sınıfı (Türetilmiş Sınıf - Derived Class):


Personel sınıfından kalıtım yoluyla türetilmelidir.

Kendisine ait ekstra ProgramlamaDili (string) özelliğine (get/set) sahip olmalıdır.

Kurucu metodu dışarıdan ad, maas ve programlamaDili parametrelerini almalıdır. Kural: ad ve maas değerleri base anahtar kelimesi kullanılarak üst sınıfın (Personel) kurucu metoduna gönderilmelidir.

⚠️ Kritik Soru: Türetilmiş Yazilimci sınıfının nesnesini oluşturduğumuzda 3 bilgiyi de yazdırmamız gerekir. Ancak üst sınıfın Yazdir metodu sadece 2 bilgiyi yazdırıyor. O halde alt sınıfta nasıl bir yazdır metodu yazılmalıdır? Uygun yazdır metodunu hazırlayıp çalıştırınız.