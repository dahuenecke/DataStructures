using System;

namespace LinkedLists
{
    internal class LinkedList<T>
    {
        internal Node<T> head;

        public LinkedList()
        {
        }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> current = head;

            if (current == null)
            {
                head = node;
            }
            else 
            {
                while (current != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }

        public void AddBeginning(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                node.Next = head;
                head = node;
            }
        }

        public void AddAt(T data, int position)
        {
            if (position == 0)
            {
                AddBeginning(data);
            }
            else if (position == Count())
            {
                Add(data);
            }
            else
            {
                Node<T> currentNode = head;
                Node<T> previousNode = null;
                Node<T> node = new Node<T>(data);
                int currentPosition = 0;

                while (currentNode != null)
                {
                    if (currentPosition != position)
                    {
                        previousNode = currentNode;
                        currentNode = currentNode.Next;
                        currentPosition++;
                    }
                }

                previousNode.Next = node;
                node.Next = currentNode;
            }
        }

        public T RemoveAt(int position)
        {
            if (position == 0)
            {
                return Pop();
            }

            if (position <= Count())
            {
                Node<T> currentNode = head;
                Node<T> previousNode = null;
                int currentPosition = 0;

                while (currentNode != null)
                {
                    if (currentPosition != position)
                    {
                        previousNode = currentNode;
                        currentNode = currentNode.Next;
                        currentPosition++;
                    }
                }

                previousNode.Next = currentNode.Next;
                return currentNode.Data;
            }

            throw new IndexOutOfRangeException();
        }

        public T Pop()
        {
            if (head != null)
            {
                T topElement = head.Data;

                head = head.Next;

                return topElement;
            }

            return default(T);
        }

        public int Count()
        {
            int count = 0;
            Node<T> current = head;

            if (current == null)
            {
                return count;
            }

            while (current != null)
            {
                current = current.Next;
                count++;
            }

            return count;
        }

        public void Reverse()
        {
            Node<T> current = head;
            Node<T> previous = null;
            Node<T> next = null;

            if (current == null)
            {
                return;
            }

            while (current != null)
            { 
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            head = next;
        }
    }
}
