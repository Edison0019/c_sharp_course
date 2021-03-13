using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //the loops are similar to javascript loops
            for(int val = 0;val < 1000; val += 2)
            {
                Console.WriteLine(val);
            }
            int x = 0;
            // the while loop
            while (x <= 100)
            {
                Console.WriteLine("Loop: {0}", x);
                x++;
            }
            //the foreach loop
            foreach(char i in "Edison Javier Santana")
            {
                Console.WriteLine(i);
            }
            //the do while loop (a while loop that always execute the block at least once)
            short v = 0;
            do
            {
                Console.WriteLine("Value {0}", v);
                v++;
            } while (v < 50);
        }
    }
}
