using System;

namespace Project17_Abstraction.Models;

public class MySql : Database
{
    public override void Add()
    {
        Console.WriteLine("MySql ile kayıt ekleme işlemi tamamlandı.");
    }

    public override void Delete()
    {
        Console.WriteLine("MySql ile kayıt başarılı bir şekilde silindi.");
    }
}
