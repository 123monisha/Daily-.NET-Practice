//using System;

//namespace Practice_Bhai
//{
//    interface ILogger
//    {
//        void Log(string message);
//    }

//    public class FileLogger : ILogger
//    {
//        public void Log(string message)
//        {
//            Console.WriteLine("Logging to File");
//        }
//    }

//    public class DatabaseLogger : ILogger
//    {
//        public void Log(string message)
//        {
//            Console.WriteLine("Logging to Database");
//        }
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            ILogger logger;

//            logger = new FileLogger();
//            logger.Log("Any message");

//            logger = new DatabaseLogger();
//            logger.Log("Any message");
//        }
//    }
//}
