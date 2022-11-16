/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

void Main()
{
	Console.Clear();
	Console.WriteLine("Enter a value: ");
	int firstNumber = int.Parse(Console.ReadLine());
	Console.WriteLine("Enter a value: ");
	int secondNumber = int.Parse(Console.ReadLine());
	int sum = 0;
	Console.WriteLine(CalculateTheRange(firstNumber, secondNumber));
}
int CalculateTheRange(int m, int n)
{
	if (m == n)
	{
		return n;
	}
	return m + CalculateTheRange(m + 1, n);

	//return m == n ? n : m + CalculateTheRange(m + 1, n);
}

Main();