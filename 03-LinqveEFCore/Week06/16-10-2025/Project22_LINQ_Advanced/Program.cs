namespace Project22_LINQ_Advanced;

class Program
{

    static void Main(string[] args)
    {

        var products = SeedData.Products;
        var orders = SeedData.Orders;
        var orderDetails = orders.Join(
            products,
            o => o.ProductId,
            p => p.Id,
            (o, p) => new
            {
                SiparisNo = o.Id,
                UrunAdi = p.Name,
                SiparisAdedi = o.Quantity,
                BirimFiyat = p.Price,
                ToplamFiyat = o.Quantity * p.Price
            }
        );
        foreach (var orderDetail in orderDetails)
        {
            Console.WriteLine($"{orderDetail.SiparisNo} - {orderDetail.UrunAdi} - {orderDetail.SiparisAdedi} - {orderDetail.BirimFiyat} - {orderDetail.ToplamFiyat}");
        }
        Console.WriteLine($"Sipariş Toplamı: {orderDetails.Sum(od => od.BirimFiyat * od.SiparisAdedi)}");
    }

    // static void Main(string[] args)
    // {

    //     var products = SeedData.Products;


    //     var id2Product = products
    //         .Where(p => p.Id == 2)
    //         // .First(); // Koşulu sağlayan ilk elemanı döndürür, bulamazsa hata fırlatır.
    //         //.FirstOrDefault(); // Koşulu sağlayan ilk elemanı döndürür, bulamazsa null döndürür.
    //         //.Single();// Koşulu sağlayan tek bir eleman olduğunu varsayar ve bunu döndürür, bulamazsa ya da birden fazla eleman döndürürse hata fırlatır.
    //         .SingleOrDefault();// Koşulu sağlayan tek bir eleman olduğunu varsayar ve bunu döndürür, bulamazsa ya da birden fazla eleman döndürürse null döndürür.
    //     Console.WriteLine($"Id'si 2 olan ürün: {id2Product?.Name}");
    // }


    // static void Main(string[] args)
    // {
    //     var products = SeedData.Products;
    //     var totalElectronicValue = products
    //         .Where(p => p.Category == "Elektronik")
    //         .Sum(p => p.Price);


    //     Console.WriteLine($"Elektronik kategorisindeki ürünlerin toplam değeri: {totalElectronicValue}");
    // }

    // static void Main(string[] args)
    // {
    //     var products = SeedData.Products;
    //     var totalElectronicValue = products
    //         .Where(p => p.Category == "Elektronik")
    //         .Sum(p => p.Price);


    //     Console.WriteLine($"Elektronik kategorisindeki ürünlerin toplam değeri: {totalElectronicValue}");
    // }


    // static void Main(string[] args)
    // {
    //     var products = SeedData.Products;
    //     var productsCountByCategory = products
    //         .GroupBy(p => p.Category)
    //         .Select(group => new
    //         {
    //             CategoryName = group.Key,
    //             ProductCount = group.Count()
    //         });


    //     Console.WriteLine("Kategoriye Göre Ürün Adetleri");
    //     foreach (var groupItem in productsCountByCategory)
    //     {
    //         Console.WriteLine($"{groupItem.CategoryName}    : {groupItem.ProductCount}");
    //     }
    // }



    // static void Main(string[] args)
    // {
    //     //Group By
    //     var products = SeedData.Products;
    //     var categoryGroups = products.GroupBy(p => p.Category);
    //     // elde edilen IEnumerable<IGrouping<>> collection'ının içindeki her bir eleman bir key(kategori adı), o key'e ait ürünlerin listesini içerir.

    //     Console.WriteLine("Kategoriye Göre Ürünler");
    //     foreach (var group in categoryGroups)
    //     {
    //         Console.WriteLine($"Kategori: {group.Key}");
    //         foreach (var p in group)
    //         {
    //             Console.WriteLine($"---------- {p.Name}");
    //         }
    //     }
    // }
}
