using System.Collections.Generic;

namespace Daily_Practice
{
    internal class DS3
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Krishna");
            stack.Push("Radha");
            stack.Push("Monisha");

            stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(stack.Peek());
            int count = stack.Count;
            Console.WriteLine(count);


        }
    }
}


