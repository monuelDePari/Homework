//[XmlIgnore] - не пише і вичитує проперті
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
namespace SS4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            XDocument document = XDocument.Load("XMLFile1.xml");
            var all = document.Descendants();
            var allStudentElement = all.Where(elem => elem.Name == "Student");
            /*
            XElement studentsElement = document.Element("Students");
            var allStudentElement = studentsElement.Elements("Student");
            */
            foreach (XElement studentElement in allStudentElement)
            {
                Student student = new Student();
                XAttribute attribute = studentElement.Attribute("firstName");
                student.FirstName = attribute.Value;
                student.LastName = studentElement.Attribute("lastName").Value;
                student.BirthDate = DateTime.Parse(studentElement.Element("BirthDate").Value);
                student.Email = studentElement.Element("Email").Value;
                student.PhoneNumber = studentElement.Element("PhoneNumber");
                student.ExtraData = GetExtraDate(studentElement);
                students.Add(student);
            }
        }
    }
    private static Dictionary<string, string> GetExtraData(XElement studentElement)
    {
        Dictionary<string, string> result = new Dictionary<>
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; internal set; }
        public DateTime BirthDate { get; internal set; }
        public string Email { get; internal set; }
        public XElement PhoneNumber { get; internal set; }
        public object ExtraData { get; internal set; }
    }
}
