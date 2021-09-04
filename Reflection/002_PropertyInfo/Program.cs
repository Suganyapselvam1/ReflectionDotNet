using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_PropertyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAllProperties<Student>();
            PrintAllProperties<Teacher>();
            PrintAllProperties<string>();
            PrintAllProperties<List<int>>();
            PrintAllProperties<Queue<int>>();
            //-----------------------------------------------//
            Console.WriteLine("-----------------------------------------------");
            Student student1 = new Student()
            {
                Name="sugu",
                Age=22,
            };
            Student student2 = new Student()
            {
                Name = "venkat",
                Age = 25,
            };
            PrintAllPropertiesWithValue<Student>(student1);
            PrintAllPropertiesWithValue<Student>(student2);
            Teacher teacher = new Teacher()
            {
                Name = "sagu",
                Age = 42,
                Subject="Maths",
            };
            PrintAllPropertiesWithValue<Teacher>(teacher);
            //-----------------------------------------------//
            Console.WriteLine("-----------------------------------------------");
            PrintPropertyWithValue<Student>(student1,"Age");
            PrintPropertyWithValue<Teacher>(teacher, "subject");
        }
        public static void PrintAllProperties<T>()
        {
            var type = typeof(T);
            var properties = type.GetProperties();
            Console.WriteLine(type+" Properties");
            foreach (var item in properties)
            {
                Console.WriteLine(item);
            }
        }
        public static void PrintAllPropertiesWithValue<T>(T obj)
        {
            var type=obj.GetType();
            var props = type.GetProperties();
            foreach (var prop in props)
            {
                Console.WriteLine(prop+" "+prop.GetValue(obj));
            }
        }
        public static void PrintPropertyWithValue<T>(T obj,string propName)
        {
            var type = obj.GetType();
            var prop = type.GetProperty(propName);
            if (prop!=null)
            {
                Console.WriteLine(prop + " " + prop.GetValue(obj));
            }
            else
            {
                Console.WriteLine("property is not found");
            }
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
        public string Subject { get; set; }
    }
}
