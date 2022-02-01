using System;

namespace ConsoleApp1
{
    class NaturalNumber
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of naturals number is : {0}", sum);
        }
    }
}
