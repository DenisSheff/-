/*
Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
*/

Console.Clear();
int randomNumber = new Random().Next(10, 100);
int firstDigit = randomNumber / 10;
int secondDigit = randomNumber % 10;
int max = firstDigit;
if (max < secondDigit)
{
	max = secondDigit;
}

Console.WriteLine($"Your number is {randomNumber}.");
Console.WriteLine($"First digit is {firstDigit} and second digit is {secondDigit}.");
Console.WriteLine($"The highest value is {max}.");