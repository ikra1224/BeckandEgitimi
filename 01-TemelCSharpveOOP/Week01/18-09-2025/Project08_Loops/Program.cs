using System.Net.Security;

namespace Project08_Loops;

class Program
{
    static void Main(string[] args)
    {
        // for (int sayac =1; sayac < 6; sayac++)
        // {
        //     Console.WriteLine("hello world");
        // }


        //5000 tl lik anaparayı yıllık %20 faizle yıl boyu işletelim 5 yıllık toplam parayı hesaplayalım

        // decimal anaPara = 5000;
        // decimal faizOrani = 0.20m;

        // Console.WriteLine($"Başlangıç Anaparamız : " + anaPara);

        // for (int year = 1; year <= 5; year++)
        // {
        //     anaPara += anaPara * faizOrani;
        //    Console.WriteLine($"{year}. yıl sonundaki toplam para : " + anaPara);


        int bakiye = 1000;
        int cekilecekMiktar = 0;

        while (bakiye > 0)
        {
            Console.Write("Çekmek istediğiniz miktarı girin : ");
            cekilecekMiktar = Convert.ToInt32(Console.ReadLine());

            if (cekilecekMiktar > bakiye)
            {
                Console.WriteLine("Yetersiz Bakiye");
                continue;
            }

            bakiye -= cekilecekMiktar;
            Console.WriteLine($"Kalan bakiyeniz : " + bakiye);


        
        


        }
    }

