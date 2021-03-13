using System;

namespace HelloWorld.errorHandling
{
    class Program
    {
        public void handleError()
        {
            Console.WriteLine("Type an a value:");
            int value = Convert.ToInt32(Console.Read());
            try
            {
                Console.WriteLine(value / 0);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error happened: {0}", e);
            }
            finally
            {
                Console.WriteLine("This was executed anyways");
            }
        }
    }
}
