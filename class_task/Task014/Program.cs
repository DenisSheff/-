/*
Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/

Console.Clear();
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

int seven = 7;
int twentyThree = 23;

if ((number % seven == 0) && (number % twentyThree == 0))
{
	Console.WriteLine("The result is correct.");
}
else
{
	Console.WriteLine("The result is incorrect. Choose another number.");
}