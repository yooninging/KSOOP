using System;

namespace hello
{
    internal class ProgramFirst
    {
        static void Main(string[] args)
        {
            Boolean b = false;

            Console.WriteLine("Enter a number");
            int a = int.Parse(Console.ReadLine());

            if (a % 4 == 0)
            {
                b = true;
                if (a % 100 == 0)
                {
                    b = false;
                    if (a % 400 == 0)
                    {
                        b = true;
                    }
                }
            }


            if (b == true)
            {
                Console.WriteLine("윤년입니다.");
            }
            else if (b == false)
            {
                Console.WriteLine("평년입니다.");
            }

        }
    }
}
