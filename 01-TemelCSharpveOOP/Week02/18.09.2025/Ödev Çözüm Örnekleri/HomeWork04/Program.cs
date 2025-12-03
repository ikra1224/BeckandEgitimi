namespace HomeWork04;
class Program
{
    static void Main()
    {
        double balance = 1000.0;
        
        while (true)
        {
            Console.WriteLine("\n=== ATM MENÜSÜ ===");
            Console.WriteLine("1 - Bakiye Görüntüle");
            Console.WriteLine("2 - Para Yatır");
            Console.WriteLine("3 - Para Çek");
            Console.WriteLine("4 - Çıkış");
            Console.Write("Seçiminizi girin (1-4): ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Mevcut Bakiyeniz: " + balance.ToString("0.00") + " TL");
                    break;
                    
                case "2":
                    Console.Write("Yatırmak istediğiniz miktarı girin: ");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    if (depositAmount > 0)
                    {
                        balance += depositAmount;
                        Console.WriteLine(depositAmount.ToString("0.00") + " TL yatırıldı. Yeni bakiye: " + balance.ToString("0.00") + " TL");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz miktar! Lütfen pozitif bir değer girin.");
                    }
                    break;
                    
                case "3":
                    Console.Write("Çekmek istediğiniz miktarı girin: ");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    if (withdrawAmount > 0 && withdrawAmount <= balance)
                    {
                        balance -= withdrawAmount;
                        Console.WriteLine(withdrawAmount.ToString("0.00") + " TL çekildi. Yeni bakiye: " + balance.ToString("0.00") + " TL");
                    }
                    else if (withdrawAmount > balance)
                    {
                        Console.WriteLine("Yetersiz bakiye! Mevcut bakiye: " + balance.ToString("0.00") + " TL");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz miktar! Lütfen pozitif bir değer girin.");
                    }
                    break;
                    
                case "4":
                    Console.WriteLine("Çıkış yapılıyor... İyi günler!");
                    return;
                    
                default:
                    Console.WriteLine("Geçersiz seçim! Lütfen 1-4 arasında bir sayı girin.");
                    break;
            }
        }
    }
}