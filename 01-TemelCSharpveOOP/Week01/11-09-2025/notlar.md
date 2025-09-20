*Dotnet CLI ile proje oluşturmak:
    -dotnet new console (içinde bulunan klasörün adıyla oraya console projesi oluştur)
    -dotnet new cosole -0 projeAdı (içinde bulunan klasörün içine proje adıyla bir klasör oluşturup, projeyi bu klasörün içine bu adla oluşturur.)
    -dotnet new console -0 Project02_HelloWorld --use-program-main (içinde bulunan klasörün içine proje adıyla bir klasör oluşturup, projeyi bu klasörün içine bu adla ve main metodunu kullanarak oluşturur. yani top level statmen özelliğini kullanmaz.)

    Değişkenler:
    -Değişkenler içerisinde veri tutmaya yarayan yapıdır.
    -Bellekte(RAM)tutulurlar. 01010100
    -Veri Tipleri:int short string vb

    Değiken tanımı
    
    değişken_tipi değişken_adi=degişken_değeri;
    int yas=42;

    Degişken tanımlama Kural ve İlkeleri:
    -c# BÜYÜK/küçük harf duyarlıdır.örneğin yas ile yas birbirlerinden farklı değerlendir
    -Değişken adlarının içerisinde özel karakterler olmaz (_)hariç
    -değişken adları C# ın özel kelimelerinden biri olamaz
    -değişkenleri anlamlı olarak adlandırmalıyız
         Ör-sayi yerine yas tarih yerine doğum tarihi 
    -Türkçe isimlendirme yapmamaya çalışın.
         Ör-yaş yerine aga,ad soyad yerine name 

         -değişken isimlendirirken camelCase tekniğini kullanın.
         yani: değişken adı tek kelimeden oluşuyorsa tamamen küçük harfle,birden fazla kelimeden oluşuyorsa ilk kelime tamamen küçük diğer kelimelerin ilk harfi büyük kalan harfleri küçük olacak şekilde 
         -örn name age studentNumber
    -

