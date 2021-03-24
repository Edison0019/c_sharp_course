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
            Console.WriteLine("Hello world!");
            //we use the var type to infer
            //the data type of the object
            //the below is an example of how to import values and
            //create object from classes in files

            /*
                - we will use this namespace to test the values and the code of this course
             */
            NormalMember Javier = new NormalMember("Be humble","Javier", 2, 2018);
            VIPMember Edison = new VIPMember("Edison",1,2020);
            Javier.calculateFee();
            Edison.CalculateAnualFee();

            Console.WriteLine(Javier.ToString());
            Console.WriteLine(Edison.ToString());
        }
    }
}
