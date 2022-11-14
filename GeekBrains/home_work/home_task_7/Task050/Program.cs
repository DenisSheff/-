/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

[1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)
*/

Console.Clear();

Console.Write("Enter amount of rows: ");
int rows = int.Parse(Console.ReadLine());


Console.Write("Enter amount of columns: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
FindPosition(array);

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

void FindPosition(int[,] inBlock)
{
	Console.Write("Enter coordiintares of the number: ");
	int horizontalCoordinate = int.Parse(Console.ReadLine());
	int verticalCoordinate = int.Parse(Console.ReadLine());
	if (rows < horizontalCoordinate && columns < verticalCoordinate)
	{
		Console.WriteLine("According to given coordinates there is no a number.");
	}
	else
	{
		object positionIs = inBlock.GetValue(horizontalCoordinate, verticalCoordinate);
		Console.WriteLine($"There is  a such number: {positionIs}.");
	}
}
