using System;

namespace CalculatorProyect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            System.Console.WriteLine("Hello world");

#if DEBUG
            System.Console.WriteLine("Debug version");
#else
            System.Console.WriteLine("Realease version");
#endif


            if (i==1)
                System.Console.WriteLine("Hola a todos");
        }
    }
}
