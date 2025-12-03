using System;

namespace Project29_Repository_Design_Pattern_Sample.Data.Entities;

public class StudentCourse
{
    // EF Core bir PK olmasını zorunlu tutar. Biz burada Id tanımlamadığımız için PK yok. Bu bize migration/database update işlemleri sırasında sorun çıkartacak.
    
    public int StudentId { get; set; }
    public Student? Student { get; set; }
    public int CourseId { get; set; }
    public Course? Course { get; set; }
}
