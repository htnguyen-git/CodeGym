using System;

namespace TrienKhaiStackSuDungLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Stack of integers");
            StackOfIntegers();
            Console.WriteLine("\n2. Stack of Strings");
            StackOfIStrings();
        }
        private static void StackOfIStrings()
        {
            MyGenericStack stack = new MyGenericStack();
            stack.Push("Five");
            stack.Push("Four");
            stack.Push("Three");
            stack.Push("Two");
            stack.Push("One");
            Console.WriteLine("1.1 Size of stack after push operations: " + stack.Size());
            Console.WriteLine("1.2. Pop elements from stack..");
            while (!stack.IsEmpty())
            {
                stack.Pop();
            }
            Console.WriteLine("\n1.3. Size of stack after pop operations : " + stack.Size());
        }
        private static void StackOfIntegers()
        {
            MyGenericStack stack = new MyGenericStack();
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            Console.WriteLine("2.1. Size of stack after push operations: " + stack.Size());
            Console.WriteLine("2.2. Pop elements from stack..");
            while (!stack.IsEmpty())
            {
                stack.Pop();
            }
            Console.WriteLine("\n3.3 Size of stack after pop operations : " + stack.Size());
        }
    }
}
