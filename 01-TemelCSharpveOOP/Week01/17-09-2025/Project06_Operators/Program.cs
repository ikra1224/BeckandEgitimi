namespace Project06_Operators;

class Program
{
    static void Main(string[] args)
    {
        //aritmetik oparetörler
        // + - * / %,+=,-=,*=,/=,%=
        //shift + alt + aşağı ok= aynı satırı aşağıya taşır
        // int a = 100;
        // int b = 40;
        // int c = a + b;
        // int d = a - b;
        // int e = a * b;
        // decimal f = Convert.ToDecimal(a) / b;
        // int g = a % b;
        // Console.WriteLine("toplama: " + c);
        // Console.WriteLine("çıkarma: " + d);
        // Console.WriteLine("çarpma: " + e);
        // Console.WriteLine("bölme: " + f);
        // Console.WriteLine("mod alma: " + g);

        //     int number1 = 10;
        //    number1 += 20; // number1 = number1 + 20 kısa yazımı
        //    number1 *= 2; // number1 = number1 * 2 kısa yazımı
        //    number1 -= 5; // number1 = number1 - 10 kısa yazımı
        //    number1 /= 5; // number1 = number1 / 5 kısa yazımı
        //     Console.WriteLine(number1);



        // int i = 10;
        // //i = i + 1;
        // // i += 1;
        // i++; //i = i + 1
        // //eğer ++ operatörü değişkenin önünde ise önce artırma işlemi yapılır sonra işlem yapılır
        // //eğer ++ operatörü değişkenin arkasında ise önce işlem yapılır sonra artırma işlemi yapılır
        // Console.WriteLine(i++);
        // Console.WriteLine(i);
        // Console.WriteLine(++i);

        // int a = 20;
        //int b = a++ - 15 + a + a++ - a++ - 3 + ++a - 12;
        // Console.WriteLine(b);
        /* T:5   a:21
        T:26   a:21
        T:47   a:22
        T:25   a:23
        T:22   a:23
        T:46   a:24
        T:34   a:24

        */
        //Karşılaştırma operatörleri 
        // Eşitlik    : ==
        // Büyüktür Küçüktür : > ,  <
        //Büyük Eşittir  küçük eşittir   >=  <= 
        // Farklı(Eşit Değildir)  !=

        //     int a = 13;
        //     int b = 12;

        //     Console.WriteLine(a == b);
        //     Console.WriteLine(a != b);
        //     Console.WriteLine(a > b);
        //     Console.WriteLine(a < b);
        //     Console.WriteLine(a >= b);
        //     Console.WriteLine(a >= b);

        // Console.Write("Yaşınız Girin : ");
        // int age = int.Parse(Console.ReadLine());
        // bool isStatus = age >= 18;

        // Console.WriteLine("Ehliyet Alabilir mi : " + (isStatus ? "Evet : Hayır" ));

        // Mantıksal Operatörler 
        // AND : &&
        // OR  : ||
        // DEĞİL : !



        // int a = 10;
        // int b = 12;
        // Console.WriteLine(a == 10 && a > b); // Trıe And False = False
        // Console.WriteLine(a < b && b == 12); // True and true = true 
        // Console.WriteLine(a < 5 || b == 12);  // false or True = true
        // Console.WriteLine(a < 5 || b == a || 5 == 4); // false or false or false
        // Console.WriteLine(!(a == b)); // !(false) = true




        // String Interpolation
        string text1 = "Nişantası";
        string text2 = "Üniversitesi";
        string oldLocation = "Bayrampaşa";
        string currentLocation = "sarıyer";
        string date1 = "09.09.2009";
        string date2 = "05.06.2018";
        // Hedef : Nişantası üniversitesi , 09.09.2009 tarihinde istambul 'un Bayrampaşa ilçesinde faaliyetlerine başlamıştır. Ardından 05.05.2018 tarihinde yine istanbul'un Sarıyer ilçesinde kurulan TechCampus'e taşınmışıtr. 

        // Çözüm1 :

        string result = text1 + " " + text2 + ", " + date1 + " tarihinde İstanbul'un" + oldLocation + "ilçesinde faatlerine başlamıştır. Ardından " + date2 + " tarhinde yine istanbul'un " + currentLocation + "ilçesinde kurulan techcampus ' e taşınmıştır.";

        //Çözüm2:
        string result2 = 








        


        
    }
}
