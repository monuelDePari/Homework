using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging.Console;
    using Microsoft.Extensions.Logging;
    class UniversityContext : DbContext
    {
        private static readonly LoggerFactory _log = new LoggerFactory(new []{new ConsoleLoggerProvider((s, LogLevel) => true, true)});
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLoggerFactory(_log);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CoursesDemo2;Trusted_Connection=True;");
        }
        public DbSet<Student> MyStudent { get; set; }
        public DbSet<Exam> Exams { get; set; }
    }
}
