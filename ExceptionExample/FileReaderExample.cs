using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionExample
{
    class FileReaderExample
    {

        public void ReadFile(string file)
        {
            try
            {
                //It is important to remember that if an exception is thrown, the code will jump
                //to right to the catch, and will not execute the rest of the try block. 
                StreamReader s = new StreamReader(file);
                string data = s.ReadToEnd();
                Console.WriteLine(data);
            }
            catch(Exception e)
            {
                //Remember, normally you would log an error here
                Console.WriteLine(e);
                Console.WriteLine("Please do things right");
                GetFileName();
                
            }
            finally
            {
                //This is where you would clean up, close DB connections and whatnot
                Console.WriteLine("Finally");
            }
        }

        private void GetFileName()
        {
            Console.WriteLine("Please Enter a file path");
            string path = Console.ReadLine();
            ReadFile(path);
        }
    }
}
