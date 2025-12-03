using System;

namespace Project24_EFCore_Basics.Models;

public class Author
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    
    // Bu tür property'lere Navigation Property diyoruz.
    public List<Post> Posts { get; set; } = [];
}
