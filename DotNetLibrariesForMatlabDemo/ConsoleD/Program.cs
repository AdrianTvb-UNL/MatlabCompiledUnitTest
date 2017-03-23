using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryB;

namespace ConsoleD
{
    class Program
    {
        static void Main(string[] args)
        {
            MatlabWrapper.Run();
            Console.WriteLine("Finished successfully");
            Console.ReadLine();
        }
    }
}
