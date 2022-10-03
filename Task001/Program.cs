/*
Напишите программу, которая на вход принимает два
числа и проверяет, является ли первое число квадратом
второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет
*/
Console.Write("Enter first number: ");
int numberOne = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int numberTwo = int.Parse(Console.ReadLine());
if (numberOne == Math.Pow(numberTwo, 2))
{
	Console.WriteLine("Answer is correct!");
}
else
{
	Console.WriteLine("Answer is wrong! Try again");
}