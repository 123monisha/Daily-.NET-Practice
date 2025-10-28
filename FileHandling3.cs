//using System;
//using System.IO;

//namespace Daily_Practice
//{
//    internal class FileHandling3
//    {
//       static void Main(string[] args)
//        {
//            string filePath = "student.txt";
//            if(!File.Exists(filePath))
//            {
//                File.Create(filePath).Close();
//                Console.WriteLine("File created Successfully");
//            }
//            Console.WriteLine("Plesae enter The content u wants to append");
//            string content = Console.ReadLine();

//            File.AppendAllText(filePath, content + Environment.NewLine);

//            string content1 = File.ReadAllText(filePath);
//            Console.WriteLine(content1);
           
//        }
//    }
//}
