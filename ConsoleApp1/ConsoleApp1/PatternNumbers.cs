using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PatternNumbers
    {
        static void Main3(string[] args)
        {
            int  k=1;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(k+" ");
                    k += 1;
                }
                Console.Write("\n");
            }
        }
    }
    }
