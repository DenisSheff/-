/*
Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

Console.Clear();
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

int PorductOfNumbers(int yourNumber)
{
	int productOfNumbers = 1;
	for (int i = 1; i <= yourNumber; i++)
	{
		productOfNumbers *= i;
	}
	return productOfNumbers;
}

Console.WriteLine($"Product of your number {number} is {PorductOfNumbers(number)}.");