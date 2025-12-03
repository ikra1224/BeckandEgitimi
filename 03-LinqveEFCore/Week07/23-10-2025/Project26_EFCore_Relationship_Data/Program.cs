using Microsoft.EntityFrameworkCore;

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

        // EF Core'da ilişkili verileri yüklemenin temel olarak üç yolu vardır
        // Id'si 3 olan Author'un verilerini Post'larıyla birlikte çekmek
        #region Eager Loading
        // Ana nesneyi sorgularken, ilişkili verilerin de tek bir sorguda getirilmesini sağlar. En yaygın, verimli yöntemdir.
        // Include, ThenInclude
        var context = new BlogDbContext();
        var authors = context
            .Authors
            .Include(a => a.Posts)
            .ToList();
        // Eğer authors collection'ının eleman sayısı 1 ya da daha fazla ise true, 0 ise false döndürür.
        if (authors.Any())
        {
            foreach (var author in authors)
            {
                Console.WriteLine($"{author.FirstName} {author.LastName}");
                
                if (author.Posts.Any())
                {
                    foreach (var post in author.Posts)
                    {
                        Console.WriteLine($"    - {post.Title}");
                    }
                }
            }
        }

        #endregion
    
        #region Lazy Loading
        // İlişkili olan verilere, onlara ilk kez erişilmeye çalışıldığı anda ayrı bir sorgu ile otomatik olarak yüklenmesine denir. 
        // Bu N+1 problemine yol açabilir. Meraklısı araştırsın :)
        #endregion

        #region Explicit Loading
        // Ana nesneyi yükledikten sonra, istenilen herhangi bir zamanda ilişkili verilerin ayrı bir sorgu ile manuel olarak yüklenmesine denir.
        #endregion
    }
}
