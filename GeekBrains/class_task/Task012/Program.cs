/*
Напишите программу, которая будет принимать на
вход два числа и выводить, является ли второе число
кратным первому. Если число 2 не кратно числу 1, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/
Console.Clear();
Console.Write("Enter first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNumber = int.Parse(Console.ReadLine());
int remainder = firstNumber % secondNumber;
if (firstNumber < secondNumber)
{
	Console.WriteLine("Your first number is less than second one to have integer value.");
}
else
{
	if (remainder == 0)
	{
		Console.WriteLine("Your numbers are multiple.");
	}
	else
	{
		Console.WriteLine($"Your numbers are not multiple. Remainder is {remainder}.");
	}
}