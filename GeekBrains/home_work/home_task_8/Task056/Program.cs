/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

void Main()
{
	Console.Clear();

	Console.Write("Enter amount of rows: ");
	int rows = int.Parse(Console.ReadLine());

	Console.Write("Enter amount of columns: ");
	int columns = int.Parse(Console.ReadLine());

	int minSumLine = 0;

	int[,] array = CreateArray(rows, columns, 0, 10);
	PrintArray(array);
	Console.WriteLine();
	int sumLine = FindSum(array, 0);
	for (int i = 1; i < array.GetLength(0); i++)
	{
		int tempSumLine = FindSum(array, i);
		if (sumLine > tempSumLine)
		{
			sumLine = tempSumLine;
			minSumLine = i;
		}
	}
	Console.WriteLine($"\n{minSumLine + 1} - String with the min value is ({sumLine}).");
}
int[,] CreateArray(int m, int n, int minValue, int maxValue)
{
	int[,] block = new int[m, n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			block[i, j] = new Random().Next(minValue, maxValue);
		}
	}
	return block;
}
int FindSum(int[,] array, int i)
{
	int sumLine = array[i, 0];
	for (int j = 1; j < array.GetLength(1); j++)
	{
		sumLine += array[i, j];
	}
	return sumLine;
}

void PrintArray(int[,] block)
{
	for (int i = 0; i < block.GetLength(0); i++)
	{
		for (int j = 0; j < block.GetLength(1); j++)
		{
			Console.Write($"{block[i, j]} ");
		}
		Console.WriteLine();
	}
}
Main();