using System;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>(4);
            q.Enqueue("Ben");
            q.Enqueue("Olivia");
            q.Enqueue("Reese");
            q.Enqueue("Puff");

            Console.WriteLine($"Peek: {q.Peek()}");
            Console.WriteLine($"Dequeue: {q.Dequeue()}");
            Console.WriteLine($"Peek again: {q.Peek()}");
            q.Enqueue("Too");
            q.Enqueue("Many");
        }
    }
}