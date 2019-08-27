using System;
using System.Collections.Generic;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new UniversityContext())
            {
                context.Database.EnsureCreated();
                context.MyStudent.Add(new Student() { Name = "Test", Exams = new List<Exam>() { new Exam() { Name = "Math" }, new Exam() { Name = "Physics" } } });
                context.SaveChanges();
            }
            using(var context = new UniversityContext())
            {
                context.Database.EnsureDeleted();
            }
                Console.Read();
        }
    }
}
