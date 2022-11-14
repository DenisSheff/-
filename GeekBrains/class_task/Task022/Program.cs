/*
Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.Clear();
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

for (int count = 1; count <= number; count++)
{
	if (count < number)
	{
		Console.Write(Math.Pow(count, 2) + ", ");
	}
	else
	{
		Console.WriteLine(Math.Pow(count, 2) + ".");
	}
}