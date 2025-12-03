namespace Project15_Inheritance.Models;

public class Developer : Employe
{
    public string Lang { get; set; } = "C#";
    public void WriteCode()
    {
        Console.WriteLine($"{FirstName} {LastName} {Lang} dili ile kod yazmaya başladı...");
    }
}
