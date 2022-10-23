/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/
Console.Clear();
Console.Write("Enter numbers: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;

void CountAboveZero(int[] block)
{
	for (int i = 0; i < block.Length; i++)
	{
		if (block[i] > 0)
		{
			count++;
		}
	}
}

CountAboveZero(array);
Console.WriteLine($"In your array [{string.Join(", ", array)}] is {count} numbers are above zero.");