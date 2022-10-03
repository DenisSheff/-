Console.Write("Enter your first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter your second number: ");
int secondNumber = int.Parse(Console.ReadLine());
int max;

if (firstNumber > secondNumber)
{
	max = firstNumber;
}
else
{
	max = secondNumber;
}

Console.WriteLine("Highest number is: " + max);