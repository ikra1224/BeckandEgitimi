/*
2. Kargo Ücreti Hesaplayıcı: Bir ürünün desisi, ağırlığı ve uzaklık koduna göre kargo ücreti hesaplayan bir program yazın. Formül: ucret = 15.0 + (desi * 0.5) + (agirlik * 1.2) + (uzaklikKodu * 2.0).
*/
namespace HomeWork02;
class Program
{
    static void Main()
    {
        Console.WriteLine("=== KARGO ÜCRETİ HESAPLAMA ===");
        
        // Kullanıcıdan değerleri al
        Console.Write("Lütfen desi değerini girin: ");
        double volume = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Lütfen ağırlığı kg cinsinden girin: ");
        double weight = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Lütfen uzaklık kodunu girin (1-10 arası): ");
        int distanceCode = Convert.ToInt32(Console.ReadLine());
        
        // Kargo ücreti hesaplama
        double shippingCost = 15.0 + (volume * 0.5) + (weight * 1.2) + (distanceCode * 2.0);
        
        // Sonuçları yazdır
        Console.WriteLine("\n=== HESAPLAMA SONUÇLARI ===");
        Console.WriteLine("Girilen Desi: " + volume);
        Console.WriteLine("Girilen Ağırlık: " + weight + " kg");
        Console.WriteLine("Girilen Uzaklık Kodu: " + distanceCode);
        Console.WriteLine("Toplam Kargo Ücreti: " + shippingCost.ToString("0.00") + " TL");
        
        // Ekstra bilgi
        Console.WriteLine("\nNot: Ücret = 15.0 TL sabit + (Desi × 0.5) + (Ağırlık × 1.2) + (Uzaklık Kodu × 2.0)");
    }
}