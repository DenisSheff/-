/*
Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

Console.Write("Enter your number: ");
int number = int.Parse(Console.ReadLine());
if ((number > 99 && number < 999) || (number < -99 && number > -999))
{
	int lastNumber = number % 10;
	if (lastNumber < 0)
	{
		lastNumber = lastNumber * (-1);
	}
	Console.WriteLine(lastNumber);
}
else
{
	Console.WriteLine("Incorrect number");
}


