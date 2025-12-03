namespace Project03_Operators;

class Program
{
    static void Main(string[] args)
    {
        // int a = 50;
        // int b = 20;
        // Console.WriteLine(a + b);
        // Console.WriteLine(a - b);
        // Console.WriteLine(a * b);
        // Console.WriteLine(a / b);
        // Console.WriteLine(a % b);

        // Console.WriteLine($"a: {a++}");
        // int result = 10;
        // result += a; // result = result + a;
        // Console.WriteLine($"a: {a}");
        // Console.WriteLine($"result: {result}");
        // Console.WriteLine($"a: {a--}");
        // Console.WriteLine($"a: {a}");
        // result -= a; // result = result - a;
        // Console.WriteLine($"result: {result}");
        // Console.WriteLine($"a: {++a}");
        // Console.WriteLine($"a: {--a}");

        // int a = 50;
        // int b = 20;
        // Console.WriteLine($"Toplam: {a + a++ - b + 10 * b - --a + ++a - b}");
        // Console.WriteLine($"a'nın son değeri: {a}, b'nin son değeri: {b}");
        // /*
        //     100(a=51, b=20)
        //     80(a=51, b=20) --------- 200
        //     280(a=51, b=20)
        //     230(a=50, b=20)
        //     281(a=51, b=20)
        //     261(a=51, b=20)
        // */

        // int a = 50;
        // int b = 20;
        // Console.WriteLine($"Toplam: {a + a++ - b++ + 10 * b - --a + ++a - b}");
        // Console.WriteLine($"a'nın son değeri: {a}, b'nin son değeri: {b}");
        // /*
        //     100(a=51, b=20)
        //     80(a=51, b=21) --------- 210
        //     290(a=51, b=21)
        //     240(a=50, b=21)
        //     291(a=51, b=21)
        //     270(a=51, b=20)
        // */


        // int a = 50;
        // int b = 20;
        // int total = 0;
        // Console.WriteLine("1.İşlem");
        // total += a + a++;
        // Console.WriteLine($"Toplam: {total}");
        // Console.WriteLine($"a'nın son değeri: {a}, b'nin son değeri: {b}");
        // Console.WriteLine("*********************************");

        // Console.WriteLine("2.İşlem");
        // total -= b++;
        // Console.WriteLine($"Toplam: {total}");
        // Console.WriteLine($"a'nın son değeri: {a}, b'nin son değeri: {b}");
        // Console.WriteLine("*********************************");

        // Console.WriteLine("3.İşlem");
        // total += 10 * b;
        // Console.WriteLine($"Toplam: {total}");
        // Console.WriteLine($"a'nın son değeri: {a}, b'nin son değeri: {b}");
        // Console.WriteLine("*********************************");


        // Console.WriteLine("4.İşlem");
        // total -= --a;
        // Console.WriteLine($"Toplam: {total}");
        // Console.WriteLine($"a'nın son değeri: {a}, b'nin son değeri: {b}");
        // Console.WriteLine("*********************************");

        // Console.WriteLine("5.İşlem");
        // total += ++a;
        // Console.WriteLine($"Toplam: {total}");
        // Console.WriteLine($"a'nın son değeri: {a}, b'nin son değeri: {b}");
        // Console.WriteLine("*********************************");

        // Console.WriteLine("6.İşlem");
        // total -= b;
        // Console.WriteLine($"Toplam: {total}");
        // Console.WriteLine($"a'nın son değeri: {a}, b'nin son değeri: {b}");
        // Console.WriteLine("*********************************");

        // a + a++ - b++ + 10 * b - --a + ++a - b


        // // oyuncu seviyesi 50'den büyük eşit ve süresi 1000'den büyük eşit olanlar elit olacaklar.
        // int playerLevel = 5;
        // int playDuration = 1200;

        // // >, <, >=, <=, !=
        // bool isElite = playerLevel >= 50 && playDuration>=1000; 
        // Console.WriteLine($"Elit mi?: {isElite}");



        // oyuncu seviyesi 50'den büyük eşit ya da süresi 1000'den büyük eşit olanlar elit olacaklar.
        int playerLevel = 5;
        int playDuration = 200;

        bool isElite = playerLevel >= 50 || playDuration >= 1000;
        Console.WriteLine($"Elit mi?: {isElite}");
    }
}
