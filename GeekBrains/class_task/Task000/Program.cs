/*
Напишите программу, которая на вход
принимает число и выдаёт его квадрат (число
умноженное на само себя).
Например:
4 -> 16
-3 -> 9
-7 -> 49
*/

Console.Write("Enter your number: ");
int number = int.Parse(Console.ReadLine()); //конвертирует строку в целое число (string to int)
Console.WriteLine("Square of {0} is {1}", number, Math.Pow(number, 2)); //команда перемножает само число на себя
