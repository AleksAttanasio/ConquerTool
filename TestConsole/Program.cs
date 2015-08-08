using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConquerToolMethod;
using System.IO;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            string test = File.ReadAllText("test.txt");

            Methods.ReadCommandList(test);
            Console.ReadKey();
        }
    }
}
