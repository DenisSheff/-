Console.Clear();

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

void SumOfDigits()
{
	int sum = 0;
	while (number > 0)
	{
		sum = sum + number % 10;
		number /= 10;
	}
	Console.WriteLine($"Sum of your number is {sum}.");
}

SumOfDigits();