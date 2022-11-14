/*
Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка.
*/

Console.Clear();
Console.Write("Enter X: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Enter Y: ");
int y = int.Parse(Console.ReadLine());
/*
if (x > 0 && y > 0)
{
	Console.WriteLine($"Your x({x}) coordinate and y({y}) coordinate are located in first quarter");
}
if (x < 0 && y > 0)
{
	Console.WriteLine($"Your x({x}) coordinate and y({y}) coordinate are located in second quarter");
}
if (x < 0 && y < 0)
{
	Console.WriteLine($"Your x({x}) coordinate and y({y}) coordinate are located in third quarter");
}
if (x > 0 && y < 0)
{
	Console.WriteLine($"Your x({x}) coordinate and y({y}) coordinate are located in fourth quarter");
}
*/

if (x > 0)
{
	if (y > 0)
		Console.WriteLine($"Your x({x}) coordinate and y({y}) coordinate are located in first quarter");
	else
	{
		Console.WriteLine($"Your x({x}) coordinate and y({y}) coordinate are located in fourth quarter");
	}
}
if (x < 0)
{
	if (y > 0)
		Console.WriteLine($"Your x({x}) coordinate and y({y}) coordinate are located in second quarter");
	else
	{
		Console.WriteLine($"Your x({x}) coordinate and y({y}) coordinate are located in third quarter");
	}
}