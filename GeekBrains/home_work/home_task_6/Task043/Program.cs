/*
Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();
double b1 = GetNumber();
double k1 = GetNumber();
double b2 = GetNumber();
double k2 = GetNumber();
LinesCrossing();



double GetNumber()
{
	Console.WriteLine("Enter a number: ");
	double number = int.Parse(Console.ReadLine());
	return number;
}

void LinesCrossing()
{
	double x = -(b1 - b2) / (k1 - k2);
	double y = k1 * x + b1;
	Console.WriteLine($"Lines are crossed in ({x};{y})");
}