// DTO: Data Transfer Object
namespace Project26_EFCore_Relationship_Data.Dtos;

public class PostDto
{
    public int PostId { get; set; }
    public string PostTitle { get; set; } = string.Empty;
    public string AuthorName { get; set; } = string.Empty;
}
