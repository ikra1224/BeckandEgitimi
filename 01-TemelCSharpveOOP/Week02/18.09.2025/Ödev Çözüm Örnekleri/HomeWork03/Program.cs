/*
3. Zaman Makinesi - Saniye Dönüştürücü: Verilen toplam saniyeyi (örn: 54321) kullanarak, bu sürenin kaç saat, kaç dakika, kaç saniye ettiğini bulan bir program yazın. Bölme (/) ve mod alma (%) operatörlerini yaratıcı bir şekilde kullanmanız gerekecek!
*/

namespace HomeWork03;
class Program
{
    static void Main()
    {
        Console.Write("Saniye değerini giriniz: ");
        int totalSeconds = Convert.ToInt32(Console.ReadLine());
        
        int hours = totalSeconds / 3600;
        int remainingSeconds = totalSeconds % 3600;
        int minutes = remainingSeconds / 60;
        int seconds = remainingSeconds % 60;
        
        Console.WriteLine("Toplam Saniye: " + totalSeconds);
        Console.WriteLine("Süre: " + hours + " saat, " + minutes + " dakika, " + seconds + " saniye");
    }
}