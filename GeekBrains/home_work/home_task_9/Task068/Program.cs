/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


Console.Clear();
Console.WriteLine("Enter a first value: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a second value: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine($"The result is {CalculateA(firstNumber, secondNumber)}.");


int CalculateA(int m, int n)
{
	if (m == 0)
	{
		return n + 1;
	}
	if ((m > 0) && (n == 0))
	{
		return CalculateA(m - 1, 1);
	}
	return CalculateA(m - 1, CalculateA(m, n - 1));
}



