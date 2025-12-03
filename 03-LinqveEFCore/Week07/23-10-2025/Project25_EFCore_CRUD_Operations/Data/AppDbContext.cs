using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project24_EFCore_Basics.Models;

namespace Project24_EFCore_Basics.Data;

public class AppDbContext:DbContext
{
    public DbSet<Post> Posts { get; set; }
    public DbSet<Author> Authors { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder
        //     .UseSqlite("Data Source=blog.db")
        //     .LogTo(Console.WriteLine, LogLevel.Information)
        //     .EnableSensitiveDataLogging();
        optionsBuilder.UseSqlite("Data Source=blog.db");
    }
}
