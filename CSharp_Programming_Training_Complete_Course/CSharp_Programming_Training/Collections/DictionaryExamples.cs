using System;
using System.Collections.Generic;
using System.Text;

namespace QA_CSharp_Programming_Training.Collections
{
    public class DictionaryExamples
    {
        public void ExecuteSimpleDictionaryExample()
        {
            var employeesByName = new Dictionary<string, Employee>();
            employeesByName.Add("Charles", new Employee { Name = "Scott" });
            employeesByName.Add("Jhon", new Employee { Name = "Alex" });
            employeesByName.Add("Boy", new Employee { Name = "Joy" });

          
            foreach (var item in employeesByName)
            {
                Console.WriteLine("{0}:{1}", item.Key, item.Value.Name);
            }

        }
    }

}