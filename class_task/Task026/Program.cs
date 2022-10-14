/*
Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 
*/

Console.Clear();
Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());

int GetQuantityOfDigits()
{
	int digits = 0;
	while (number > 0)
	{
		number /= 10;
		digits++;
	}
	return digits;
}

Console.WriteLine($"Quantity of your digits is {GetQuantityOfDigits()}.");