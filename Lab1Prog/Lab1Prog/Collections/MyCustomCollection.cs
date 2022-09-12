using System;
using System.Collections;
using System.Collections.Generic;
using Lab1Prog.Interfaces;

namespace Lab1Prog.Collections
{
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
    internal class MyCustomCollection<T> : ICustomCollection<T>, IEnumerable<T>
    {
        private int count;
        private Node<T> current;
        private Node<T> head;
        private Node<T> tail;

        public T this[int index]
        {
            get
            {
                try
                {
                    if (index > count - 1)
                        throw new IndexOutOfRangeException();
                    current = head;
                    int i = 0;
                    while (i != index)
                    {
                        current = current.Next;
                        i++;
                    }
                    return current.Data;
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message} Information about the 1 element was returned");
                    return head.Data;
                }
            }
            set
            {
                try
                {
                    if (index > count - 1)
                        throw new IndexOutOfRangeException();
                    current = head;
                    int i = 0;
                    while (i != index)
                    {
                        current = current.Next;
                        i++;
                    }
                    current.Data = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }


        public int Count => count;

        public void Add(T item)
        {
            Node<T> node = new Node<T>(item);

            if (head == null)
            {
                head = tail = current = node;
            }
            else
                tail.Next = node;
            tail = node;

            count++;
        }

        public T Current()
        {
            return current.Data;
        }

        public void Next()
        {
            if(current != null && current.Next != null)
                current = current.Next;
        }

        public void Remove(T item)
        {
            current = head;
            Node<T> prevCurrent = null;

            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    if (prevCurrent != null)
                    {
                        prevCurrent.Next = current.Next;

                        if (current.Next == null)
                            tail = current = prevCurrent;
                        else
                            current = current.Next;
                        
                    }
                    else
                    {
                        head = head.Next;

                        if (head == null)
                            tail = current = null;
                        else
                            current = head;
                    }
                    count--;
                    return;
                }

                prevCurrent = current;
                current = current.Next;
            }
            try
            {
                throw new Exception("Element was not found.");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void RemoveCurrent()
        {
            if(current != null)
            {
                if (current == head)
                {
                    if (head.Next != null)
                        head = current = head.Next;
                    else
                        head = tail = current = null;
                }
                else if (current == tail)
                {
                    Node<T> temp = head;
                    while (temp.Next != current)
                        temp = temp.Next;
                    tail = current = temp;
                }
                else
                {
                    Node<T> temp = head;
                    while (temp.Next != current)
                        temp = temp.Next;
                    temp.Next = current.Next;
                }
                count--;
            }
        }

        public void Reset()
        {
            current = head;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
            current = head;
        }
    }
}
