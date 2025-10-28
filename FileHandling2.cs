//using System;
//using System.IO;

//namespace Daily_Practice
//{
//    internal class FileHandling2
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Please enter your Name:");
//            string name = Console.ReadLine();

//            Console.WriteLine("Please enter your Age:");
//            string age = Console.ReadLine();

//            string fileName = "user.txt";

//            File.WriteAllText(fileName, $"Name: {name}\nAge: {age}");

//            string content = File.ReadAllText(fileName);
//            Console.WriteLine("\n--- File Content ---");
//            Console.WriteLine(content);
//        }
//    }
//}
