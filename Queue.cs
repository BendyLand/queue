using System;

namespace Queues
{
    class Queue<T>
    {
        public Node<T> Head
        { get; set; }
        public Node<T> Tail
        { get; set; }
        public int? MaxSize
        { get; }
        public int Size
        { get; private set; }

        public Queue(int? maxSize = null)
        {
            Head = null;
            Tail = null;
            MaxSize = maxSize;
            Size = 0;
        }

        public void Enqueue(T value)
        {
            if (HasSpace())
            {
                Node<T> itemToAdd = new Node<T>(value);
                Console.WriteLine($"Adding {Convert.ToString(itemToAdd.Value)} to the queue!");
                if (IsEmpty())
                {
                    Head = itemToAdd;
                    Tail = itemToAdd;
                }
                else
                {
                    Tail.NextNode = itemToAdd;
                    Tail = itemToAdd;
                }
                Size++;
            }
            else
            {
                Console.WriteLine("Sorry, no more room!");
            }
        }

        public T Dequeue()
        {
            if (Size > 0)
            {
                Node<T> itemToRemove = Head;
                Console.WriteLine($"{Convert.ToString(itemToRemove.Value)} is served!");
                if (Size == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Head = Head.NextNode;
                }
                Size--;
                return itemToRemove.Value;
            }
            else
            {
                Console.WriteLine("The queue is totally empty");
                return default(T);
            }
        }

        public T Peek()
        {
            if (Size > 0)
            {
                return Head.Value;
            }
            else
            {
                Console.WriteLine("No orders waiting.");
                return default(T);
            }
        }
        public bool HasSpace()
        {
            if (MaxSize == null)
            {
                return true;
            }
            else
            {
                return MaxSize > Size;
            }
        }

        public bool IsEmpty()
        {
            return Size == 0;
        }
    }
}