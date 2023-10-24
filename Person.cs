using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherTest
{
    public class Person
    {
        protected int age;
        
        public void ShowAge()
        {
            Console.WriteLine("My age is: {0} years old", age);
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
        
    }
}
