using System;

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
            var edison = new Staff("Edison", "Santana");
            edison.hoursWorked = 50;
            Console.WriteLine(edison.CalculatePay(50, 20));
            Console.WriteLine("Hello World!");
        }
    }
}
