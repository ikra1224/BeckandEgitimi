using System;

namespace Project19_Constructor_Static;

public class Category
{
    public Category()
    {

    }
    public Category(int productCount)//Constructor(İnşa edici) Metot
    {
        Name = string.Empty;
        Description = string.Empty;
        ProductCount = productCount;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int ProductCount { get; set; }
}

/*
    Her class varsayılan olarak boş bir constructor metot içerir. Bu implicit(örtülü,gizli) haldedir. Eğer biz bu metodun içine bir şeyler yazmak istersek ya da gerekli olursa! bu metodu kendimiz elimize yazmalıyız.
    Ancak, bir class'ın içinde herhangi bir parametre alan constructor yazıldıysa, artı o gizli boş(parametresiz) constructor yok olmuş demektir. Eğer yine de bir boş constructor'a ihtiyaç varsa, bu kez elle o boş constructor yazılmalıdır.
*/
