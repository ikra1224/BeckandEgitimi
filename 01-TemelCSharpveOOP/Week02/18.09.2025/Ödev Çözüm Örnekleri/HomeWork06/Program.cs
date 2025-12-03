namespace HomeWork06;
using System;

class Program
{
    static void Main()
    {
        // 5 kişilik anket puanlarını diziye al
        int[] satisfactionScores = new int[5];
        
        Console.WriteLine("=== MİNİ ANKET ANALİZİ ===");
        Console.WriteLine("Lütfen 5 kişinin memnuniyet puanlarını girin (1-10 arası):");
        
        // For döngüsü ile kullanıcıdan puanları al
        for (int i = 0; i < satisfactionScores.Length; i++)
        {
            Console.Write((i + 1) + ". kişinin puanı: ");
            satisfactionScores[i] = Convert.ToInt32(Console.ReadLine());
            
            // Puanın geçerli aralıkta olduğunu kontrol et
            while (satisfactionScores[i] < 1 || satisfactionScores[i] > 10)
            {
                Console.Write("Geçersiz puan! Lütfen 1-10 arası bir değer girin: ");
                satisfactionScores[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        // Değişkenleri tanımla
        int total = 0;
        int highest = satisfactionScores[0];
        int lowest = satisfactionScores[0];
        
        // For döngüsü ile analiz yap
        for (int i = 0; i < satisfactionScores.Length; i++)
        {
            total += satisfactionScores[i];
            
            // En yüksek puanı bul
            if (satisfactionScores[i] > highest)
            {
                highest = satisfactionScores[i];
            }
            
            // En düşük puanı bul
            if (satisfactionScores[i] < lowest)
            {
                lowest = satisfactionScores[i];
            }
        }
        
        double average = (double)total / satisfactionScores.Length;
        
        // Sonuçları yazdır
        Console.WriteLine("\n=== ANKET SONUÇLARI ===");
        Console.WriteLine("Girilen Puanlar:");
        
        for (int i = 0; i < satisfactionScores.Length; i++)
        {
            Console.WriteLine((i + 1) + ". kişi: " + satisfactionScores[i] + " puan");
        }
        
        Console.WriteLine("\n=== İSTATİSTİKLER ===");
        Console.WriteLine("Toplam Puan: " + total);
        Console.WriteLine("Ortalama Puan: " + average.ToString("0.00"));
        Console.WriteLine("En Yüksek Puan: " + highest);
        Console.WriteLine("En Düşük Puan: " + lowest);
        
        // Ekstra: Memnuniyet durumu
        Console.WriteLine("\n=== MEMNUNİYET DURUMU ===");
        if (average >= 8)
        {
            Console.WriteLine("Genel Memnuniyet: Çok Yüksek 👍");
        }
        else if (average >= 6)
        {
            Console.WriteLine("Genel Memnuniyet: Orta 👌");
        }
        else if (average >= 4)
        {
            Console.WriteLine("Genel Memnuniyet: Düşük 👎");
        }
        else
        {
            Console.WriteLine("Genel Memnuniyet: Çok Düşük ❌");
        }
    }
}