using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Fact
    {
        static void Main5(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            fact(n);
        }

        static void fact(int n)
        {

            int res = 1;
            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }
            Console.WriteLine(res);

        }
    }
}
