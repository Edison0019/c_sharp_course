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
            myStruct me = new myStruct("Edison", 23, 97);
            me.printStatement();
        }
    }
}
