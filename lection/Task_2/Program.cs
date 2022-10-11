/*
Упорядочить массив
*/

Console.Clear();
int[] arr = { 2, 4, 6, 5, 1, 3, 7, 9, 8 };

void PrintArray(int[] array)
{
	int count = arr.Length;
	for (int i = 0; i < count; i++)
	{
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
}

void SelectionSort(int[] array)
{
	for (int i = 0; i < array.Length - 1; i++)
	{
		int minPosition = i;

		for (int j = i + 1; j < array.Length; j++)
		{
			if (array[j] < array[minPosition]) minPosition = j;
		}

		int temporary = array[i];
		array[i] = array[minPosition];
		array[minPosition] = temporary;
	}
}



//Перевернуть массив, чтобы начиналось 9 8 7 ...
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);


PrintArray(arr);