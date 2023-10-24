using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherTest
{
    public class StudentTeacherTest
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet();
            Student student = new Student();
            student.SetAge(21);
            student.Greet();
            student.ShowAge();
            Teacher teacher = new Teacher();
            teacher.SetAge(45);
            teacher.Greet();
            teacher.Exlpain();
            Console.ReadKey();
        }
    }
}
