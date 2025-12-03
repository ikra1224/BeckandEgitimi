namespace Project09_Arrays;

class Program
{
    static void Main(string[] args)
    {
        // Dizi: aynı tipteki elemanları içeren sabit boyutlu bir koleksiyon.
        // string[] days = new string[7];
        // days[0] = "Pazartesi";
        // days[1] = "Salı";
        // days[2] = "Çarşamba";
        // days[3] = "Perşembe";
        // days[4] = "Cuma";
        // days[5] = "Cumartesi";
        // days[6] = "Pazar";

        // Console.WriteLine(days[0]);
        // Console.WriteLine(days[1]);
        // Console.WriteLine(days[2]);

        // for (int i = 0; i < 7; i++)
        // {
        //     Console.WriteLine(days[i]);
        // }
        // foreach (string day in days)
        // {
        //     Console.WriteLine(day);
        // }

        // int[] points = { 45, 67, 98, 48, 86 };
        int[] points = [45, 67, 98, 48, 86,76,65,22,34,75,86,43,21,21,54,76,78];  // 0,1,2,3,4
        // int[] numbers = [7]; // Bu tanımlamayı içerisine eleman yazmadan, sadece eleman sayısını söyleyerek yapabilir miyiz? Nasıl?
        points[4] = 56;
        // Console.WriteLine(points[455]);  // Hata verir: IndexOutOfRange
        // int itemsCount = points.Length;
        // Console.WriteLine("Eleman Sayısı: " + itemsCount);
        for (int i = 0; i < points.Length; i++)
        {
            Console.WriteLine($"{i+1}.Not: {points[i] * 2}");
        }

    }
}
