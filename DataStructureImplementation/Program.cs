using System;

namespace DataStructureImplementation
{
    class Program
    {

        static void Main(string[] args)
        {
            DataStructure.Stack<string> stack = new DataStructure.Stack<string>();
        
            stack.Push("1");
            Console.WriteLine(stack.Peek());
            stack.Push("3");
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());
            Console.ReadLine();

        }
    }
}
