using System;
namespace MethodOverloadingApp
{
    class MethodOverloading
    {
        public void SomeThing()
        {
            Console.WriteLine("SomeThing() is called.");
        }
        public void SomeThing(int i)
        {
            Console.WriteLine("SomeThing(int) is called.");
        }
        public void SomeThing(int i, int j)
        {
            Console.WriteLine("SomeThing(int,int) is called.");
        }
        public void SomeThing(double d)
        {
            Console.WriteLine("SomeThing(double) is called.");
        }

    }

    public class main
    {
        public void Main()
        {

        }
    }
}