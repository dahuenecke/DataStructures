using System;

namespace LinkedLists
{
    internal class Node<T>
    {
        internal T Data { get; set; }
        internal Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
