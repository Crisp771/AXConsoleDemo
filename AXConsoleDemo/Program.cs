using System;

namespace AXConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Displaying content of NuGet Package Method AXTest().HelloWorld()");
            Console.WriteLine($"================================================================");
            Console.WriteLine(new AXTest.AXTest().HelloWorld());
            Console.WriteLine($"================================================================");
            Console.ReadLine();
        }
    }
}
