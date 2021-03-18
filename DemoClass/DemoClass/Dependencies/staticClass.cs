using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencies.staticClass
{
    //this is a simple example of a static class
    static class staticClass
    {
        //uncommenting the below example will generate an error
        //public int elements = 100;
        public static int a = 0;
        public static int B { get; set; } 

        //we can create methods that accept strings as arguments

        public static void printVal(int[] val)
        {
            //in order for this method to work
            //we need to pass an array as argument
            Console.WriteLine("The value is {0}", val[0]);
        }
        public static void printListVal(List<int> listado)
        {
            Console.WriteLine("The first element of the list is \n{0}", listado[0]);
        }

        //we can also return collection types from methods like
        public static int[] listElements()
        {
            //here we are specifying the length of the array
            int[] a = new int[3];
            for(short i = 0; i < a.Length; i++)
            {
                Console.WriteLine("type value here:");
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            return a;

        }
    }
}
