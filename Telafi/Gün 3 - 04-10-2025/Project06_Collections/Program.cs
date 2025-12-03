namespace Project06_Collections;

class Program
{
    static void Main(string[] args)
    {
        // int[] numbers = new int[6];
        // numbers[0] = 50;
        // numbers[1] = 50;
        // int total = 0;
        // int[] numbers = [5, 30, 50, 50, 30, 23];
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     total += numbers[i];
        // }
        // Console.WriteLine(total);
        // Console.WriteLine(total/numbers.Length);


        // string[] students = ["Ali", "Veli", "Kuzey", "Güney"];

        // foreach (string studentName in students)
        // {
        //     Console.WriteLine(studentName);
        // }


        // for (int i = 0; i < students.Length; i++)
        // {
        //     if (students[i] == "Kuzey")
        //     {
        //         students[i] = "Merve";
        //     }
        // }

        // foreach (string studentName in students)
        // {
        //     Console.WriteLine(studentName);
        // }

        // List<int> numbers = new List<int>();
        // numbers.Add(56);
        // numbers.Add(516);
        // numbers.Add(536);
        // numbers.Add(5456);
        // Console.WriteLine(numbers.Count);
        // Console.WriteLine(numbers[0]);


        // List<int> numbers = [56, 53, 32, 32, 21];
        // foreach (int number in numbers)
        // {
        //     Console.WriteLine(number * 2);
        // }

        List<string> haftaninGunleri = ["Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar"];
        List<double> haftalikHarcamalar = [400, 300, 280, 490, 300, 450, 600];
        double toplamHarcamaTutari = 0;
        for (int i = 0; i < haftaninGunleri.Count; i++)
        {
            Console.WriteLine($"{haftaninGunleri[i]} günü: {haftalikHarcamalar[i]} TL");
            toplamHarcamaTutari += haftalikHarcamalar[i];
        }
        Console.WriteLine($"Haftalık Toplam Harcama Tutarı: {toplamHarcamaTutari} TL");
        double ortalama = toplamHarcamaTutari / haftaninGunleri.Count;
        Console.WriteLine($"Ortalama Günlük Harcama Tutarı: {ortalama.ToString("N2")} TL");

        Console.WriteLine("Liste Metotları İle");
        Console.WriteLine($"Toplam: {haftalikHarcamalar.Sum()} TL");
        Console.WriteLine($"Ortalama: {haftalikHarcamalar.Average().ToString("N2")} TL");
    }
}
