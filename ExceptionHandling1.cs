//using System;
//using System.Collections.Generic;

//namespace Daily_Practice
//{
//    internal class ExceptionHandling1
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                List<int> list = new List<int>();

//                Console.WriteLine("Enter the number of elements you want to add to the list:");
//                int n = Convert.ToInt32(Console.ReadLine());

//                Console.WriteLine("Enter the elements:");
//                for (int i = 0; i < n; i++) 
//                {
//                    int num = Convert.ToInt32(Console.ReadLine());
//                    list.Add(num);
//                }

//                Console.WriteLine("Enter the index you want to see:");
//                int index = Convert.ToInt32(Console.ReadLine());
//                if (index < 0 || index >= list.Count)
//                {
//                    throw new IndexOutOfRangeException("Index is out of range for the list!");
//                }

//                Console.WriteLine($"Element at index {index} is: {list[index]}");
//            }
//            catch (IndexOutOfRangeException ex)
//            {
//                Console.WriteLine("Error: " + ex.Message);
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Please enter only valid numbers!");
//            }
//            finally
//            {
//                Console.WriteLine("Program executed successfully (finally block).");
//            }
//        }
//    }
//}
