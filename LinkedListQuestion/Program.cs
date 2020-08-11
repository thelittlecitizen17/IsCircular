using System;
using System.Collections.Generic;

namespace LinkedListQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();


            bool isCircular = IsCircular(linkedList);
            Console.WriteLine(isCircular);

        }
        static bool IsCircular<T>(LinkedList<T> linkedList)
        {


            if (linkedList.Count <3 || linkedList.First==null)
            {

                return false;

            }

            else {

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
            return false;
        }
    }
}

