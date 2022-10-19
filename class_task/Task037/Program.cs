
Console.Clear();

int[] array = new int[3];

void FilledArray(int[] collection)
{
	for (int i = 0; i < collection.Length; i++)
	{
		collection[i] = new Random().Next(1, 10);
	}
	Console.Write(string.Join(", ", collection));
	Console.WriteLine();
}

void SumOfCouples(int[] block)
{
	int firstDigitIs = block[0];
	int secondDigitIs = block.Length - 1;
	int result = 0;
}

FilledArray(array);
SumOfCouples(array);