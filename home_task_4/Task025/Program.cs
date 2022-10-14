Console.Clear();

Console.Write("Enter first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNumber = int.Parse(Console.ReadLine());

void PowerOfNumber()
{
	int powerIs = 1;
	for (int i = 0; i < secondNumber; i++)
	{
		powerIs *= firstNumber;
	}
	Console.WriteLine("{0} ^ {1} = {2}", firstNumber, secondNumber, powerIs);
}

PowerOfNumber();