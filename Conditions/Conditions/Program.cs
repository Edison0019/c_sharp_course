using System;



namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge;
            Console.Write("Please enter your age: ");
            myAge = Convert.ToInt32(Console.ReadLine());
            string myName = "Edison Santana";
            if (myAge > 100 || myAge < 0)
            {
                Console.Write("Invalid age {0}",myName);
            }
            else if(myAge < 18)
            {
                Console.Write("Sorry you are minor yet {0}",myName);
            }
            else if(myAge < 21)
            {
                Console.Write("You need parental consent {0}",myName);
            }
            else
            {
                Console.Write("You can apply whenever you want {0}",myName);
            }
        }
    }
}
