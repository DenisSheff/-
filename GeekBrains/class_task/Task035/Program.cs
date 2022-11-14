void Main()
{
	Console.Clear();
	int[] array = new int[123];
	FilledArray(array);
	AmountOfNumber(array);
}
void FilledArray(int[] collection)
{
	for (int i = 0; i < collection.Length; i++)
	{
		collection[i] = new Random().Next(1, 200);
	}
	Console.Write(string.Join(", ", collection));
	Console.WriteLine();
}
void AmountOfNumber(int[] block)
{
	int count = 0;
	for (int i = 0; i < block.Length; i++)
	{
		if (block[i] > 10 && block[i] < 99)
		{
			count++;
		}
	}
	Console.WriteLine($"Amount of number more than range is --> {count}");
}

Main();