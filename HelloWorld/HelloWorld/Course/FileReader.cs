using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HelloWorld.Course
{
    class FileReader
    {
        //the @ sign is for scapping the backslash
        public static void printFile()
        {
        
            string path = @"C:\\Users\ediso\OneDrive\Escritorio\file.txt";
            try
            {
                StreamReader sr = new StreamReader(path);
                while (sr.EndOfStream != true)
                {
                    Console.WriteLine(sr.ReadLine());
                }
                //always close the file
                sr.Close();
            }
            catch(FileNotFoundException e){
                Console.WriteLine(e);
            }


        }
    }
}
