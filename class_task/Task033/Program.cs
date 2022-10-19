Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
	int[] res = new int[size];
	for (int i = 0; i < size; i++)
	{
		res[i] = new Random().Next(minValue, maxValue + 1);
		Console.Write($"{res[i]} ");
	}
	Console.WriteLine();
	return res;
}



int[] array = GetArray(5, -10, 10);
Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());

bool digit = false;
foreach (int element in array)
{
	if (element == number)
	{
		digit = true;
	}
}
if (digit == false)
{
	Console.WriteLine($"In your array [{string.Join(" ", array)}] there is not number {number};");
}
else
{
	Console.WriteLine($"In your array [{string.Join(" ", array)}] there is number {number};");
}



