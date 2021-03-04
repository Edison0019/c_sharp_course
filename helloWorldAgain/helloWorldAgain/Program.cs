using System;

namespace helloWorldAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "";
            int userAge = 0;
            int currentYear = 0;
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the current year: ");
            currentYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(
                "Hello world! my name is {0} my age is {1} in the year {2}",
                userName,
                userAge,
                currentYear
                );
        }
    }
}
