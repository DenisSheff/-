Console.Clear();

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

for (int count = 1; count <= number; count++)
{
	if (count < number)
	{
		Console.Write(Math.Pow(count, 3) + ", ");
	}
	else
	{
		Console.WriteLine(Math.Pow(count, 3) + ".");
	}
}