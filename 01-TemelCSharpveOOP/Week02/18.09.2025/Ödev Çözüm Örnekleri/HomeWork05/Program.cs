namespace HomeWork05;
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        int guessCount = 0;
        int userGuess;
        
        Console.WriteLine("=== SAYI TAHMİN OYUNU ===");
        Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Tahmin et!");
        
        while (true)
        {
            Console.Write("Tahmininiz: ");
            userGuess = Convert.ToInt32(Console.ReadLine());
            guessCount++;
            
            if (userGuess < secretNumber)
            {
                Console.WriteLine("Daha büyük bir sayı deneyin!");
            }
            else if (userGuess > secretNumber)
            {
                Console.WriteLine("Daha küçük bir sayı deneyin!");
            }
            else
            {
                Console.WriteLine("Tebrikler! " + guessCount + " denemede doğru tahmin ettiniz!");
                break;
            }
        }
    }
}