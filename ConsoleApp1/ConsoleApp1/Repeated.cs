using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Repeated
    {
        static void Main6(string[] args)
        {
            Console.WriteLine("Enter number of elements");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            bool[] f = new bool[n];
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                f[i] = true;
            }
            for (int j = 0; j < n; j++)
            {
                if (f[j] == true)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (a[j] == a[k])
                        {
                            c += 1;
                            f[k] = false;
                        }
                    }

                    Console.WriteLine(a[j] + " is repeated " + c + " times");
                    c = 0;
                }
            }

        }
    }
}
