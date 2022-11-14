/*
Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

Console.Clear();
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

int GetSumOfNumbers(int chosenNumber)
{
	int sum = 0;
	while (chosenNumber > 0)
	{
		sum += chosenNumber;
		chosenNumber--;
	}
	return sum;
}

Console.WriteLine($"Sum of all number before your number {number} is {GetSumOfNumbers(number)}");