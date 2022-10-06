/*
Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98
*/

Console.Clear();
int randomNumber = new Random().Next(100, 1000);
int firstDigit = randomNumber / 100;
int thirdDigit = randomNumber % 10;

Console.WriteLine($"Number {randomNumber} is shorten to {firstDigit}{thirdDigit}.");

