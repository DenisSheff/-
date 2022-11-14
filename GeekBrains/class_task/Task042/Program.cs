/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

45 -> 101101

3  -> 11

2  -> 10
*/

Console.Clear();
Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());
ToBinary(number);

void ToBinary(int digit)
{
	string binaryNumber = " ";
	while (number > 0)
	{
		binaryNumber = (number % 2) + binaryNumber;
		number /= 2;
	}
	Console.WriteLine(binaryNumber);
}