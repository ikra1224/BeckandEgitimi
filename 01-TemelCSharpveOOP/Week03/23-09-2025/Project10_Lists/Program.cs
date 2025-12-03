namespace Project10_Lists;

class Program
{
    static void Main(string[] args)
    {
        // List<int> numbers = new List<int>();
        List<int> numbers = [];
        numbers.Add(56); // index:0
        numbers.Add(78); // index:1
        numbers.Add(99);
        numbers.Add(949);
        numbers.Add(298);
        numbers.Add(763);
        // for (int i = 0; i < numbers.Count; i++)
        // {
        //     Console.WriteLine(numbers[i]);
        // }
        // numbers listesindeki sadece çift sayı olanları ekrana yazdıralım.
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
                Console.WriteLine($"{number}====> {number}/2= {number / 2}");
    
        }
    }
}
