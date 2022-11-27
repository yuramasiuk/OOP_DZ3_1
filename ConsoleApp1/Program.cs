using System;

namespace InputOutputConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            int usersNumber;
            Console.Write("Enter a number ");
            usersNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered " + usersNumber);
        }
    }
}