using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SecondLargest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements");
            int n = int.Parse(Console.ReadLine());
            int largest = 0, secondLargest = -1;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != arr[largest])
                {
                    if (secondLargest == -1)
                        secondLargest = i;
                    else if (arr[i] > arr[secondLargest])
                        secondLargest = i;
                }
            }
            Console.WriteLine("Second largest element is: "+secondLargest);

        }
    }
}
