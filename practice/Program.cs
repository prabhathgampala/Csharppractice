using System;
using System.Collections.Generic;
{
    Console.WriteLine("Enter 10 numbers");
    int[] array= new int[10];
    for (int i = 0; i < 10; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    int res = int.MaxValue;
    for (int i = 0; i < 10; i++)
    {
        if (array[i] < res)
        {
            res = array[i];
        }
    }
    Console.WriteLine(res);

} 
