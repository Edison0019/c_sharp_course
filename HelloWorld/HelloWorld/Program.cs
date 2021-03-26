using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Course;

namespace HelloWorld
{
    //a simple program to print hello world in this
    //awesome programming languange
    class Program
    {
        static void Main(string[] args)
        {
            ClassA demo = new ClassA("Edison");
            demo.printMessageAbstract();
            demo.printMessage();
        }
    }
}
