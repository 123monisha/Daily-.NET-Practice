using System;

namespace Daily_Practice
{
    public class NegativeNumberException:Exception
    {
        public NegativeNumberException(string message) : base(message)
        { }
    }
    internal class ExceptionHandling3
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number");

                int number = Convert.ToInt32(Console.ReadLine());
                if (number < 0)
                {
                    throw new NegativeNumberException("Number must be positive");
                }
                Console.WriteLine("You entered" + number);
            }
            catch (FormatException f)
            {
                Console.WriteLine(f.Message);
            }
            catch(NegativeNumberException n)
            {
                Console.WriteLine(n.Message);
            }
            finally
            {
                Console.WriteLine("Program executed Successfully");
            }
        }
            
    }
}
