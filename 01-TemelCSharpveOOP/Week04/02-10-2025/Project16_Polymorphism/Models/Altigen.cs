using System;

namespace Project16_Polymorphism.Models;

public class Altigen : Sekil
{
    public override void Ciz()
    {
        Console.WriteLine("************************");
        base.Ciz();
        Console.WriteLine("Bir altıgen çiziliyor...");
    }
}
