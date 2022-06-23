using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while ( i < 10)
            {
                i++;
                if (i % 2 == 0)
                    continue;
                Console.Write(i + " ");
            }
        }
    }
}
