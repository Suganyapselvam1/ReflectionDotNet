using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            var type1 = typeof(Student);
            var student1 = new Student();
            var student2= new Student();
            var type2 = student1.GetType();
            var type3 = student2.GetType();
            Console.WriteLine(type1);
            Console.WriteLine(type2);
            Console.WriteLine(type3);
            Console.WriteLine(type1==type2);
            Console.WriteLine(type1==type3);
            var type4 = typeof(Teacher);
            Console.WriteLine(type1==type4);
            /*
             * Type - is dotnet class.
             * When we use typeof(class) or obj.GetType() we will get same object which include the metadata of the particular class.
             * obj1.GetType() and obj2.GetType() will be same if obj1 and obj2 are from same class.
             */
        }
    }
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
