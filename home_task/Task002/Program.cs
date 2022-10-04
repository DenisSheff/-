Console.Clear();
Console.Write("Enter your first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter your second number: ");
int secondNumber = int.Parse(Console.ReadLine());

/*
ПЕРВОЕ РЕШЕНИЕ
int max;
if (firstNumber > secondNumber)
{
	max = firstNumber;
}
else
{
	max = secondNumber;
}
*/

//ВТОРОЕ РЕШЕНИЕ
int max = firstNumber;

if (firstNumber < secondNumber)
{
	max = secondNumber;
}

Console.WriteLine("Highest number is: " + max);