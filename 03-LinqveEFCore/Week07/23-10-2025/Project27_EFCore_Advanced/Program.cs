using Microsoft.EntityFrameworkCore;
using Project26_EFCore_Relationship_Data.Dtos;

namespace Project26_EFCore_Relationship_Data;

class Program
{
    static void Main(string[] args)
    {
        #region Seed Data İşlemleri
        // Console.WriteLine("Örnek veriler yüklenmeye başladı...");
        // var seedData = new SeedData();
        // seedData.CreateAuthors();
        // Console.WriteLine("Yazarlar oluşturuldu...");
        // seedData.CreatePosts();
        // Console.WriteLine("Postlar oluşturuldu...");
        // Console.WriteLine("Seed Data işlemleri tamamlandı...");
        #endregion
        #region Projection Yöntemi ile Sadece Gerekli Veriyi Çekmek
        // Postların Id'leri ve başlıkları ile yazar bilgilerini içeren bir liste oluşturalım.
        // var context = new BlogDbContext();
        // var posts = context
        //     .Posts
        //     .Include(p => p.Author)
        //     .Select(p=>new PostDto
        //     {
        //         PostId = p.Id,
        //         PostTitle = p.Title,
        //         AuthorName=$"{p.Author!.FirstName} {p.Author.LastName}"
        //     })
        //     .ToList();
        // foreach (var post in posts)
        // {
        //     Console.WriteLine($"{post.PostId} - {post.PostTitle} - {post.AuthorName}");
        // }
        #endregion
        #region Salt Okunur Sorgular(Performans için)
        var context = new BlogDbContext();
        var posts = context
            .Posts
            .AsNoTracking()//EF Core buradaki okunan verileri izlemeyecek, Change Tracker devre dışı bırakıldı
            .Where(p => p.AuthorId == 1)
            .ToList();
        Console.WriteLine($"SaveChanges öncesi: {posts[0].Title}");
        posts[0].Title = "Değişen başlık...";

        context.SaveChanges();// AsNoTracking ile çekilen post üzerinde hiçbir etkisi olmaz!
        Console.WriteLine($"SaveChanges sonrası: {posts[0].Title}");
        Console.WriteLine("AsNoTracking ile çekilen postlar üzerinde değişiklik yapılamaz!!!");


        // Eğer bir sorgunun sonunda SaveChanges çağırmayacaksanız, çağırma ihtimaliniz yoksa zincire AsNoTracking ekleyin.
        #endregion
    }
}

// select Id, Title from Posts
