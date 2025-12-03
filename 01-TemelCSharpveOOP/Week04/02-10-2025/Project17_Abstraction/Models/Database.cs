using System;

namespace Project17_Abstraction.Models;

public abstract class Database
{
    public void Connect()
    {
        Console.WriteLine("Veri tabanı bağlantısı başarıyla sağlandı!");
    }

    public abstract void Add();
    public abstract void Delete();
}
