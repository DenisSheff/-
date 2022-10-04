Console.Clear();
Console.Write("Enter any three digits: ");
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

int max = 0;

/*
ПЕРВОЕ РЕШЕНИЕ
if ((firstNumber > secondNumber) && (firstNumber > secondNumber))
{
	max = firstNumber;
}
if ((secondNumber > firstNumber) && (secondNumber > thirdNumber))
{
	max = secondNumber;
}
if ((thirdNumber > firstNumber) && (thirdNumber > secondNumber))
{
	max = thirdNumber;
}
*/

//ОПТИМИЗАЦИЯ РЕШЕНИЯ
if (firstNumber > secondNumber)
{
	max = firstNumber;
}
else
{
	if (secondNumber > thirdNumber)
	{
		max = secondNumber;
	}
	else
	{
		max = thirdNumber;
	}
}

Console.WriteLine("Highest number is: " + max);
