using System;

namespace HelloWorld.switchStatement
{
    class Program
    {
        public void switchStatement()
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
