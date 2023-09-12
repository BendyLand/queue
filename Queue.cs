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