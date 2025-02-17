﻿/*
Задача 48: Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

Console.Clear();

Console.Write("Enter amount of rows: ");
int rows = int.Parse(Console.ReadLine());


Console.Write("Enter amount of columns: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
	int[,] result = new int[m, n];

	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			result[i, j] = i + j;
		}
	}
	return result;
}

void PrintArray(int[,] inArray)
{
	for (int i = 0; i < inArray.GetLength(0); i++) //строки – 0
	{
		for (int j = 0; j < inArray.GetLength(1); j++) //столбцы – 1
		{
			Console.Write($"{inArray[i, j]} ");
		}
		Console.WriteLine();
	}
}