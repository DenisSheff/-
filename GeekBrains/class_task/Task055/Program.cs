/*
Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.
*/
Console.Clear();

Console.Write("Enter amount of rows: ");
int rows = int.Parse(Console.ReadLine());


Console.Write("Enter amount of columns: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
Console.WriteLine();
if (rows == columns)
{
	int[,] newArray = CreateNewArray(rows, columns);
	PrintArray(newArray);
}
else
{
	Console.WriteLine("Error!");
}


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

int[,] CreateNewArray(int m, int n)
{
	int[,] arr = new int[m, n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			arr[i, j] = array[j, i];
		}
	}
	return arr;
}








