using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PatternStar
    {
        static void Main2(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
