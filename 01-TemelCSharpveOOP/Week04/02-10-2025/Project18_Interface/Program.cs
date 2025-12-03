namespace Project18_Interface;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}


// Polymorphism: Bir base class(miras veren) içerisindeki kimi metotların gövdesinin derived(miras alan) class'larda değiştirilmesine izin vermek isteyebilir. Bunu sağlayan yapı; ilgili metodu base class içinde "virtual" ile işaretledikten sonra, derived class içinde override etmektir. Bu bize aynı metodun, farklı derived classlarda farklı davranmasını sağlama imkanı verir.

// Abstraction: Bir base class içerisindeki kimi metotların gövdesini yazmayıp, derived classlarda yazılmasını isteyebilir. Bunun için base class içinde ilgili metodun sadece imzası yazılır. Ve abstract sözcüğü ile işaretlenir. Derived classta ise ilgili metot override edilmek ZORUNDADIR!

// Interface: Ne polymorphism'de olduğu gibi bazı metotlara override imkanı vermek ne de abstraction'daki olduğu gibi kimi metotların override edilmesini zorunlu kılmak istiyorum. Bunun yerine tüm metotların gövdesinin derived classlarda yazılmasını zorunlu kılmak istiyorum. 