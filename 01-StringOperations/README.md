# Bölüm 1: String İşlemleri (String Operations)

## 🎯 Task 1: Slack Mention Bulucu (Slack Mention Parser)

**Zorluk Derecesi:** Kolay (Easy)  
**Product Scenario:** Slack mesajlaşma altyapısını geliştiriyorsun. Bir mesaj metninde `@` işareti ile başlayan ilk kullanıcı adını bulup ayıklayan bir metot yazman isteniyor.  

### 📝 Problem Tanımı
Sana parametre olarak bir mesaj (string `message`) verilecek.
Bu mesaj içindeki **ilk** kullanıcı etiketini (mention) bulan bir fonksiyon yaz.
Kullanıcı etiketi her zaman `@` ile başlar ve bir boşluk karakteri (space) ile biter. Eğer mesajın en sonunda yer alıyorsa boşlukla bitmek zorunda değildir.

**Kurallar:**
1. Metin içinde birden fazla mention varsa sadece **ilkini** döndür (başındaki `@` işareti olmadan).
2. Eğer metin içinde hiç mention yoksa boş string (`""`) döndür.
3. String metotlarını (`IndexOf`, `Substring`, `Split` vb.) kullanman beklenmektedir.

### 💡 Örnekler:

**Örnek 1:**
```csharp
Input: message = "Merhaba @ahmet bugün nasılsın?"
Output: "ahmet"
```

**Örnek 2:**
```csharp
Input: message = "Toplantı notlarını @zeynep_celik paylaştı."
Output: "zeynep_celik"
```

**Örnek 3:**
```csharp
Input: message = "Kimse etiketlenmedi."
Output: ""
```

---

### 💻 Kod Şablonu

Çözümünü aşağıdaki sınıfın içine yazabilirsin. Kendi `Program.cs` veya test ortamında bu metodu çağırarak deneyebilirsin. 

```csharp
public class SlackParser 
{
    public string FindFirstMention(string message) 
    {
        // Kodunu buraya yaz...
        return "";
    }
}
```

> **LeetCode Öğretmeni Notu:** Kodunu yazarken Big-O (Zaman karmaşıklığı) açısından düşünmeye çalış. Metnin tamamını iki-üç defa dönmek yerine tek bir `IndexOf` ve `Substring` ile bu işi çözebilir miyiz? Başarılar! 🚀 Hazır olduğunda çözümünü benimle paylaş!
