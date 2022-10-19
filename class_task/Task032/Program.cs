Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
	int[] res = new int[size];
	for (int i = 0; i < size; i++)
	{
		res[i] = new Random().Next(minValue, maxValue + 1);
		Console.Write($"{res[i]} ");
	}
	return res;
}


int[] array = GetArray(5, -5, 4);

/*int[] OppositeSide(int[] collection)*/
{
	/*for (int i = 0; i < array.Length; i++)
	{

		if (collection[i] > 0 || collection[i] < 0)
		{
			collection[i] *= (-1);
		}
		Console.Write($"{collection[i]} ");
	}*/

}
void Gap()
{
	Console.WriteLine();
}
int i = 0;
foreach (int item in array)
{
	array[i] = item * (-1);
	i++;
}

Gap();
Console.Write(string.Join(" ", array));
Gap();