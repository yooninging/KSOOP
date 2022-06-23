using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void SumAvg(int[] array)
        {
            int sum = 0;
            for (int i =0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            Console.WriteLine("두 값의 합은 : " + sum);
            Console.WriteLine("두 값의 평균은 : " + sum/array.Length);

        }
       
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 8 };

            SumAvg(arr);


        }
    }
}
