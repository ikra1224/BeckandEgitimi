using System.Drawing;

namespace Project05_Loops;

class Program
{
    static void Main(string[] args)
    {
        // for (int i = 1; i < 5; i++)
        // {
        //     Console.WriteLine($"{i}-Merhaba döngüler!");
        // }

        // for (int i = 1; i <= 10; i++)
        // {
        //     if (i % 2 == 0) Console.WriteLine(i);
        // }

        // for (int i = 2; i <= 10; i += 2)
        // {
        //     Console.WriteLine(i);
        // }

        // int total = 0;
        // int number;
        // for (int i = 1; i <= 3; i++)
        // {
        //     Console.Write($"{i}. Sayı: ");
        //     number = Convert.ToInt32(Console.ReadLine());
        //     total += number;
        // }
        // Console.WriteLine($"Toplam: {total}");



        // int total = 0;
        // int number = -1;
        // int counter = 1;

        // while (number != 0)
        // {
        //     Console.Write($"{counter}. Sayı(Çıkış için 0): ");
        //     number = Convert.ToInt32(Console.ReadLine());
        //     total += number;
        //     counter++;
        // }
        // Console.WriteLine($"Toplam: {total}");




        int total = 0;
        int number = 0;
        int counter = 1;

        do
        {
            Console.Write($"{counter}. Sayı(Çıkış için 0): ");
            number = Convert.ToInt32(Console.ReadLine()); // number:0, counter:1
            total += number; // total: 0
            counter++; // counter:2
        } while (number != 0);

        if (counter > 2)
        {
            Console.WriteLine($"Toplam: {total}");
        }


        Console.WriteLine("Uygulama sona erdi, çıkış için ENTER");
        Console.ReadLine();


    }
}



//     int total = 0;
// int number;
//     for (int i = 1; i >= 1; i++)
//     {
//         Console.Write($"{i}. Sayı:(Çıkış için 0) ");
//         number = Convert.ToInt32(Console.ReadLine());
//         total += number;
//         if (number == 0) break;
//     }
//     Console.WriteLine($"Toplam: {total}");