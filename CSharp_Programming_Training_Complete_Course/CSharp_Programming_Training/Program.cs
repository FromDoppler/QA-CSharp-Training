using System;
using System.Collections.Generic;

namespace QA_CSharp_Training
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee> 
            {
                new Employee {Name ="Roxanne" },
                new Employee {Name ="Alex" }
            };


            employees.Add(new Employee ("Dani"));

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }


            for (int i =0; i< employees.Count; i++)
            {
                Console.WriteLine(employees[i].Name);
            }
        }
    }
}
