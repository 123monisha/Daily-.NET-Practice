using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Bhai
{
    internal class likedList1
    {
        static void Main(string[] args)
        {
            LinkedList<string> cities = new LinkedList<string>();
            cities.AddLast("banglore");
            cities.AddLast("Mysore");
            cities.AddLast("Manglore");
            cities.AddLast("Vrindavan");
            cities.AddLast("Nothing");
            cities.Remove("Manglore");

            foreach(string s in cities)
            {
                Console.WriteLine(s);
            }

        }
    }
}
