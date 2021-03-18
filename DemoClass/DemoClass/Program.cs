using System;
using Dependencies.StaticValues;
using Dependencies.staticClass;


namespace DemoClass
{
    class Staff
    {
        //private means that the values can only be accessed from
        //within the class alone
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;
        
        public int hoursWorked
        {
            get
            {
                return hWorked;
            }
            set
            {
                if(value > 0)
                {
                    //this is the backing field 
                    //of the property
                    //the field type and the property type
                    //shoul be the same
                    hWorked = value;
                }
                else
                {
                    hWorked = 0;
                }
            }
        }
        public void PrintMessage()
        {
            Console.WriteLine("Processing payment...");
        } 
        public int CalculatePay()
        {
            PrintMessage();

            int staffPay;
            staffPay = hWorked * hourlyRate;
            
            if(hWorked > 0)
            {
                return staffPay;
            }
            else
            {
                return 0;
            }
        }
        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();
            
            if(hWorked > 0)
            {
                return (hWorked * hourlyRate) + (bonus + allowance);
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return "Name of staff = " + nameOfStaff + ", hourly rate = " + hourlyRate + ", hworked = " + hWorked;
        }
        public Staff(string name)
        {
            nameOfStaff = name;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("_________________");
        }
        public Staff(string firstName, string lastName)
        {
            nameOfStaff = firstName + " " + lastName;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("_________________");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int pay;
            Staff staff1 = new Staff("Peter");
            staff1.hoursWorked = 160;
            pay = staff1.CalculatePay(1000, 400);
            Console.WriteLine("Pay = {0}", pay);

            Staff staff2 = new Staff("Jane", "Lee");
            staff2.hoursWorked = 160;
            pay = staff2.CalculatePay();
            Console.WriteLine("Pay = {0}", pay);

            Staff staff3 = new Staff("Carol");
            staff3.hoursWorked = -10;
            pay = staff3.CalculatePay();
            Console.WriteLine("Pay = {0}", pay);

            //this is a test to show static values or methods of a class
            Console.WriteLine(MyClass.greetings);
            MyClass.Age = 50;
            MyClass.DisplayAge();

            //this is for using the static class
            int[] myVals = staticClass.listElements();
            foreach(short i in myVals)
            {
                Console.WriteLine(
                    "The list I just entered is: {0}",
                    i);
            }
        }
    }
}
