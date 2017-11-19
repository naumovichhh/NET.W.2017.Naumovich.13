using System;

namespace Day13
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Random string");
            queue.Enqueue("Another string");
            queue.Enqueue(32.ToString());
            queue.Enqueue("Last string");
            Console.WriteLine(queue.Dequeue() + Environment.NewLine +
                "_____________________________________________________________");
            foreach (var str in queue)
            {
                Console.Write(str + ", ");
            }

            Console.WriteLine(Environment.NewLine + "_____________________________________________________________");
            queue.Enqueue("Русская строка");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            while (!queue.IsEmpty)
            {
                Console.WriteLine(queue.Dequeue());
            }

            Console.ReadKey();
        }
    }
}
