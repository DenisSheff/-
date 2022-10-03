Console.Clear();
Console.Write("Enter any three digits: ");
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

int max = 0;

if ((firstNumber > secondNumber) && (firstNumber > thirdNumber))
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

Console.WriteLine("Highest number is: " + max);
