﻿/*
Задайте значение N. Напишите программу, 
которая выведет все чётные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "4, 2"
N = 8 -> "8, 6, 4, 2,"
*/

Console.Clear();
Console.WriteLine("Enter a value: ");
int number = int.Parse(Console.ReadLine());
ShowEven(number);

void ShowEven(int n)
{

	if (number % 2 == 0)
	{
		number -= 2;
		Console.WriteLine(number + " ");
	}
	ShowEven(n - 1);
}

