using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Stack
    {
        private readonly List<Object> list=new List<object>();

       
        public void Push(Object obj )
        {
            if (obj==null)
            {
                throw new InvalidOperationException("Invalid input");
            }
            list.Add(obj);

        }

        public object Pop()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Cant pop from empty list");

            list.RemoveAt(list.Count - 1);

            return (list);
        }

      

        public void Clear()
        {
            list.Clear();
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            Console.WriteLine(stack);
            Console.ReadLine();
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack);
            Console.ReadLine();
            Console.WriteLine(stack.Pop());
            Console.ReadLine();
        }
    }
}
