using System;
using System.Collections.Generic;

namespace IntCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<int> lt = new List<int>();
            Stack<int> st = new Stack<int>();
            Queue<int> qw = new Queue<int>();
            HashSet<int> hs = new HashSet<int>();

            lt.Add(1);
            lt.Add(10);
            lt.Add(-30);
            lt.Add(10);
            lt.Add(-5);

            st.Push(1);
            st.Push(10);
            st.Push(-30);
            st.Push(10);
            st.Push(-5);

            qw.Enqueue(1);
            qw.Enqueue(10);
            qw.Enqueue(-30);
            qw.Enqueue(10);
            qw.Enqueue(-5);

            hs.Add(1);
            hs.Add(10);
            hs.Add(-30);
            hs.Add(10);
            hs.Add(-5);

            Console.Write("List:");
            foreach(int i in lt)
            {
                Console.Write($" {i},");
            }

            Console.Write("\nStack:");
            foreach(int i in st)
            {
                Console.Write($" {i},");
            }

            Console.Write("\nQueue:");
            foreach(int i in qw)
            {
                Console.Write($" {i},");
            }

            Console.Write("\nHashSet:");
            foreach(int i in hs)
            {
                Console.Write($" {i},");
            }
        }
    }
}
