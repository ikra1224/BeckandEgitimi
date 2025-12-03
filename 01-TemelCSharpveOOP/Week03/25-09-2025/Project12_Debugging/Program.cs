namespace Project12_Debugging;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("Bir sayı giriniz: ");
        // int number = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine(number * 2);
        // Console.Write("Çıkmak için enter tuşuna basınız...");
        // Console.ReadLine();

        try
        {
            Console.Write("Bölünen: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bölen  : ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{number1}/{number2} = {number1 / number2}");
            Console.Write("Çıkmak için enter tuşuna basınız...");
            Console.ReadLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"HATA => Orjinal Mesaj: {ex.Message}");
            Console.WriteLine($"HATA => Geçersiz bir değer girildi!");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("0'a bölme hatası!");
        }
        
        
        

    }
}


// try
// {
//     // Hata verme ihtimali olan kodlarımızı buraya yazıyoruz. Eğer hata yoksa çalışıyor, hata varsa catch bloğuna yönlendiriyor. Not: catch bloğuna giderken o sırada gerçekleşen hatayı da gönderiyor/FIRLATIYOR
// }
// catch (Exception)
// {
//     // try bloğunda herhangi bir hata meydana gelirse, buradaki kodlar çalışır.
//     throw;
// }



