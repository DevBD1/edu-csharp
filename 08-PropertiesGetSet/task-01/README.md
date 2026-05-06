Soru: Akıllı bir ofis yazıcısının kartuş durumunu yönetecek Yazici isimli bir sınıf tasarlamanız istenmektedir. Sınıfınızı aşağıdaki isterleri karşılayacak şekilde C# ile hazırlayınız.


İstenenler:

Değişkenler ve Kapsülleme: marka (string), maxMurekkep (int) ve guncelMurekkep (int) değişkenlerini private olarak tanımlayınız.

Kural: maxMurekkep değeri için bir Property (get/set) yazınız. Eğer dışarıdan 500'den küçük bir kapasite girilmek istenirse, kapasite otomatik olarak 500 kabul edilmelidir.


Kurucu Metot (Constructor): Dışarıdan marka ve maxMurekkep bilgilerini parametre olarak alıp atamalarını yapınız. Yazıcı ilk üretildiğinde guncelMurekkep değeri otomatik olarak 0 atanmalıdır.


Üye Metotlar:

kartusDoldur(int miktar): Gelen miktarı güncel mürekkebin üzerine ekler. Kural: Eğer ekleme sonucunda güncel mürekkep, maxMurekkep kapasitesini aşıyorsa; güncel mürekkebi maksimum kapasiteye eşitleyip ekrana "Kartuş tam doldu!" yazdırmalıdır.

belgeYazdir(int sayfa): Çıktı alınacak her 1 sayfa, 5 birim mürekkep harcamaktadır. Metot öncelikle gereken mürekkep miktarını hesaplamalıdır. Eğer güncel mürekkep bu işlem için yeterliyse mürekkepten düşüp "Belgeler yazdırıldı", yetersizse "Mürekkep yetersiz!" uyarısı vermelidir.

bilgiGoster(): Yazıcının markasını ve mürekkep durumunu (Güncel / Maksimum şeklinde) ekrana yazdırır.


Main Metodu (Örnek Kullanım): 1 adet yazıcı nesnesi üretip doldurma ve yazdırma metotlarını test ediniz.