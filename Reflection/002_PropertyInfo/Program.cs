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
