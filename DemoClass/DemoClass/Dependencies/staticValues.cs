using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencies.StaticValues
{
    class MyClass
    {
        //non static members
        public MyClass(string greeting)
        {
            message = greeting;
        }
        public string message = "Hello world";
        public string Name { get; set; }
        public void displayMessage()
        {
            Console.WriteLine("Name = {0}", Name);
        }

        //static members
        public static string greetings = "Good morning";
        public static int Age { get; set; }
        public static void DisplayAge()
        {
            Console.WriteLine("Age = {0}", Age);
        }
    }
}
