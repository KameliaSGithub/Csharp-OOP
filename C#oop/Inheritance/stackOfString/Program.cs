using System;
using System.Collections.Generic;

namespace stackOfString
{
    public class StartUp
    {
        public static void Main()
        {
            StackOfStrings stack = new StackOfStrings();

            stack.AddRange(new List<string> { "first", "second", "third" });

            Console.WriteLine("Is stack empty? " + stack.IsEmpty());

            while (!stack.IsEmpty())
            {
                Console.WriteLine("Popped: " + stack.Pop());
            }

            Console.WriteLine("Is stack empty? " + stack.IsEmpty());
        }
    }

    public class StackOfStrings
    {
        private readonly Stack<string> stack;

        public StackOfStrings()
        {
            stack = new Stack<string>();
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }

        public void AddRange(IEnumerable<string> collection)
        {
            foreach (var item in collection)
            {
                stack.Push(item);
            }
        }

        public void Push(string item)
        {
            stack.Push(item);
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return stack.Pop();
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return stack.Peek();
        }

        public int Count()
        {
            return stack.Count;
        }
    }
}