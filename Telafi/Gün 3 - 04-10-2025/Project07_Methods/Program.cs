namespace Project07_Methods;

class Program
{
    static void Main(string[] args)
    {
        // Greet();
        // WelcomeGreet();
        // GoodByeGreet();
        // LoginErrorGreet();
        // ShowMessage("Güle Güle");//Argüman
        // Sum(10, 20);
        // Sum(10, 20, 30);
        // Message("Engin", "Matematik Öğretmenliği");
        // Message("Ceyda", "Bilgisayar Mühendisliği", 22);
        // // Message("Ayşen", 25);  // Bu çalışmaz
        // Message(age: 25, name: "Ayşen");
        // int result = Sum(10, 20);
        // result = Sum(10, 50, 60);
        // result = Sum(10, 50, 60, 60);
        Console.WriteLine(GetMessage("Büşra"));  //1
        Console.WriteLine(GetMessage("Büşra", 24)); //2
        Console.WriteLine(GetMessage("Büşra", weight: 52)); //3
        Console.WriteLine(GetMessage("Büşra", 24, 52)); //4
        
    }

    //4
    static string GetMessage(string name, byte age, double weight)
    {
        string text = $"Merhaba {name}, {age} yaşındasın ve {weight} kilosun!";
        return text;
    }

    //3
    static string GetMessage(string name, double weight)
    {
        string text = $"Merhaba {name}, {weight} kilosun!";
        return text;
    }

    //2
    static string GetMessage(string name, byte age)
    {
        string text = $"Merhaba {name}, {age} yaşındasın!";
        return text;
    }

    // 1
    static string GetMessage(string name)
    {
        string text = $"Merhaba {name}";
        return text;
    }



    static int Sum(int n1, int n2, int n3, int n4)
    {
        int total = n1 + n2 + n3 + n4;
        return total;
    }

    static int Sum(int n1, int n2, int n3)
    {
        int total = n1 + n2 + n3;
        return total;
    }

    static double Sum(double n1, double n2)
    {
        double total = n1 + n2;
        return total;
    }

    static int Sum(int n1, int n2)
    {
        int total = n1 + n2;
        return total;
    }

    // static void Message(string name, string department = "Yazılım Mühendisliği", int age = 18)
    // {
    //     Console.WriteLine($"Merhaba {name}, sen {age} yaşındasın ve {department} bölümündesin!");
    // }

    // static void Sum(int n1, int n2, int n3 = 0, int n4 = 0)
    // {
    //     int result = n1 + n2 + n3 + n4;
    //     Console.WriteLine(result);
    // }


    // static void Sum(int n1, int n2)
    // {
    //     int result = n1 + n2;
    //     Console.WriteLine(result);
    // }

    static void ShowMessage(string message) // Parametre
    {

        Console.WriteLine("*********************************");
        Console.WriteLine($"** {message} **");
        Console.WriteLine("*********************************");
        Console.WriteLine();
    }

    static void LoginErrorGreet()
    {
        Console.WriteLine("*********************************");
        Console.WriteLine("** KULLANICI ADI/PAROLA HATALI **");
        Console.WriteLine("*********************************");
        Console.WriteLine();
    }

    static void GoodByeGreet()
    {
        Console.WriteLine("*********************************");
        Console.WriteLine("*********** GÜLE GÜLE ***********");
        Console.WriteLine("*********************************");
        Console.WriteLine();
    }

    static void WelcomeGreet()
    {
        Console.WriteLine("*********************************");
        Console.WriteLine("********* HOŞ GELDİNİZ **********");
        Console.WriteLine("*********************************");
        Console.WriteLine();
    }

    static void Greet()
    {
        Console.WriteLine("Merhaba C# Metotlar Dünyası!");
    }
}

