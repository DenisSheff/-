/*
Задайте двумерный массив.
 Напишите программу, 
 которая поменяет местами первую и последнюю строку массива.
*/


Console.Clear();

Console.Write("Enter amount of rows: ");
int rows = int.Parse(Console.ReadLine());


Console.Write("Enter amount of columns: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
Console.WriteLine();
int[,] newArray = ChangeStrings(rows, columns);
PrintArray(newArray);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
	int[,] result = new int[m, n];

	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			result[i, j] = new Random().Next(minValue, maxValue);
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

int[,] ChangeStrings(int m, int n)
{
	int[,] arr = new int[m, n];

	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			if (i == 0)
			{
				arr[i, j] = array[array.GetLength(0) - 1, j];
			}
			else if (i == (array.GetLength(0) - 1))
			{
				arr[i, j] = array[0, j];
			}
			else
			{
				arr[i, j] = array[i, j];
			}
		}
	}
	return arr;
}








