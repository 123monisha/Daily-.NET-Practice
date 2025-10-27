using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Practice
{
    internal class Datastucture1
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("Krishna");
            q.Enqueue("Radha");
            q.Enqueue("Monisha");

            q.Dequeue();

            foreach(var i in q)
            {
                Console.WriteLine(i);
            }
        }
    }
}
