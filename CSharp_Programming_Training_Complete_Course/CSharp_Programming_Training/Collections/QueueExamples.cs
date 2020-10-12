using System;
using System.Collections.Generic;
using System.Text;

namespace QA_CSharp_Programming_Training.Collections
{
    class QueueExamples
    {

        public void ExecuteSimpleQueueExample()
        {
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");

            // Enumerar la cola sin modificar su ordenamiento.
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nRetirar de la cola el elemento '{0}'", numbers.Dequeue());


            // Enumerar la cola actualizada, en una nueva copia de la cola (ToArray)
            Queue<string> queueCopy = new Queue<string>(numbers.ToArray());

            Console.WriteLine("\nCola actualizada:");
            foreach (string number in queueCopy)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("\nExiste el valor (\"four\") en la cola? = {0}",
                queueCopy.Contains("four"));

            Console.WriteLine("\nEliminar contenido de la cola");
            queueCopy.Clear();
            Console.WriteLine("\nTotal de registros en la cola = {0}", queueCopy.Count);
        }
    }
}
