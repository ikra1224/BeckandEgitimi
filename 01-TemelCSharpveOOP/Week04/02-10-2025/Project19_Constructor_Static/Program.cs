namespace Project19_Constructor_Static;

class Program
{
    static void Main(string[] args)
    {
        Islemci islemci1 = new Islemci();
        Islemci islemci2 = new Islemci();
        islemci1.Topla(5, 15);  // yis: 1 tyis: 1
        islemci1.Topla(5, 15);  // yis: 2 tyis: 2
        islemci2.Topla(1, 7);   // yis: 1 tyis: 3
        islemci2.Topla(1, 7);   // yis: 2 tyis: 4
        islemci2.Topla(1, 7);   // yis: 3 tyis: 5
        islemci1.Topla(5, 15);  // yis: 3 tyis: 6
        islemci2.Topla(1, 7);   // yis: 4 tyis: 7
        islemci1.Topla(5, 15);  // yis: 4 tyis: 8
        islemci2.Topla(1, 7);   // yis: 5 tyis: 9
        islemci2.Topla(1, 7);   // yis: 6 tyis: 10





        



        Console.WriteLine($"islemci1 Yapılan İşlem Sayısı: {islemci1.YapilanIslemSayisi}");
        Console.WriteLine($"islemci2 Yapılan İşlem Sayısı: {islemci2.YapilanIslemSayisi}");
        Console.WriteLine($"Toplam Yapılan İşlem Sayısı: {Islemci.ToplamYapilanIslemSayisi}");










        // Category category1 = new Category();

        // Console.WriteLine(category1.ProductCount);

        // Product product1 = new Product("IPhone13");
        // Console.WriteLine(product1.Name);

        // Product product2 = new Product();
        // Product product3 = new Product("Galaxy A57", "Harika telefon");
        // Product product4 = new Product("Kalem", "Süper kalem", 567);
    }
}
