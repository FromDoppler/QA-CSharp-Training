using System;
using System.Collections.Generic;
using System.Reflection;

namespace QA_CSharp_Programming_Training
{
    public class Program
    {
        static readonly Dictionary<int, string> examplesAvailable = new Dictionary<int, string> ()
        {
            { 1, "ExecuteListInitExample"},
            { 2, "ExecuteSimpleDelegateExample"},
            { 3, "ExecuteSimpleDictionaryExample"}
        };

        static readonly Dictionary<int, string> namespacesAvailable = new Dictionary<int, string>()
        {
            { 1, "QA_CSharp_Programming_Training.Collections.ListExamples"},
            { 2, "QA_CSharp_Programming_Training.Delegates.DelegatesExamples"},
            { 3, "QA_CSharp_Programming_Training.Collections.DictionaryExamples"}
        };

        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("Welcome to C# Examples!");
            Console.WriteLine("-----------------------");

            while (!endApp)
            {
                PrintMenu();

                Console.Write("Type the number of the example you will like to execute, and then press Enter: ");
                string option = Console.ReadLine();                

                if (int.TryParse(option, out int optionToInt))
                {
                    InvokeMenuMethod(optionToInt);
                }
                else
                {
                    Console.WriteLine("This is not valid input. Please enter an integer next time");
                }

                Console.WriteLine("------------------------");
                Console.WriteLine("Press any key or 'exit' if you don't want to execute more examples: ");

                if (Console.ReadLine().Equals("exit")) { endApp = true; }
            }
        }

        static void InvokeMenuMethod(int menuOption)
        {
            Type t = Type.GetType(namespacesAvailable[menuOption]);
            ConstructorInfo magicConstructor = t.GetConstructor(Type.EmptyTypes);
            object magicClassObject = magicConstructor.Invoke(new object[] { });

            var exampleMethod = t.GetMethod(examplesAvailable[menuOption]);
            exampleMethod.Invoke(magicClassObject, null);
        }

        static void PrintMenu()
        {
            foreach (var exampleName in examplesAvailable)
            {
                Console.WriteLine($"{exampleName.Key}) {exampleName.Value}");
            }
            Console.WriteLine("------------------------");
        }
    }
}
