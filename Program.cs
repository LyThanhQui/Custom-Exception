using System;
using System.Runtime.Serialization;

namespace Custom_Exception
{
    //example1
    /* public class OddNumberException : Exception
     {
         //Overriding the Message property
         public override string Message
         {
             get
             {
                 return "divisor cannot be odd number";
             }
         }
     }
     class Program
     {
         static void Main(string[] args)
         {
             int x, y, z;
             Console.WriteLine("ENTER TWO INTEGER NUMBERS:");
             x = int.Parse(Console.ReadLine());
             y = int.Parse(Console.ReadLine());
             try
             {
                 if (y % 2 > 0)
                 {
                    // OddNumberException ONE = new OddNumberException();
                     //throw ONE;
                    throw new OddNumberException();
                 }
                 z = x / y;
                 Console.WriteLine(z);
             }
             catch (OddNumberException one)
             {
                 Console.WriteLine(one.Message);
             }
             Console.WriteLine("End of the program");
             Console.ReadKey();
         }
     }*/
    //Example2: Create a custom exception in C#:
    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException(string message)
            : base(message)
        {
        }
        public UserAlreadyLoggedInException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedInException("User Already logged in");
            }
            catch (UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("End of the program");
            Console.ReadKey();
        }
    }

}
