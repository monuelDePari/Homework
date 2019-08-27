using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public List<Exam> Exams { get; set; }
        //[Key]
        //[ForeignKey("StudentAdress")]
        //public int StudentAdressId { get; set; }
        //public StudentAdress StudentAdress { get; set; }
    }
}
