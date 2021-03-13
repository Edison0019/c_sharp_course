using System;

namespace switchStatement
{
    class Program
    {
        static void Main(String[] args)
        {
            string myGrade;
            Console.Write("Type your grade: ");
            myGrade = Console.ReadLine();
            switch (myGrade)
            {
                case "A+":
                    Console.Write("congratulations");
                    break;
                case "A":
                    Console.Write("You are a ninja");
                    break;
                case "B":
                    Console.Write("I love it!!");
                    break;
            }

        }
    }
}
