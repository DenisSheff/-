void Main()
{
	Console.Clear();
	int[] block = new int[10];
	NewBlock(block);
	EvenNumbersCounter(block);
}


void NewBlock(int[] block)
{
	for (int i = 0; i < block.Length; i++)
	{
		block[i] = new Random().Next(100, 999);
	}
	Console.WriteLine($"Your collection is filled with next numbers: [{string.Join(", ", block)}].");
}
void EvenNumbersCounter(int[] collection)
{
	int count = 0;
	for (int i = 0; i < collection.Length; i++)
	{
		if ((collection[i] % 2) == 0)
		{
			count++;
		}
	}
	Console.WriteLine($"Amount of even numbers in your collection [{string.Join(", ", collection)}] is {count}.");
}

Main();
