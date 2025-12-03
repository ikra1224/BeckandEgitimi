using System;

namespace Project17_Abstraction.Models;

public class SqlServer : Database
{
    public override void Add()
    {
        Console.WriteLine("SQL Server ile kayıt ekleme işlemi tamamlandı.");
    }

    public override void Delete()
    {
        Console.WriteLine("SQL Server ile kayıt başarılı bir şekilde silindi.");
    }
}
