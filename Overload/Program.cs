using System;

namespace Overload
{
    class Program
    {

        static int CreateMessage(int a, int b)
        {

            return a + b;
        }

        static string CreateMessage()
        {
            string message = "Hello";
            return message;
        }

        static void Main(string[] args)
        {
            string result = CreateMessage();
            Console.WriteLine(result);
        }

       
    }

   
  

}
