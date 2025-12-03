using System;
using Microsoft.EntityFrameworkCore;
using Project26_EFCore_Relationship_Data.Entities;

namespace Project26_EFCore_Relationship_Data;

public class BlogDbContext:DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Post> Posts { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=blogapp.db");
    }
}
