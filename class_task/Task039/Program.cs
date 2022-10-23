/*
Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]

[6 7 3 6] -> [6 3 7 6]
*/


void Main()
{
	Console.Clear();
	int[] array = GetArray(5, 0, 10);
	PrintArray(array);
	//	ReverseArray(array);
	//PrintArray(array);
	int[] reverseArray = RecerseCollection(array);
	PrintArray(reverseArray);
}

int[] GetArray(int size, int minValue, int maxValue)
{
	int[] res = new int[size];
	for (int i = 0; i < size; i++)
	{
		res[i] = new Random().Next(minValue, maxValue + 1);
	}
	return res;
}

void PrintArray(int[] block)
{
	Console.WriteLine($"[{string.Join(", ", block)}]");
}

void ReverseArray(int[] collection)
{
	for (int i = 0; i < collection.Length / 2; i++)
	{
		int k = collection[i];
		collection[i] = collection[collection.Length - 1 - i];
		collection[collection.Length - 1 - i] = k;
	}
}

int[] RecerseCollection(int[] collection)
{
	int[] result = new int[collection.Length];
	for (int i = 0; i < collection.Length; i++)
	{
		result[i] = collection[collection.Length - 1 - i];
	}
	return result;
}

Main();
