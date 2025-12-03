namespace Project02_Variables;

class Program
{
    static void Main(string[] args)
    {
        // veri_tipi degisken_adi = degiskenin_ilk_degeri;
        // veri_tipi degisken_adi;
        // long number1 = 45; // 8 byte
        //                    // 1.000.000 * 8 byte = 8.000.000 byte = 8.000 kb = 8 mb
        // byte number2 = 56; // 1 byte
        //                    // 1.000.000 * 1 byte = 1.000.000 byte = 1.000 kb = 1 mb
        // byte a = 255; // Implicitly Converting
        // int b = 344;
        // long c = 54353534345435354;
        // double d = 456.56;
        // float e = 434.67F;
        // decimal f = 543.6M;

        // bool g = true;
        // Console.WriteLine(g);

        // char a = 'f';
        // string b = "abcd"; // ['a','b','c','d']
        // string name1 = "Engin";
        // char[] name2 = ['E', 'n', 'g', 'i', 'n'];
        // Console.WriteLine(name1);

        int stockAmount = 455; // camelCase
        decimal productPrice = 5999.99m;
        char energyClass = 'A';
        bool isCampaign = true;
        string productName = "Elektronik Davul";

        Console.WriteLine("Ürün Adı: " + productName);
        Console.WriteLine($"Stok Miktarı : {stockAmount}");
        Console.WriteLine($"Fiyat: {productPrice}");
        Console.WriteLine($"Enerji Sınıfı: {energyClass}");
        Console.WriteLine($"Kampanyalı Ürün mü?: {isCampaign}");

    }
}
