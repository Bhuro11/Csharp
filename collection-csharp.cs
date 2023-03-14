// Collections...
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("------------Array List ------------");
            Console.WriteLine("-----------------------------------");
            ArrayList al = new ArrayList();
            al.Add("BSC.IT");
            al.Add("BCA");
            al.Sort();
            //al.Clear();
            foreach (string item in al)
            {
                Console.WriteLine(item);
            }
            al.Remove("BCA");
            foreach (string item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("------------Hash Table ------------");
            Console.WriteLine("-----------------------------------");
            Hashtable ht = new Hashtable();
            ht.Add(1,"Bsc.it");
            ht.Add(2,"Bba");
            foreach (string item in ht.Values)
            {
                Console.WriteLine(item);
            }
            ht.Remove(2);
            //ht.Clear();
            foreach (string item in ht.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("------------Stack ------------");
            Console.WriteLine("------------------------------");
            Stack s = new Stack();
            s.Push("Bhargav");
            s.Push("Bhuro");
            foreach (string item in s)
            {
                Console.WriteLine(item);
            }
            s.Pop();
            foreach (string item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("------------Queue ------------");
            Console.WriteLine("------------------------------");
            Queue q = new Queue();
            q.Enqueue("bt");
            q.Enqueue("BT");
            foreach (string item in q)
            {
                Console.WriteLine(item);
            }
            q.Dequeue();
            foreach (string item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("------------Shorted List------------");
            Console.WriteLine("------------------------------");
            SortedList sl = new SortedList();
            sl.Add(2,"BHARGAV");
            sl.Add(1,"bhargav");
            foreach (string item in sl.Values)
            {
                Console.WriteLine(item);
            }
            sl.Remove(1);
            foreach (string item in sl.Values)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
