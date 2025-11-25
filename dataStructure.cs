//using System;
//using System.IO;

//namespace Practice_Bhai
//{
//    internal class dataStructure
//    {
//        public static void Main(string[] args)
//        {
//            string FileName = "krishna.txt";
//            StreamWriter writer = new StreamWriter(FileName);
//            writer.WriteLine("Hare raaam");
//            writer.WriteLine("Hare krishna");
//            writer.WriteLine("Hare raaam");
//            writer.WriteLine("Hare krishna");
//            writer.WriteLine("error krishna");
//            writer.Close();

            
//                StreamReader reader = new StreamReader(FileName);
//                string line;
//                while ((line = reader.ReadLine()) != null)
//                {
//                    if (line.ToLower().Contains("error"))
//                    {
//                        Console.WriteLine(line);
//                    }
//                }
//            reader.Close();
            
//        }
        

//    }
//}
