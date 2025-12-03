using System;

namespace Project26_EFCore_Relationship_Data.Entities;

public class Author
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public List<Post> Posts { get; set; } = [];

}
