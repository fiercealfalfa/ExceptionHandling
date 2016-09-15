using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReaderExample f = new FileReaderExample();
            f.ReadFile("mytext.txt");
            Console.ReadKey();
        }
    }
}
