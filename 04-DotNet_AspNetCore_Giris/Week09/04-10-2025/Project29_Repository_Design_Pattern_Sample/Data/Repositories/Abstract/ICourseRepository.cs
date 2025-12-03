using System;
using Project29_Repository_Design_Pattern_Sample.Data.Entities;

namespace Project29_Repository_Design_Pattern_Sample.Data.Repositories.Abstract;

public interface ICourseRepository
{
    // Course ile ilgili yapılabilecek DB işlemlerini burada belirliyoruz.
    void Add(Course course);
    void AddToCourse(int studentId, int courseId);
    Course GetCourseWithStudents(int courseId);
    // void Update(Course course);
    // void Delete(int courseId);
    // void RemoveFromCourse(int studentId, int courseId);
}
