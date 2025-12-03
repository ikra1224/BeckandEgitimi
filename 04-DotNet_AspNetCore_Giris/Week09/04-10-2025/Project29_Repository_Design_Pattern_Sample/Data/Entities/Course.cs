using System;

namespace Project29_Repository_Design_Pattern_Sample.Data.Entities;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<StudentCourse> StudentCourses { get; set; } = [];
}

