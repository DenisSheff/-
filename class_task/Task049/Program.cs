/*
Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.
*/

Console.Clear();

Console.Write("Enter amount of rows: ");
int rows = int.Parse(Console.ReadLine());


Console.Write("Enter amount of columns: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
//GetSquareOfEven(array);
Console.WriteLine();
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
	int[,] result = new int[m, n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			result[i, j] = new Random().Next(minValue, maxValue + 1);
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

int[,] GetSquareOfEven(int[,] block)
{
	for (int i = 0; i < block.GetLength(0); i++)
	{
		for (int j = 0; j < block.GetLength(1); j++)
		{
			if (i % 2 == 0 && j % 2 == 0)
			{
				block[i, j] = i * i;
				block[i, j] = j * j;
			}
		}
	}
	return block;
}