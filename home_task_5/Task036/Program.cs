void Main()
{
	Console.Clear();
	int[] array = new int[5];
	FilledArray(array);
	OddNumbersSum(array);
}

void FilledArray(int[] block)
{
	for (int i = 0; i < block.Length; i++)
	{
		block[i] = new Random().Next(1, 10);
	}
	Console.WriteLine(string.Join(", ", block));
}

void OddNumbersSum(int[] collection)
{
	int sum = 0;
	for (int i = 0; i < collection.Length; i++)
	{
		if (collection[i] % 2 != 0)
		{
			sum = sum + collection[i];
		}
	}
	Console.WriteLine(sum);
}

Main();