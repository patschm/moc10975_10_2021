using System;
using System.Collections.Generic;

namespace Collecties
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestArrays();

            // TestCollections();
            // TestQueue();
            //TestStack();
            TestDictionary();
        }

        private static void TestDictionary()
        {
            Dictionary<string, int> lookup = new Dictionary<string, int>();
            lookup.Add("een", 1);
            lookup.Add("twee", 2);

            int nr = lookup["twee"];
            Console.WriteLine(nr);
        }

        private static void TestStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(2);
            stack.Push(5);

            int nr = stack.Pop();
            Console.WriteLine(nr);
            nr = stack.Pop();
            Console.WriteLine(nr);
            Console.WriteLine(stack.Count);
            // queue.Dequeue();
        }
        private static void TestQueue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(2);
            queue.Enqueue(5);

            int nr = queue.Dequeue();
            Console.WriteLine(nr);
            nr = queue.Dequeue();
            Console.WriteLine(nr);
            Console.WriteLine(queue.Count);
           // queue.Dequeue();
        }

        private static void TestCollections()
        {
            List<KipCaravan> list = new List<KipCaravan>();
            List<int> mijnlist = new List<int>();
            mijnlist.Add(4);
            mijnlist.Add(5);
            mijnlist.Insert(1, 9);

            int nr = mijnlist[2];
            Console.WriteLine(nr);
        }

        static void TestArrays()
        {
            object[] vanalles = new object[10]; // Niet doen !!!
            DateTime[] data = new DateTime[3];
            KipCaravan[] kips = new KipCaravan[10];
            int[] nummers = new int[10];
            string[] heapstraat29 = new string[6];

            heapstraat29[0] = "Hallo";
            heapstraat29[1] = "boring";
            heapstraat29[2] = "world";

            heapstraat29[5] = "Ooops";

            //string s = "";
            for (int index = 0; index < heapstraat29.Length; index++)
            {
                string s1 = heapstraat29[index];
                Console.WriteLine(s1);
            }

            foreach(string s1 in heapstraat29)
            {
                Console.WriteLine(s1);
            }
            
        }
    }
}
