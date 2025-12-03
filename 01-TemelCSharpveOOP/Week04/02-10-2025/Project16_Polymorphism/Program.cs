using Project16_Polymorphism.Models;

namespace Project16_Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        Kare kare1 = new Kare();
        Kare kare2 = new Kare();
        Kare kare3 = new Kare();
        Kare kare4 = new Kare();
        Daire daire1 = new Daire();
        Daire daire2 = new Daire();
        Ucgen ucgen1 = new Ucgen();
        Ucgen ucgen2 = new Ucgen();
        Ucgen ucgen3 = new Ucgen();
        Altigen altigen1 = new Altigen();

        List<Sekil> sekiller = [kare1, kare2, kare3, kare4, daire1, daire2, ucgen1, ucgen2, ucgen3, altigen1];
        foreach (Sekil sekil in sekiller)
        {
            sekil.Ciz();
        }

    }
}


// Kare kare1 = new Kare();

// Daire daire1 = new Daire();

// Ucgen ucgen1 = new Ucgen();

// Altigen altigen1 = new Altigen();

// kare1.Ciz();
// daire1.Ciz();
// ucgen1.Ciz();
// altigen1.Ciz();