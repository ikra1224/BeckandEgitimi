using System;

namespace Project26_EFCore_Relationship_Data.Entities;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime PublishedOn { get; set; } = DateTime.UtcNow;
    public int AuthorId { get; set; }
    public Author? Author { get; set; }

}
