using System;
using System.Collections.Generic;

namespace Queues
{
    class LinkedList<T>
    {
        public Node<T> HeadNode
        { get; private set; }

        public LinkedList(T value)
        {
            HeadNode = new Node<T>(value);
        }

        public void InsertBeginning(T value)
        {
            Node<T> newNode = new Node<T>(value);
            newNode.NextNode = HeadNode;
            HeadNode = newNode;
        }

        public string Stringify()
        {
            string str = "";
            Node<T> current = HeadNode;
            while (current is not null)
            {
                if (current.Value is not null)
                {
                    str += Convert.ToString(current.Value) + "; ";
                }
                current = current.NextNode;
            }
            return str;
        }

        public static void SwapNodes(LinkedList<T> inputList, T val1, T val2)
        {
            Console.WriteLine($"Swapping {val1} with {val2}");

            Node<T> node1Prev = null;
            Node<T> node2Prev = null;
            Node<T> node1 = inputList.HeadNode;
            Node<T> node2 = inputList.HeadNode;

            if (EqualityComparer<T>.Default.Equals(val1, val2))
            {
                Console.WriteLine("Elements are the same. No swap necessary.");
                return;
            }

            while (node1 is not null)
            {
                if (EqualityComparer<T>.Default.Equals(node1.Value, val1))
                {
                    break;
                }
                node1Prev = node1;
                node1 = node1.NextNode;
            }
            while (node2 is not null)
            {
                if (EqualityComparer<T>.Default.Equals(node2.Value, val2))
                {
                    break;
                }
                node2Prev = node2;
                node2 = node2.NextNode;
            }

            if (node1 is null || node2 is null)
            {
                Console.WriteLine("Swap not possible - one or more elements not in list.");
                return;
            }

            if (node1Prev is null)
            {
                inputList.HeadNode = node2;
            }
            else
            {
                node1Prev.NextNode = node2;
            }

            if (node2Prev is null)
            {
                inputList.HeadNode = node1;
            }
            else
            {
                node2Prev.NextNode = node1;
            }

            Node<T> temp = node1.NextNode;
            node1.NextNode = node2.NextNode;
            node2.NextNode = temp;
        }
    }
}