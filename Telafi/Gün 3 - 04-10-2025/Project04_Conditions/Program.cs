namespace Project04_Conditions;

class Program
{
    static void Main(string[] args)
    {
        // string role = "NormalUser";
        // if (role == "NormalUser")
        // {
        //     Console.WriteLine("Lütfen daha sonra yeniden deneyiniz!");
        // }

        // string role = "AdminUser";
        // if (role == "NormalUser")
        // {
        //     Console.WriteLine("Lütfen daha sonra yeniden deneyiniz!");
        // }
        // else
        // {
        //     Console.WriteLine("Hoş geldiniz!");
        // }

        // string role = "sadfdasf";
        // if (role == "NormalUser")
        // {
        //     Console.WriteLine("Lütfen daha sonra yeniden deneyiniz!");
        // }
        // else if (role == "AdminUser")
        // {
        //     Console.WriteLine("Hoş geldiniz!");
        // }
        // else
        // {
        //     Console.WriteLine("Rol bilgisi geçersiz bir değer içeriyor.");
        // }

        // int level = 5;
        // string location = "İstanbul";
        // bool isElit = true;

        // if (level >= 15)
        // {
        //     Console.WriteLine("PS5 kazandınız!");
        // }
        // else if (location == "Datça")
        // {
        //     Console.WriteLine("1 haftalık tatil kazandınız!");
        // }
        // else if (isElit == true)
        // {
        //     Console.WriteLine("IPhone 17 kazandınız!");
        // }
        // else
        // {
        //     Console.WriteLine("Bir dahaki sefere şansınızı yeniden deneyiniz!");
        // }

        // Console.WriteLine("ANA MENÜ");
        // Console.WriteLine("********");
        // Console.WriteLine();
        // Console.WriteLine("Ürün Listesi--------- (1)");
        // Console.WriteLine("Ürün Ekle------------ (2)");
        // Console.WriteLine("Ürün Güncelleme------ (3)");
        // Console.WriteLine("Ürün Sil------------- (4)");
        // Console.WriteLine("Çıkış---------------- (0)");
        // Console.WriteLine();
        // Console.Write("Seçiminiz: ");
        // string? choise = Console.ReadLine();
        // switch (choise)
        // {
        //     case "1":
        //         Console.WriteLine("Ürünler gösterildi, 50 adet ürün listelendi!");
        //         break;
        //     case "2":
        //         Console.WriteLine("Ürün başarıyla eklendi!");
        //         break;
        //     case "3":
        //         Console.WriteLine("Ürün başarıyla güncellendi!");
        //         break;
        //     case "4":
        //         Console.WriteLine("Ürün başarıyla silindi!");
        //         break;
        //     case "0":
        //         Console.WriteLine("Güle güle!");
        //         break;
        //     default:
        //         Console.WriteLine("Lütfen geçerli bir seçenek giriniz!");
        //         break;
        // }

        // Ternary if
        int a = 10;
        int b = 15;
        // string result = a > b ? $"Büyük sayı a'dır: {a}" : $"Büyük sayı b'dir: {b}";
        // string result =
        //     a > b
        //         ? $"Büyük sayı a'dır: {a}"
        //         : b > a
        //             ? $"Büyük sayı b'dir: {b}" 
        //             : "İki sayı birbirine eşittir!";
        // Console.WriteLine(result);
        Console.WriteLine(
            a > b
                ? $"Büyük sayı a'dır: {a}" 
                : b > a
                    ? $"Büyük sayı b'dir: {b}" 
                    : "İki sayı birbirine eşittir!"
            );


        Console.Write("Uygulama sona erdi, çıkış için Enter");
        Console.ReadLine();
    }
}





/*
    1) 
    if(koşul)
    {
        koşul doğru(true) ise çalışacak kodlar
    }

    2)
    if(koşul)
    {
        koşul doğru(true) ise çalışacak kodlar
    }
    else
    {
        koşul yanlış(false) ise çalışacak kodlar
    }

    3) 
    if(koşul1)
    {
        koşul1 doğru(true) ise çalışacak kodlar
    }
    else if(koşul2)
    {
        koşul1 yanlış(false) ise ve koşul2 doğru ise çalışacak kodlar
    }
    else if(koşul3)
    {
        koşul2 yanlış(false) ise ve koşul3 doğru ise çalışacak kodlar
    }
    else
    {
        koşul3 yanlış ise bakkala kız ve eve dön
    }

*/



/*
       if (choise == "1")
        {
            Console.WriteLine("Ürün listesi gösterildi, 456 adet ürün listelendi.");
        }
        else if (choise == "2")
        {
            Console.WriteLine("Ürün başarıyla eklendi!");
        }
        else if (choise == "3")
        {
            Console.WriteLine("Ürün başarıyla güncellendi!");
        }
        else if (choise == "4")
        {
            Console.WriteLine("Ürün başarıyla silindi!");
        }
        else if (choise == "0")
        {
            Console.WriteLine("Güle güle");
        }
        else
        {
            Console.WriteLine("Lütfen geçerli bir seçenek giriniz!");
        }
*/



// string result = string.Empty;
//         if (a > b)
//         {
//             result = $"Büyük sayı a'dır: {a}";
//         }
//         else if (b > a)
// {
//     result = $"Büyük sayı b'dir: {b}";
// }
// else
// {
//     result = $"İki sayı birbirine eşittir!";
// }