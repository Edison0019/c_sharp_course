using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Course
{
    abstract class myAbstractClass
    {
        private string name;
        private string message = "Hello C#";

        public myAbstractClass(string NameOfUser)
        {
            name = NameOfUser;
        }
        public void printMessage()
        {
            Console.WriteLine(message + " "+ "From {0}",name);
        }
        public abstract void printMessageAbstract();
    }

    class ClassA : myAbstractClass
    {
        public override void printMessageAbstract()
        {
            Console.WriteLine("C# is fun!");
        }
        public ClassA(string name) : base(name)
        {
            Console.WriteLine("{0} created!",name);
        }
    }
}
