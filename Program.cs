﻿using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[10,10];
            for (int i = 1; i <= 10; i++){
                for (int j = 1; j <=10; j++){
                    array2D[i-1, j-1] = i*j;
                        System.Console.Write(array2D[i-1,j-1]);

                }
            System.Console.WriteLine();
            }
        }
    }
}
