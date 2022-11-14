
void FilledArray(int[] block)
{
	for (int i = 0; i < block.Length; i++)
	{
		block[i] = new Random().Next(1, 100);
	}
	Console.WriteLine(string.Join(", ", block));
}
void DifferenceBetweenMaxAndMin(int[] collection)
{
	int minNumberIs = collection.Min();
	int maxNumberIs = collection.Max();
	int diferenceIs = maxNumberIs - minNumberIs;
	Console.WriteLine(diferenceIs);
}


Console.Clear();
int[] array = new int[10];
FilledArray(array);
DifferenceBetweenMaxAndMin(array);