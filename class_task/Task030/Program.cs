﻿/*
 Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

Console.Clear();
int[] array = new int[8];

void FilledArray(int[] collection)
{
	for (int i = 1; i < collection.Length; i++)
	{
		collection[i] = new Random().Next(0, 2);
		Console.Write($"{array[i]} ");

	}
	Console.WriteLine();
}

FilledArray(array);






