using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Course
{
    class anotherClass
    {
        public string name;
    }

    struct myStruct
    {
        enum Days
        {
            mon, tue, wed, thu, fri, sat, sun
        }
        private int x, y;
        private Days myDays;
        private anotherClass myClass;

        public myStruct(string a, int b, int c){
            myClass = new anotherClass();
            myClass.name = a;
            x = b;
            y = c;
            myDays = Days.mon;
        }

        public void printStatement()
        {
            Console.WriteLine("x = {0}, y = {1}, myDays = {2}", x, y, myDays);
        }
    }
}
