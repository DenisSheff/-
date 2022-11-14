/*
Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
*/

Console.Clear();
Console.Write("Enter number of a quarter: ");
int quarter = int.Parse(Console.ReadLine());



if (quarter == 1)
{
	Console.WriteLine("Diaposon of the first quarter starts from 0 and goes to 2147483647 on X and Y amplitude.");
}
if (quarter == 2)
{
	Console.WriteLine("Diaposon of the first quarter starts from 0 and goes to 2147483647 on Y amplitude and from 0 to -2147483648 on X.");
}
if (quarter == 3)
{
	Console.WriteLine("Diaposon of the first quarter starts from 0 to -2147483648 on X and Y.");
}
if (quarter == 4)
{
	Console.WriteLine("Diaposon of the first quarter starts from 0 and goes to 2147483647 on X amplitude and from 0 to -2147483648 on Y.");
}