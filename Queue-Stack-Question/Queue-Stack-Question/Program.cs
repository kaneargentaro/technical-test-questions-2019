/*
 A program that creates a Queue class and Enqueue(), and Dequeue() methods inside of it. The Queue can only use stack members inside of it, and it is assumed that the Push(), and Pop() methods are already declared.

Requirements: Methods: void Enqueue(T) T Dequeue() Rules: stacks as members only - stack has methods Push(T), T pop()

This was written as part of a technical test in the job recruitment process for a company. This was created on the 14th of Aug, 2019.
 */

using System;
using System.Collections;

namespace Queue_Stack_Question
{
    public class Queue
    {
        public Stack s1 = new Stack();
        public Stack s2 = new Stack();

        public void Enqueue(int x)
        {
            //move the elements in s1 to s2
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }

            //push T into s1
            s1.Push(x);

            //push everything back into s1
            while (s2.Count > 0)
            {
                s1.Push(s2.Pop());
            }
        }

        public int Dequeue()
        {
            //check to see if s1 is empty or not
            if (s1.Count == 0)
            {
                Console.WriteLine("S1 is empty");
            }

            //Pop a value from s1
            int x = (int)s1.Peek();
            s1.Pop();
            return x;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue myq = new Queue();
            myq.Enqueue(1);
            myq.Enqueue(3);
            myq.Enqueue(4);

            Console.WriteLine(myq.Dequeue());
        }
    }
}
