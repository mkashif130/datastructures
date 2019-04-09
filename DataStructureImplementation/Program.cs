using System;

namespace DataStructureImplementation
{
    class Program
    {

        static void Main(string[] args)
        {
            LinkedListOperation();
            //StackOperation();
            Console.ReadLine();

        }
        public class Student
        {
            public int RollNumber { get; set; }
            public string name { get; set; }
        }
        private static void LinkedListOperation()
        {
            DataStructure.LinkedList<Student> linkedList = new DataStructure.LinkedList<Student>();
            linkedList.Push(new Student { name = "kashif", RollNumber = 1 });
            linkedList.Push(new Student { name = "asif", RollNumber = 2 });
            linkedList.Push(new Student { name = "mujtaba", RollNumber = 3 });
            linkedList.Push(new Student { name = "gautam", RollNumber = 4 });
            linkedList.Prepend(new Student { name = "muayyad", RollNumber = 0 });

            linkedList.Prepend(new Student { name = "ashraf", RollNumber = -1 });

            linkedList.Prepend(new Student { name = "anwar", RollNumber = -2 });

            linkedList.Prepend(new Student { name = "umesh", RollNumber = -3 });

        }

        private static void StackOperation()
        {

            DataStructure.Stack<string> stack = new DataStructure.Stack<string>();

            stack.Push("1");
            Console.WriteLine(stack.Peek());
            stack.Push("3");
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());
        }
    }
}
