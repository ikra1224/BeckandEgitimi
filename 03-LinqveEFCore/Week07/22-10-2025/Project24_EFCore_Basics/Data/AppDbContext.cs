using Microsoft.EntityFrameworkCore;
using Project24_EFCore_Basics.Models;

namespace Project24_EFCore_Basics.Data;

public class AppDbContext:DbContext
{
    public DbSet<Post> Posts { get; set; }
    public DbSet<Author> Authors { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=blog.db");// Eğer bu veri tabanı yoksa yaratır varsa kullanır.
    }
}
