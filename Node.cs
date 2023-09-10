using System;

namespace Queues
{
    class Node<T>
    {
        public T Value
        { get; }
        public Node<T> NextNode
        { get; set; }

        public Node(T value, Node<T> nextNode)
        {
            Value = value;
            NextNode = nextNode;
        }
    }
}