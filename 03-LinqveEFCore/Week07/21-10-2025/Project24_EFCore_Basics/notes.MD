EF Core ile çalışmak için yapılacaklar:

1) Sistem Düzeyinde: Bir kez yüklenmesi gereken EF Tool yüklemesi yapılmalıdır.
dotnet tool install --global dotnet-ef

2) Proje Düzeyinde: Her proje için yüklenmesi gereken Microsoft.EntityFramework.SqlServer ya da Microsoft.EntityFramework.Sqlite ya da  Microsoft.EntityFramework.MySql
dotnet add package Microsoft.EntityFrameworkCore.Sqlite 


Ayrıca EF Tool ile migration komutlarının CLI içinde çalışabilmesi için Microsoft.EntityFrameworkCore.Design paketine ihtiyaç vardır.
dotnet add package Microsoft.EntityFrameworkCore.Design

3) DbContext sınıfından miras alan bir sınıf yaratacağız. Bu sınıf, veritabanı ile olan tüm ilişkilerimizi, oturumumuzu yönetecek/belirleyecek olan sınıf.

4)  CodeFirst: Tasarıma koddan başlamak. Veritabanını kod ile yönetmek.
    DbFirst: Önce veri tabanını yaratmak, sonra koda onu ve yapısını aktarmak. 

Operasyonlarımız:
- Veritabanında Posts adında bir tabloya karşılık gelecek bir Post sınıfı yarattık.
- EFCore'dan gelen DbContext'ten miras alan AppDbContext adlı sınıfı yarattık. Bu projemiz için EF Core'un kalbi.
- DbSet<Post> ile Post sınıfının veri tabanındaki tabloyu temsil edeceğini EF Core'a bildirdik. Kodumuzun ihtiyaç duyduğumuz noktalarında context.Posts gibi bir komut kullanarak direkt db içindeki Posts tablosu üzerinde işlem yapabiliyor olacağız.
- OnConfiguring adlı metotu override ederek bunun içinde UseSqlite metodu ile veri tabanı bağlantı bilgimizi EF Core'a bildirdik.

Migrations: Modelimizdeki (yani entity sınıflarımızdaki) her değişikliği bir geçiş dosyası olarak kaydeder. Bu dosyalar, veri tabanının bir önceki durumdan yeni duruma nasıl geçeceğini anlatan C# kodları içerir. Ve bir sonraki aşamaya bizi hazırlamış olur.