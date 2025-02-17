﻿
Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
	int[] res = new int[size];
	for (int i = 0; i < size; i++)
	{
		res[i] = new Random().Next(minValue, maxValue + 1);
		Console.Write($"{res[i]} ");
	}
	return res;
}

int[] array = GetArray(12, -9, 9);
int positiveSum = 0;
int negativeSum = 0;
foreach (int element in array)
{
	if (element > 0)
	{
		positiveSum += element;
	}
	else
	{
		negativeSum += element;
	}
}

Console.WriteLine();
Console.WriteLine($"Sum of the positive numbers in your array is {positiveSum} and sum of the negative numbers is {negativeSum}.");