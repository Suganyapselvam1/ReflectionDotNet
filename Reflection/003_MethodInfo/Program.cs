using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_MethodInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAllMethods<Student>();
            PrintAllMethods<Teacher>();
            Student student = new Student()
            {
                Name="sugu",
                Age=22,
            };
            //----------------------------------------//
            Console.WriteLine("------------------------------");
            InvokeMethod<Student>(student, "PrintPropertValue");
            //----------------------------------------//
            Console.WriteLine("------------------------------");
            //InvokeMethodWithValue<Student>(student, "PrintPropertValue",new object[] { 4});
            //----------------------------------------//
            Console.WriteLine("------------------------------");
            InvokeMethodWithValue<Student>(student, "GetLength", new object[] { 4});
        }
        public static void InvokeMethodWithValue<T>(T obj, string name,object[] param)
        {
            var type = typeof(T);
            var method = type.GetMethod(name);
            if (method != null)
            {
               var value= method.Invoke(obj, param);
                Console.WriteLine("Return Value from invoke method: "+value);
            }
            else
            {
                Console.WriteLine("method name is not found");
            }
        }
        public static void InvokeMethod<T>(T obj,string name)
        {
            var type = typeof(T);
            var method = type.GetMethod(name);
            if (method!=null)
            {
                method.Invoke(obj, null);
            }
            else
            {
                Console.WriteLine("method name is not found");
            }
        }
        public static void PrintAllMethods<T>()
        {
            var type = typeof(T);
            var methods = type.GetMethods();
            var count = 1;
            foreach (var method in methods)
            {
                Console.WriteLine(count+" " +method);
                count++;
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void PrintPropertValue()
        {
            Console.WriteLine(Name+" "+Age);
        }
        public int GetLength(int a)
        {
            return (Name + Age.ToString()).Length * a;
        }
    }
    class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Subject { get; set; }
        public int GetLength()
        {
            return (Subject + Age.ToString()).Length;
        }
    }
}
