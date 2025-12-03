namespace Project08_Debugging;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("Bir sayı gir: ");
        // int number = Convert.ToInt32(Console.ReadLine()); // "456"->456. "Ayşen"->Ayşen

        // int number = 0;
        // try
        // {
        //     // Normalde çalışması istenen ama Runtime hatası oluşma olasılığı olan, öngördüğümüz kodlar burada yer alır. Eğer burada bir kodda runtime esnasında bir hata oluşursa, program aşağıdaki catch bloğuna yönlendirilir!
        //     Console.Write("Bir sayı gir: ");
        //     number = Convert.ToInt32(Console.ReadLine());
        // }
        // catch (Exception)
        // {
        //     number = 18;
        // }
        // finally
        // {
        //     Console.WriteLine($"{number} adet ürün sipariş ettiniz! Teşekkür ederiz!");
        // }


        try
        {
            Console.Write("Bölünen: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bölen: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 / number2;
            Console.WriteLine($"{number1}/{number2}={result}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Sıfıra bölünme hatası!");
        }

        Console.Write("Uygulama sona erdi...");
        Console.ReadLine();
    }
}


// Buildtime(Derleme Zamanı): Uygulamanın kaynak koddan alınıp çalıştırıabilir hale dönüştürülme süreci
// Runtime(Çalışma Zamanı): Uygulamanın ayağa kalktığı, çalıştığı süreç

// dotnet run komutu verildiğinde, öncelikle dotnet build komutu çalıştırılır(arka planda) ve kodunuz derlenmiş olur, sonra da oluşan çalıştırılabilir uygulamanız(.exe, .unix) çalıştırılır.