//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Practice_Bhai
//{
//    public class AgeNotValidException:Exception
//    {
//        public AgeNotValidException(string message):base(message)
//        {
//            Console.WriteLine(message);

//        }
//    }
//    internal class Exception1
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                Console.WriteLine("Enter the Age ");
//                int age = Convert.ToInt32(Console.ReadLine());
//                if(age<18)
//                {
//                    throw new AgeNotValidException("Age is not valid");
//                }
//                else
//                {
//                    Console.WriteLine("You ar eligible");
//                }
//            }
//            catch(AgeNotValidException)
//            {

//            }
//        }
//    }
//}
