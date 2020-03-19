using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApplication
{

    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            for (Node<T> x = head; x != null; x = x.Next)
            {
                action(x.Data);
            }

        }

       
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 整型List
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }
            int min = 0x7fffffff, max = 0x0, sum = 0;

            intlist.ForEach(m => Console.WriteLine(m));
            intlist.ForEach(m => { if (m < min) min = m; });
            intlist.ForEach(m => { if (m > max) max = m; });
            intlist.ForEach(m => sum += m);
            Console.WriteLine($"{ min}, {max}, {sum}");





        }

    }
}