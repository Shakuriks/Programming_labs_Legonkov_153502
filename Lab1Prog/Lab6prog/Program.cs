using System;
using System.Collections.Generic;
using System.Reflection;


namespace Lab6prog
{
    internal class Program
    { 
        private static void PrintList(List<Employee> lst)
        {
            foreach(var item in lst)
            {
                Console.WriteLine(item.Print());
            }
        }
        static void Main(string[] args)
        {
            var rnd = new Random();
            var Employees = new List<Employee>();
            var fileName = @"C:\Музыка\Employees.json";

            for(var i = 0; i < 5; i++)
            {
                Employees.Add(new Employee() {Name = $"Employee{i}", Salary = rnd.Next(500, 3000), 
                                                Premium = (rnd.Next(0, 2) == 1 ? true : false) });
            }

            Console.WriteLine("Employees:\n");
            PrintList(Employees);


            Assembly asm = Assembly.LoadFrom(@"C:\Users\LegonkovNikita\source\repos\Lab1Prog\Lab6Library\bin\Debug\Lab6Library.dll");


            Type type = asm.GetType("Lab6Library.FileService`1").MakeGenericType(typeof(Employee));
            object obj = new object();
            if(type != null)
            {
                obj = Activator.CreateInstance(type);


                MethodInfo SaveData = type.GetMethod("SaveData");
                SaveData.Invoke(obj, new object[] { Employees, fileName });

                MethodInfo ReadFile = type.GetMethod("ReadFile");
                var newEmployees = (List<Employee>)ReadFile.Invoke(obj, new object[] { fileName });

                Console.WriteLine("Employees from File:\n");
                PrintList(newEmployees);
            }

            Console.ReadLine();
        }
    }
}
