namespace Queues
{
    class Queue<T>
    {
        public Node<T> Head
        { get; set; }
        public Node<T> Tail
        { get; set; }
        public int MaxSize
        { get; }
        public int Size
        { get; private set; }

        public Queue(int? maxSize = null)
        {
            Head = null;
            Tail = null;
            MaxSize = (int)maxSize;
            Size = 0;
        }
    }
}