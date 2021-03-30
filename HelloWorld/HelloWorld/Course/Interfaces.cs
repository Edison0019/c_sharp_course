using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Course
{
    interface Ishape
    {
        void InterfaceMethod();

        int MyNumber
        {
            get;
            set;
        }

    }

    class InterfaceTest : Ishape
    {
        private int myNumber;
        public int MyNumber
        {
            get
            {
                return myNumber;
            }
            set
            {
                if(value < 0)
                {
                    myNumber = 0;
                }
                else
                {
                    myNumber = value;
                }
            }
        }
        public void InterfaceMethod()
        {
            Console.WriteLine("My number is {0}", myNumber);
        }
    }


}
