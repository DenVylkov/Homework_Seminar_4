﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length -1)
        {
            Console.Write(", ");
        }
    }
} 
int [] array = new int[8];
for (var i = 0; i < array.Length; i++)
{
 array[i] = new Random().Next(0,9);   
} 
PrintArray(array);
Console.Write($" -> [");
PrintArray(array);
Console.Write("] ");
Console.WriteLine();

