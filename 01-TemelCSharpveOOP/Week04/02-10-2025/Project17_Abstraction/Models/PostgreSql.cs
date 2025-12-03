using System;

namespace Project17_Abstraction.Models;

public class PostgreSql : Database
{
    public override void Add()
    {
        Console.WriteLine("Postgre ile kayıt ekleme işlemi tamamlandı.");
    }

    public override void Delete()
    {
        Console.WriteLine("Postgre ile kayıt başarılı bir şekilde silindi.");
    }
}
