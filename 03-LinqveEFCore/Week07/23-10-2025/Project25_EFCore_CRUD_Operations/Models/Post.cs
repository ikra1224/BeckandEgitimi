using Microsoft.EntityFrameworkCore;

namespace Project24_EFCore_Basics.Models;

public class Post
{
    public int Id { get; set; } // Id, id, ID default PK / PostId, POSTID => default PK
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime PublishedOn { get; set; }

    public int AuthorId { get; set; } // İçinde bulunduğumuz class hariç olmak üzere, herhangi bir entity class'ımızn adı+Id şeklinde gördüğü propertyler=> ForeignKey

    // Navigation Property
    public Author? Author { get; set; }
}
