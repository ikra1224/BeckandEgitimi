* Dotnet CLI ile proje oluşturmak:
    - dotnet new console (içinde bulunulan klasörün adıyla oraya console projesi oluşturur)
    - dotnet new console -o ProjeAdı (içinde bulunulan klasörün içine ProjeAdı adıyla bir klasör oluşturup, projeyi bu klasörün içine ve bu adla oluşturur)
    - dotnet new console -o ProjeAdı --use-program-main (içinde bulunulan klasörün içine ProjeAdı adıyla bir klasör oluşturup, projeyi bu klasörün içine,bu adla ve Main metodunu kullanarak oluşturur. Yani Top Level Statement özelliğini kullanmaz.)

Değişkenler:
    - Değişkenler içerisinde veri tutmaya yarayan yapılardır.
    - Bellekte(RAM) tutulurlar. 01010100
    - Veri Tipleri: int, short, string vb

Değişken tanımlama:
    degisken_tipi degisken_adi = degiskenin_degeri;
    int yas = 42;

Değişken Tanımlama Kural ve İlkeleri:
    - C# BÜYÜK/küçük harf duyarlıdır. Örneğin yas ile Yas birbirinden farklı değerlendirilir.
    - Değişken adlarının içerisinde özel karakterler olamaz(_ hariç)
    - Değişken adları C#'ın özel kelimelerinden biri olamaz.
    - Değişkenleri anlamlı olarak adlandırmalıyız.
        Ör: sayi yerine yas, tarih yerine dogum_tarihi
    - Türkçe isimlendirme yapmamaya çalışın. 
        Ör: yaş yerine age, ad_soyad yerine name
    - Değişken isimlendiriken camelCase tekniğini kullanın.
    Yani; değişken adı tek kelimeden oluşuyorsa tamamen küçük harfle, birden fazla kelimeden oluşuyorsa ilk kelime tamamen küçük, diğer kelimelerin ilk harfi büyük, kalan harfleri küçük olacak şekilde.
        Ör: name, age, studentNumber, dateOfBirth 

