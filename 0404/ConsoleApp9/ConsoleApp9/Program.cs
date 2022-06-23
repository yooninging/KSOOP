using System;

namespace ConsoleApplication8
{
    class A
    {
        public int num1, num2;
        public A()
        {
            Console.WriteLine("부모 클래스 호출");
        }
    }
    class B : A
    {
        public B(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
            Console.WriteLine("자식 클래스 호출");
        }
        public void Plus()
        {
            Console.WriteLine(num1 + num2);
        }
    }
    class main
    {
        static void Main(string[] args)
        {
            B cd = new B(20, 30);
            cd.Plus();
        }
    }
}