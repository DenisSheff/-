/*
Напишите программу, которая будет выдавать
название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/

Console.Write("Enter weekday number: ");
int WeekDayNumber = int.Parse(Console.ReadLine());

if (WeekDayNumber == 1)
{
	Console.WriteLine("It is Monday!");
}
if (WeekDayNumber == 2)
{
	Console.WriteLine("It is Tuesday!");
}
if (WeekDayNumber == 3)
{
	Console.WriteLine("It is Wednesday!");
}
if (WeekDayNumber == 4)
{
	Console.WriteLine("It is Thursday!");
}
if (WeekDayNumber == 5)
{
	Console.WriteLine("It is Friyaaaaay!");
}
if (WeekDayNumber == 6)
{
	Console.WriteLine("It is Saturday!");
}
if (WeekDayNumber == 7)
{
	Console.WriteLine("It is Sunday!");
}