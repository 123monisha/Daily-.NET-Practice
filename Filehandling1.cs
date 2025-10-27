//using System;
//using System.IO;

//namespace Daily_Practice
//{
//    internal class Filehandling1
//    {
//        static void Main(string[] args)
//        {
//            string sourcePath = "source.txt";
//            string destinationPath = "destination.txt";

//            if (!File.Exists(sourcePath))
//            {
//                File.WriteAllText(sourcePath, "hello krishna!! this is radha");
//            }

//            string content = File.ReadAllText(sourcePath);
//            string uppercse = content.ToUpper();

//            File.WriteAllText(destinationPath, sourcePath);
//            Console.WriteLine("all data copied from souce file to destination file successfully");
//            Console.WriteLine("source content:" + content);
//            Console.WriteLine("destination Content" + uppercse);
//        }
//    }
//}
