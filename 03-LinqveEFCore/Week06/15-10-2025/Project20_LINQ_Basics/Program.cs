namespace Project20_LINQ_Basics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = [3, 6, 12, 66, 44, 57, 89, 90, 23, 32];
        // LINQ - Method Syntax
        // var evenNumbers = numbers
        //     .Where(number => number % 2 == 0)
        //     .OrderByDescending(number => number);

        // string result = string.Join(" - ", evenNumbers);// "6 - 12 - 66 - 44"
        // Console.WriteLine($"Geleneksel Yöntemle Çift Sayılar: {result}");

        // 50'den büyük sayıları içinde tutan bir liste
        var result = numbers
            .Where(n =>
            {
                Console.WriteLine($"{n} kontrol ediliyor...");
                return n > 50;
            });

        numbers.Add(340);
        
        Console.WriteLine($"Geleneksel Yöntemle Çift Sayılar: {string.Join(" - ", result)}");
    }
}



/*
-- LINQ-Query Syntax
        var evenNumbers =   from number in numbers
                            where number % 2 == 0
                            orderby number descending
                            select number;
*/


/*
-- GELENEKSEL YÖNTEM
foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }

*/