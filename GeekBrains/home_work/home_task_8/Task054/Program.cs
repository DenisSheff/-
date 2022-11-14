/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
void Main()
{
	Console.Clear();

	Console.Write("Enter amount of rows: ");
	int rows = int.Parse(Console.ReadLine());

	Console.Write("Enter amount of columns: ");
	int columns = int.Parse(Console.ReadLine());

	int[,] array = CreateArray(rows, columns, 0, 10);
	PrintArray(array);
	Console.WriteLine();
	RegulateArray(array);
	PrintArray(array);
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
int[,] RegulateArray(int[,] block)
{
	for (int i = 0; i < block.GetLength(0); i++)
	{
		for (int j = 0; j < block.GetLength(1); j++)
		{
			for (int k = 0; k < block.GetLength(1) - 1; k++)
			{
				if (block[i, k] < block[i, k + 1])
				{
					int temp = block[i, k + 1];
					block[i, k + 1] = block[i, k];
					block[i, k] = temp;
				}
			}
		}
	}
	return block;
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