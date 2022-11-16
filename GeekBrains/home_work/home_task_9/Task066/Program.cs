/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


Console.Clear();
Console.WriteLine("Enter a value: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a value: ");
int secondNumber = int.Parse(Console.ReadLine());
int sum = 0;
CalculateTheRange(firstNumber, secondNumber);

/*

for (int i = firstNumber; i <= secondNumber; i++)
{
	sum += i;
}

Console.WriteLine($"The result is {sum}.");
*/


void CalculateTheRange(int m, int n)
{
	Console.WriteLine($"The result is {sum}.");
	if (m >= n)
	{
		return;
	}
	m++;
	sum += m;
	CalculateTheRange(m, n);
}