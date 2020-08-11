using System;
using System.Collections.Generic;

namespace LinkedListQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);
            linkedList.AddLast(6);

            bool isCircular = IsCircular(linkedList);
            Console.WriteLine(isCircular);

        }
        static bool IsCircular<T>(LinkedList<T> linkedList)
        {
            var slow = linkedList.First.Next;
            var fast = linkedList.First.Next.Next;

            while (slow != null && fast != null)
            {


                if (slow == fast)
                {
                    return true;
                }
                if (fast.Next != null)
                {
                    fast = fast.Next.Next;
                }
                slow = slow.Next;
            }
            return false;
        }
    }
}

