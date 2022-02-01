﻿using System;

public class Transpose
{
    public static void Main(string[] args)
    {
        int[,] arr = new int[4, 4] { { 1, 2 ,3,4,}, { 5,6,7,8},{ 9,10,11,12} ,{13,14,15,16 } };
        int[,] b = new int[4, 4];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                b[i, j] = arr[j, i];
            }
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(b[i, j]+",");
                Console.WriteLine("");
            }

        }
    }
}