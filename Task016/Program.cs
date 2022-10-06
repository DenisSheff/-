/*
Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

Console.Clear();
Console.Write("Enter first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNumber = int.Parse(Console.ReadLine());

int firstSquare = firstNumber * firstNumber;
int secondSuqare = secondNumber * secondNumber;

if (firstSquare == secondNumber)
{
	Console.WriteLine($"The number {firstNumber} is square of the {secondNumber}.");
	return;
}
if (secondSuqare == firstNumber)
{
	Console.WriteLine($"The number {secondNumber} is square of the {firstNumber}.");
	return;
}
Console.WriteLine("Your numbers are incorrect to be square of each other.");


