/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
Console.Clear();

Console.Write("Enter amount of rows: ");
int rows = int.Parse(Console.ReadLine());


Console.Write("Enter amount of columns: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
	int[,] block = new int[m, n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			block[i, j] = new Random().Next(minValue, maxValue + 1);
		}
	}
	return block;
}

void PrintArray(int[,] inCollection)
{
	for (int i = 0; i < inCollection.GetLength(0); i++)
	{
		for (int j = 0; j < inCollection.GetLength(1); j++)
		{
			Console.Write($"{inCollection[i, j]} ");
		}
		Console.WriteLine();
	}
}